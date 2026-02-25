
using Application.DTO;
using Domain.Entities;

namespace Application.Interface
{
    public interface ILiabilityService
    {
       Task<List<Liability>> GetAllLiabilitiesAsync();
        Task<Liability?> GetLiabilityByIdAsync(int id);
        Task CreateLiabilityAsync(LiabilityCreateDTO liabilityDTO);
        Task UpdateLiabilityAsync(int id, LiabilityUpdateDTO liabilityDTO);
        Task<decimal> GetTotalDebtAsync();
    }
}