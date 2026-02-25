namespace Domain.Entities;

public class Budget
{
    public int Id { get; set; }
    public int CategoryId { get; set; } 
    public decimal MonthlyLimit { get; set; }
}
