using Domain.Entities;
namespace Application.DTO
{
    public class AccountCreateDTO
    {
    public string Name { get; set; } 
    public string AccountNumber { get; set; }
    public AccountType AccountType { get; set; }
    public int AccountTypeId { get; set; }
    public Currency Currency { get; set; }
    public int CurrencyId { get; set; }
    public decimal InitialBalance { get; set; }
    public decimal CurrentBalance { get; set; } 
    }

    public class AccountTypeDTO
    {
        public string Name { get; set; }
    }
}