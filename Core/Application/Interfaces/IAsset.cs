using Domain.Entities;
using Application.DTO;

namespace Application.Interfaces
{
    public interface IAsset
    {
        public List<Asset> GetAllAssets();
        void CreateAsset(AssetCreateDTO assetDTO);
    }
}