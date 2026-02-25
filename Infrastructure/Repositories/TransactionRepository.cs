using Application.Interface;
using Application.DTO;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class TransactionRepository : ITransaction
    {
        private readonly ApplicationDbContext _dbContext;

        public TransactionRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        #region Transaction Methods

        public async Task<(bool Success, string? Error)> AddTransactionAsync(Transaction transaction)
        {
            try 
            {
                _dbContext.Transactions.Add(transaction);
                await _dbContext.SaveChangesAsync();
                return (true, null);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<TransactionDto?> GetTransactionAsync(string id)
        {
            var t = await _dbContext.Transactions.FindAsync(id);
            if (t == null) return null;

            return new TransactionDto
            {
                Id = t.Id,
                Kind = t.Kind,
                FromAccountId = t.FromAccountId,
                ToAccountId = t.ToAccountId,
                Amount = t.Amount,
                Date = t.Date,
                CategoryId = t.CategoryId
            };
        }

        public async Task<IEnumerable<TransactionDto>> GetRecentTransactionsAsync(int count = 20)
        {
            return await _dbContext.Transactions
                .OrderByDescending(t => t.Date)
                .Take(count)
                .Select(t => new TransactionDto
                {
                    Id = t.Id,
                    Kind = t.Kind,
                    Amount = t.Amount,
                    Date = t.Date,
                    FromAccountId = t.FromAccountId,
                    ToAccountId = t.ToAccountId,
                    CategoryId = t.CategoryId
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<TransactionDto>> GetTransactionsByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await _dbContext.Transactions
                .Where(t => t.Date >= startDate && t.Date <= endDate)
                .OrderByDescending(t => t.Date)
                .Select(t => new TransactionDto
                {
                    Id = t.Id,
                    Kind = t.Kind,
                    Amount = t.Amount,
                    Date = t.Date,
                    FromAccountId = t.FromAccountId,
                    ToAccountId = t.ToAccountId,
                    CategoryId = t.CategoryId
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<TransactionDto>> GetTransactionsByCategoryAsync(string categoryId)
        {
            return await _dbContext.Transactions
                .Where(t => t.CategoryId == categoryId)
                .OrderByDescending(t => t.Date)
                .Select(t => new TransactionDto
                {
                    Id = t.Id,
                    Kind = t.Kind,
                    Amount = t.Amount,
                    Date = t.Date,
                    FromAccountId = t.FromAccountId,
                    ToAccountId = t.ToAccountId,
                    CategoryId = t.CategoryId
                })
                .ToListAsync();
        }

        #endregion

        #region Account Methods

        public async Task<Account?> GetAccountByIdAsync(string id)
        {
            return await _dbContext.Accounts.FindAsync(id);
        }

        public async Task UpdateAccountAsync(Account account)
        {
            _dbContext.Accounts.Update(account);
            await _dbContext.SaveChangesAsync();
        }

        #endregion

        #region Asset Methods (New)

        public async Task<Asset?> GetAssetByIdAsync(string id)
        {
            // Checks if the ID provided in ToAccountId/FromAccountId is an Asset
            return await _dbContext.Assets.FindAsync(id);
        }

        public async Task UpdateAssetAsync(Asset asset)
        {
            _dbContext.Assets.Update(asset);
            await _dbContext.SaveChangesAsync();
        }

        #endregion

        #region Liability Methods (New)

        public async Task<Liability?> GetLiabilityByIdAsync(string id)
        {
            // Checks if the ID provided in ToAccountId/FromAccountId is a Liability
            return await _dbContext.Liabilities.FindAsync(id);
        }

        public async Task UpdateLiabilityAsync(Liability liability)
        {
            _dbContext.Liabilities.Update(liability);
            await _dbContext.SaveChangesAsync();
        }

        #endregion
    }
}