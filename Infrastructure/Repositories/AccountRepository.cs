using System;
using System.Collections.Generic;
using System.Linq;
using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class AccountRepository : IAccount
    {
        private readonly ApplicationDbContext _dbContext;
        public AccountRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }
        //Retrieving Accounts
      public List<Account> GetAllAccounts()
        {
            List<Account> accounts = _dbContext.Accounts.ToList();
            return accounts;
        }
         public Account? GetAccountById(int id)
         {
             return _dbContext.Accounts.FirstOrDefault(c => c.Id == id);
         }
        public void CreateAccount( AccountCreateDTOs accountDTO)
        {
            Account account = new()
            {
                Name = accountDTO.Name,
                Balance = accountDTO.Balance,
                CreatedAt = DateTime.Now,
                CreatedById = 1
            };
            _dbContext.Accounts.Add(account);
            _dbContext.SaveChanges();
        }
        public void UpdateAccount(int id, AccountUpdateDTOs accountDTO)
        {
            var account = _dbContext.Accounts.Find(id);
            if (account == null) return;
            {
                account.Name = accountDTO.Name;
                account.Balance = accountDTO.Balance;
                _dbContext.SaveChanges();
            }
        }
    }
}  