using Application.DTO;
using Domain.Entities;
namespace Application.Interface
{
    public interface ILiability
    {
       
        List<Liability> GetAllLiabilities();
        public Liability GetLiabilityById(int id);
        void CreateLiability(LiabilityCreateDTO liabilityDTO);
       
        void UpdateLiability(int id, LiabilityUpdateDTO liabilityDTO);
    }

}