using Domain.Entities;
using Application.DTO;
using System.Security.Cryptography.X509Certificates;
using Application.Interfaces;
namespace Application.Services.Accounts
{
    public class AccountService : IAccountService
    {
        private readonly IAccount _account;

        //constructor

        public AccountService(IAccount account)
        {
            _account = account;
        }
       public List<Account> GetAllAccounts()
       {
          List<Account> _accounts = _account.GetAllAccounts();
          return _accounts;
       }

        public void CreateAccount(AccountCreateDTO accountDTO)
        {
            _account.CreateAccount(accountDTO);
        }
    }
}