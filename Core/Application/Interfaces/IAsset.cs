using Domain.Entities;
using Application.DTO;

namespace Application.Interfaces
{
    public interface IAsset
    {
        public List<Asset> GetAllAssets();
        void CreateAsset(AssetCreateDTO assetDTO);
        public Asset GetAssetById(int id);
        void UpdateAsset(int id, AssetUpdateDTO assetDTO);
    }
}