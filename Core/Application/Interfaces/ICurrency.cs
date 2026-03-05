using Domain.Entities;
using Application.DTO;

namespace Application.Interfaces
{
    public interface ICurrency
    {
        public List<Currency> GetAllCurrencies();
        
        void CreateCurrency(CurrencyCreateDTO currencyDTO);
    }
}