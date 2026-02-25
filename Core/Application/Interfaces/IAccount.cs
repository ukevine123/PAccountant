
using Domain.Entities;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface IAccount
    {
        public List<Account> GetAllAccounts ();
        public Account? GetAccountById(string id);
        void CreateAccount(AccountCreateDTOs accountDto);
        void UpdateAccount(string id, AccountUpdateDTOs accountDto);
    }
}