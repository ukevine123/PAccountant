using Application.DTO;
using Domain.Entities; 

namespace Application.Interface
{
    public interface ITransactionService
    {
        
        Task<(bool Success, string? Error)> AddTransactionAsync(Transaction transaction);
        
        Task<TransactionDto?> GetTransactionAsync(string id);
        Task<IEnumerable<TransactionDto>> GetRecentTransactionsAsync(int count = 20);
        Task<IEnumerable<TransactionDto>> GetTransactionsByDateRangeAsync(DateTime startDate, DateTime endDate);
        Task<IEnumerable<TransactionDto>> GetTransactionsByCategoryAsync(string categoryId);
    }
}