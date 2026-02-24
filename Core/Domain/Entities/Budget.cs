namespace Domain.Entities
{
    public class Budget
    {
        public int Id { get; set; }
        public BudgetCategory Category { get; set; }
        public int CategoryId { get; set; } 
        public string Name { get; set; } = string.Empty;
        public decimal MonthlyLimit { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        
        // Add these two lines:
        public int CustomerId { get; set; } 
        public int UpdatedById { get; set; }
    }
}