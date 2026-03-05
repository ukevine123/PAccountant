using Infrastructure.Data;
using Domain.Entities;
using Application.Interfaces;
using Application.DTO;

namespace Infrastructure.Repositories
{
    public class CurrencyRepository : ICurrency
    {
        private readonly ApplicationDbContext _context;
        public CurrencyRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Currency> GetAllCurrencies()
        {
            List<Currency> currencies = _context.Currencies.ToList();
            return currencies;
        }
        public void CreateCurrency(CurrencyCreateDTO currencyDto)
        {
            Currency currency = new Currency
            {
                Name = currencyDto.Name,
                Symbol = currencyDto.Symbol,
            };
            _context.Currencies.Add(currency);
            _context.SaveChanges();
        }
    }
}