
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IAccount
    {
        public List<Account> GetAllAccounts ();
        public Account? GetAccountById(int id);
        void CreateAccount(AccountCreateDTOs accountDto);
        void UpdateAccount(int id, AccountUpdateDTOs accountDto);
    }

    public class AccountUpdateDTOs
    {
        public string Name { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public decimal Balance { get; set; }
    }

    public class AccountCreateDTOs
    {
        public string Name { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public decimal Balance { get; set; }
    }
}