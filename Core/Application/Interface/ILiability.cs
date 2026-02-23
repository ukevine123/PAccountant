using Domain.Entities;
namespace Application.Interface
{
    public interface ILiability
    {
       
        List<Liability> GetAllLiabilities();
        public Liability GetLiabilityById(int id);
    }

}