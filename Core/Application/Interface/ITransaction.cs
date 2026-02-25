using Domain.Entities;
using Application.DTO;

namespace Application.Interface
{
    public interface ITransaction
    {
        // Transaction methods
        Task<(bool Success, string? Error)> AddTransactionAsync(Transaction transaction);
        Task<TransactionDto?> GetTransactionAsync(string id);
        Task<IEnumerable<TransactionDto>> GetRecentTransactionsAsync(int count = 20);
        Task<IEnumerable<TransactionDto>> GetTransactionsByDateRangeAsync(DateTime startDate, DateTime endDate);
        Task<IEnumerable<TransactionDto>> GetTransactionsByCategoryAsync(string categoryId);

        // Account methods
        Task<Account?> GetAccountByIdAsync(string id);
        Task UpdateAccountAsync(Account account);

        // Asset methods
        Task<Asset?> GetAssetByIdAsync(string id);
        Task UpdateAssetAsync(Asset asset);

        // Liability methods
        Task<Liability?> GetLiabilityByIdAsync(string id);
        Task UpdateLiabilityAsync(Liability liability);
    }
}