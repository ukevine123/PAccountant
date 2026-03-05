using Application.DTO;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ILiability
    {
        public List<Liability> GetAllLiabilities();
        void CreateLiability(LiabilityCreateDTO liabilityDTO);

    }

}