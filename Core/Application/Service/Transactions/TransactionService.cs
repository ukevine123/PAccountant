using Application.Interface;
using Application.DTO;
using Domain.Entities;

namespace Application.Service.Transactions
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransaction _transactionRepo;

        public TransactionService(ITransaction transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }

        public async Task<(bool Success, string? Error)> AddTransactionAsync(Transaction transaction)
        {
            // 1. Validation
            if (transaction.Amount <= 0)
                return (false, "Amount must be greater than zero.");

            try
            {
                // --- STEP A: HANDLE MONEY LEAVING (FromAccountId) ---
                if (!string.IsNullOrWhiteSpace(transaction.FromAccountId))
                {
                    // Check if it's a regular Bank/Cash Account
                    var account = await _transactionRepo.GetAccountByIdAsync(transaction.FromAccountId);
                    if (account != null)
                    {
                        account.Balance -= transaction.Amount;
                        await _transactionRepo.UpdateAccountAsync(account);
                    }
                    // Add logic here if 'From' could also be an Asset/Liability
                }

                // --- STEP B: HANDLE MONEY ARRIVING (ToAccountId) ---
                if (!string.IsNullOrWhiteSpace(transaction.ToAccountId))
                {
                    // 1. Check if it's a Bank/Cash Account
                    var account = await _transactionRepo.GetAccountByIdAsync(transaction.ToAccountId);
                    if (account != null)
                    {
                        account.Balance += transaction.Amount;
                        await _transactionRepo.UpdateAccountAsync(account);
                    }

                    // 2. Check if it's a Liability (Paying off a debt)
                    var liability = await _transactionRepo.GetLiabilityByIdAsync(transaction.ToAccountId);
                    if (liability != null)
                    {
                        // Requirement 3.3: "When a Debt is repaid... Liability balance must decrease"
                        liability.Value -= transaction.Amount; 
                        await _transactionRepo.UpdateLiabilityAsync(liability);
                    }

                    // 3. Check if it's an Asset (Lending money to someone)
                    var asset = await _transactionRepo.GetAssetByIdAsync(transaction.ToAccountId);
                    if (asset != null)
                    {
                        // Requirement 2.C: Money lent is an Asset. Lending increases the asset value.
                        asset.Value += transaction.Amount;
                        await _transactionRepo.UpdateAssetAsync(asset);
                    }
                }

                // --- STEP C: RECORD THE TRANSACTION ---
                return await _transactionRepo.AddTransactionAsync(transaction);
            }
            catch (Exception ex)
            {
                return (false, $"Internal Error: {ex.Message}");
            }
        }

        public async Task<TransactionDto?> GetTransactionAsync(string id)
        {
            return await _transactionRepo.GetTransactionAsync(id);
        }

        public async Task<IEnumerable<TransactionDto>> GetRecentTransactionsAsync(int count = 20)
        {
            return await _transactionRepo.GetRecentTransactionsAsync(count);
        }

        public async Task<IEnumerable<TransactionDto>> GetTransactionsByDateRangeAsync(DateTime s, DateTime e)
        {
            return await _transactionRepo.GetTransactionsByDateRangeAsync(s, e);
        }

        public async Task<IEnumerable<TransactionDto>> GetTransactionsByCategoryAsync(string id)
        {
            return await _transactionRepo.GetTransactionsByCategoryAsync(id);
        }
    }
}