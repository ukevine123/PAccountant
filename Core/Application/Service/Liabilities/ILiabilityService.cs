
using Domain.Entities;
namespace Application.Service.Liabilities
{
    public interface ILiabilityService
    {
       
        List<Liability> GetAllLiabilities();
    }

}