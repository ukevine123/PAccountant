using Domain.Entities;
using Application.DTO;

namespace Application.Interfaces
{
    public interface IAssetService
    {
        Task<List<Asset>> GetAllAssetsAsync();
        void CreateAsset(AssetCreateDTO assetDTO);
        public Asset GetAssetById(int id);
        void UpdateAsset(int id, AssetUpdateDTO assetDTO);
        Task<decimal> GetTotalValueAsync(); // Sum of all asset values
    }
}