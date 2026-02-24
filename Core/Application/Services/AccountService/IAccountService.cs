using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Services.AccountService
{
    public interface IAccountService
    {
    Task<AccountDto> CreateAccountAsync (CreateAccountRequest request);
    Account? GetAccountById(int Id);
    List<Account> GetAllAccounts();
    void UpdateAccount(int Id, AccountUpdateDTOs accountDto);

    }
}

