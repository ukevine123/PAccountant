using Domain.Entities;
using Application.Interface;
using Application.DTO;

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
         public Liability GetLiabilityById(int id)
        {
            return _liability.GetLiabilityById(id); 
        }  
          public void CreateLiability(LiabilityCreateDTO liabilityDTO)
        {
            _liability.CreateLiability(liabilityDTO);
        }   
        public void UpdateLiability(int id, LiabilityUpdateDTO liabilityDTO)
        {
            _liability.UpdateLiability(id,liabilityDTO);
    }   
    }
}
