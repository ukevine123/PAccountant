using Application.DTO;
using Domain.Entities;
using Infrastructure.Data;
using Application.Interfaces;

namespace Infrastructure.Repositories
{
    public class AssetRepository : IAsset
    {
        private readonly ApplicationDbContext _dbContext;

        public AssetRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }
        // Retrieving assets

        public List<Asset> GetAllAssets()
        {
            List<Asset> _assets = _dbContext.Assets.ToList();
            return _assets;
        }  

        public void CreateAsset(AssetCreateDTO assetDTO)
        {
            Asset asset = new Asset
            {
                Name = assetDTO.Name,
                Type = assetDTO.Type,
                Value = assetDTO.Value,
            };
            _dbContext.Assets.Add(asset);
            _dbContext.SaveChanges();
        }
    }
}