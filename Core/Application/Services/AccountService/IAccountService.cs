using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Services.AccountService
{
    public interface IAccountService
    {
   Task<List<Account>> GetAllAccountsAsync();
        Task<Account?> GetAccountByIdAsync(string id);
        Task CreateAccountAsync(CreateAccountRequest request);
        Task UpdateAccountAsync(string id, AccountUpdateDTOs accountDTO);
        Task<decimal> GetTotalBalanceAsync(); // For the "Cash & Bank" total

    }
}

