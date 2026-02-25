using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using System.Linq;

namespace Application.Services.AccountService
{
    public class AccountService : IAccountService
    {
        private readonly IAccount _account;

        public AccountService(IAccount account)
        {
            _account = account;
        }

        // 1. Math Helper for the Dashboard
        public async Task<decimal> GetTotalBalanceAsync()
        {
            return await Task.Run(() => 
                _account.GetAllAccounts().Sum(a => a.Balance));
        }

        // 2. Fix for CS0535: GetAccountByIdAsync
        public async Task<Account?> GetAccountByIdAsync(string id)
        {
            return await Task.Run(() => _account.GetAccountById(id));
        }

        // 3. Fix for CS0535: GetAllAccountsAsync
        public async Task<List<Account>> GetAllAccountsAsync()
        {
            return await Task.Run(() => _account.GetAllAccounts());
        }

        // 4. Fix for CS0738: CreateAccountAsync
        // Changed return type from Task<AccountDto> to Task to match interface
        public async Task CreateAccountAsync(CreateAccountRequest request)
        {
            var repoDto = new AccountCreateDTOs
            {
                Name = request.Name,
                Number = string.Empty,
                Balance = request.InitialBalance
            };
            
            await Task.Run(() => _account.CreateAccount(repoDto));
        }

        // 5. Fix for CS0535: UpdateAccountAsync
        public async Task UpdateAccountAsync(string id, AccountUpdateDTOs accountDTO)
        {
            await Task.Run(() => _account.UpdateAccount(id, accountDTO));
        }

        // Removed the explicit implementation that was causing CS0539 
        // because GetAllAccounts() is no longer in the interface.
    }
}