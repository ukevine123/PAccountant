using Domain.Entities;
using Application.DTO;
using System.Security.Cryptography.X509Certificates;
using Application.Interfaces;
namespace Application.Services.Currencies
{
    public class CurrencyService : ICurrencyService
    {
        private readonly ICurrency _currency;

        //constructor

        public CurrencyService(ICurrency currency)
        {
            _currency = currency;
        }
       public List<Currency> GetAllCurrencies()
       {
          List<Currency> _currencies = _currency.GetAllCurrencies();
          return _currencies;
       }

        public void CreateCurrency(CurrencyCreateDTO currencyDTO)
        {
            _currency.CreateCurrency(currencyDTO);
        }
    }
}