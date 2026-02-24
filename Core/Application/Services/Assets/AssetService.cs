using Domain.Entities;
using Application.DTO;
using System.Security.Cryptography.X509Certificates;
using Application.Interfaces;
namespace Application.Services.Assets
{
    public class AssetService : IAssetService
    {
        private readonly IAsset _asset;

        //constructor

        public AssetService(IAsset asset)
        {
            _asset = asset;
        }
       public List<Asset> GetAllAssets()
       {
          List<Asset> _assets = _asset.GetAllAssets();
          return _assets;
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