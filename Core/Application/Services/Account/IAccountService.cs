using Domain.Entities;
using Application.DTO;

namespace Application.Interfaces
{
    public interface IAccountService
    {
        public List<Account> GetAllAccounts();
        void CreateAccount(AccountCreateDTO accountDTO);

    }

}