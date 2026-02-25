namespace Domain.Entities
{
    public class Account
    {
        public string Id { get; set; }= string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? Number { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedById { get; set; }
        public List<Transaction> Transactions { get; } = new();
    }
}