using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Services.AccountService
{
    public class AccountService: IAccountService
    {
         private readonly IAccount _account;

        //constructor
        public AccountService(IAccount account)
        {
            _account = account;
        }
        public Account? GetAccountById(int id)
        {
            return _account.GetAccountById(id);
        }
        public List<Account> GetAllAccounts()
        {  
            List<Account> accounts = _account.GetAllAccounts();
            return accounts; 
        }
        public void CreateCustomer(AccountCreateDTOs accountDTO)
        {
            _account.CreateAccount(accountDTO);
        }
        public void UpdateAccount(int id, AccountUpdateDTOs accountDTO)
        {
                _account.UpdateAccount(id, accountDTO);
        }

        public Task<AccountDto> CreateAccountAsync(CreateAccountRequest request)
        {
            // Map request to repository DTO
            var repoDto = new AccountCreateDTOs
            {
                Name = request.Name,
                Number = string.Empty,
                Balance = request.InitialBalance
            };
            _account.CreateAccount(repoDto);

            // Try to retrieve the most recently added account
            var created = _account.GetAllAccounts().OrderByDescending(a => a.Id).FirstOrDefault();
            var dto = new AccountDto();
            if (created != null)
            {
                dto.Id = created.Id;
                dto.Name = created.Name;
                dto.Balance = created.Balance;
            }
            return Task.FromResult(dto);
        }


        List<Account> IAccountService.GetAllAccounts()
        {
            return _account.GetAllAccounts();
        }
    }
}