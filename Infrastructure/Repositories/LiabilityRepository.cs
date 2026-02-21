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
    }
}