
using Application.DTO;
using Domain.Entities;
namespace Application.Service.Liabilities
{
    public interface ILiabilityService
    {
       
        List<Liability> GetAllLiabilities();
        public Liability GetLiabilityById(int id);
        void CreateLiability(LiabilityCreateDTO liabilityDTO);
        void UpdateLiability(int id, LiabilityUpdateDTO liabilityDTO);
    }

}