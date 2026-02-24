using Application.DTO;
using Application.Interface;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class LiabilityRepository:ILiability
    {
        // construct Application DbContext
        private readonly ApplicationDbContext _dbcontext;
        public LiabilityRepository (ApplicationDbContext context)
        {
            _dbcontext = context;
        }
        // Retriving customer
        public List<Liability> GetAllLiabilities()
        {
             List<Liability> _liabilities = _dbcontext.Liabilities.ToList();
            return _liabilities;
        }
          public Liability GetLiabilityById(int id)
        {

            return _dbcontext.Liabilities.FirstOrDefault(c => c.Id == id);

        }
         public void CreateLiability(LiabilityCreateDTO liabilityDTO)
        {
            Liability liability = new Liability
            {
                Name = liabilityDTO.Name,
                Type = liabilityDTO.Type,
                Value = liabilityDTO.Value,
               
                
                
            };
            _dbcontext.Liabilities.Add(liability);
            _dbcontext.SaveChanges();
        }
        public void UpdateLiability(int id, LiabilityUpdateDTO liabilityDTO)
        {
            var liability = _dbcontext.Liabilities.Find(id);
            if (liability==null)return;

            liability.Name = liabilityDTO.Name;
            liability.Type = liabilityDTO.Type;
            liability.Value = liabilityDTO.Value;
            _dbcontext.SaveChanges();
        }

        
    }
}