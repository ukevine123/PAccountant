using Domain.Entities;
namespace Application.Interface
{
    public interface ILiability
    {
       
        List<Liability> GetAllLiabilities();
    }

}