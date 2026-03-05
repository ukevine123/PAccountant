using Domain.Entities;
using Application.DTO;
using Application.Interfaces;
using Application.Services;

namespace Application.Service.Liabilities
{
    public class LiabilityService : ILiabilityService
    {
          private readonly ILiability _liability;
        // Constructor 
        public LiabilityService(ILiability liability)
        {
            _liability = liability;
        }
          public List<Liability> GetAllLiabilities()
        {
            List<Liability> liabilities = _liability.GetAllLiabilities();
            return liabilities;
        } 
        public void CreateLiability(LiabilityCreateDTO liabilityDTO)
        {
            _liability.CreateLiability(liabilityDTO);
        }
    }
}
