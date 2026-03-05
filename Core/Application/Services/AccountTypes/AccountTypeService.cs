using Domain.Entities;
using Application.DTO;
using System.Security.Cryptography.X509Certificates;
using Application.Interfaces;
namespace Application.Services.Assets
{
    public class AccountTypeService : IAccountTypeService
    {
        private readonly IAccountType _accountType;

        //constructor

        public AccountTypeService(IAccountType accountType)
        {
            _accountType = accountType;
        }
       public List<AccountType> GetAllAccountTypes()
       {
          List<AccountType> _accountTypes = _accountType.GetAllAccountTypes();
          return _accountTypes;
       }

        public void CreateAccountType(AccountTypeDTO accountTypeDTO)
        {
            _accountType.CreateAccountType(accountTypeDTO);
        }
    }
}