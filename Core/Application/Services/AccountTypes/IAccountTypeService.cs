using Domain.Entities;
using Application.DTO;

namespace Application.Interfaces
{
    public interface IAccountTypeService
    {
        public List<AccountType> GetAllAccountTypes();
        void CreateAccountType(AccountTypeDTO accountTypeDTO);

    }

}