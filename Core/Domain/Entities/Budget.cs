namespace Domain.Entities;

public class Budget
{
    public int Id { get; set; }
    public string CategoryId { get; set; } 
    public decimal MonthlyLimit { get; set; }
}