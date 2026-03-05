using Infrastructure.Data;
using Domain.Entities;
using Application.Interfaces;
using Application.DTO;

namespace Infrastructure.Repositories
{
    public class AccountTypeRepository : IAccountType
    {
        private readonly ApplicationDbContext _context;
        public AccountTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<AccountType> GetAllAccountTypes()
        {
            List<AccountType> accountTypes = _context.AccountTypes.ToList();
            return accountTypes;
        }
        public void CreateAccountType(AccountTypeDTO accountTypeDto)
        {
            AccountType accountType = new AccountType
            {
                Name = accountTypeDto.Name,
            };
            _context.AccountTypes.Add(accountType);
            _context.SaveChanges();
        }
        
    }
}