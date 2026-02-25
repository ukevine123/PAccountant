using Domain.Entities;
using Application.DTO;
using Application.Interfaces;
using System.Linq;

namespace Application.Services.Assets
{
    public class AssetService : IAssetService
    {
        private readonly IAsset _asset;

        public AssetService(IAsset asset)
        {
            _asset = asset;
        }

        // --- MATH HELPER FOR DASHBOARD ---
        public async Task<decimal> GetTotalValueAsync()
        {
            // Sums the 'Value' property across all assets
            return await Task.Run(() => 
                _asset.GetAllAssets().Sum(a => a.Value)); 
        }

        // Fixed to match the interface name and return type
        public async Task<List<Asset>> GetAllAssetsAsync()
        {
            return await Task.Run(() => _asset.GetAllAssets());
        }

        public void CreateAsset(AssetCreateDTO assetDTO)
        {
            _asset.CreateAsset(assetDTO);
        }

        public Asset GetAssetById(int id)
        {
            return _asset.GetAssetById(id);
        }

        public void UpdateAsset(int id, AssetUpdateDTO assetDTO)
        {
            _asset.UpdateAsset(id, assetDTO);
        }
    }
}