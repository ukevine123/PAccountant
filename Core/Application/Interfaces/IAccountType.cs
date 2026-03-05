using Domain.Entities;
using Application.DTO;

namespace Application.Interfaces
{
    public interface IAccountType
    {
        public List<AccountType> GetAllAccountTypes();
        void CreateAccountType(AccountTypeDTO accountTypeDTO);

    }

}