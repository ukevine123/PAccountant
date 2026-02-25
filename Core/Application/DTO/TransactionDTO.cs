using Domain.Entities;

namespace Application.DTO
{
    public class CreateTransactionRequest
    {
        public TransactionKind Kind { get; set; }
        public string FromAccountId { get; set; } = string.Empty;
        public string ToAccountId { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public int CategoryId { get; set; } // Changed from string to int to match Entity

    }

    public class TransactionDto
    {
        public int Id { get; set; } 
        public TransactionKind Kind { get; set; }
        public string FromAccountId { get; set; } = string.Empty;
        public string ToAccountId { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string CategoryId { get; set; } 
        public string CategoryName { get; set; } = string.Empty;
    }
}