namespace Domain.Entities
{
    public class Transaction
    {
    public string Id { get; set; } 
    public string FromAccountId { get; set; } 
    public string ToAccountId { get; set; } 
    public decimal Amount { get; set; }
    public DateTime Date { get; set; } = DateTime.UtcNow;
    public string CategoryId { get; set; } 
   
    }
}