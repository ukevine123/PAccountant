using Domain.Entities;
using Application.DTO;

namespace Application.Interfaces
{
    public interface IAssetService
    {
        public List<Asset> GetAllAssets();
        void CreateAsset(AssetCreateDTO assetDTO);
    }
}