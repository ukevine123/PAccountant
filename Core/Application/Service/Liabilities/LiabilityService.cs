using Domain.Entities;
using Application.Interface;
using Application.DTO;

namespace Application.Service.Liabilities
{
    public class LiabilityService : ILiabilityService
    {
        private readonly ILiability _liabilityRepository;

        public LiabilityService(ILiability liabilityRepository)
        {
            _liabilityRepository = liabilityRepository;
        }

        public async Task<List<Liability>> GetAllLiabilitiesAsync()
        {
            return await Task.Run(() => _liabilityRepository.GetAllLiabilities());
        }

        public async Task<Liability?> GetLiabilityByIdAsync(int id)
        {
            return await Task.Run(() => _liabilityRepository.GetLiabilityById(id));
        }

        public async Task CreateLiabilityAsync(LiabilityCreateDTO liabilityDTO)
        {
            await Task.Run(() => _liabilityRepository.CreateLiability(liabilityDTO));
        }

        public async Task UpdateLiabilityAsync(int id, LiabilityUpdateDTO liabilityDTO)
        {
            await Task.Run(() => _liabilityRepository.UpdateLiability(id, liabilityDTO));
        }

        public async Task<decimal> GetTotalDebtAsync()
        {
            var all = await Task.Run(() => _liabilityRepository.GetAllLiabilities());
            return all.Sum(x => x.Value); // Using .Value based on your Entity
        }
    }
}