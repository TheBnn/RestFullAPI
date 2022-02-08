using Entites.Models;
using Services.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IAssetRepository
    {
        Task<Asset> GetById(int id);
        Task<Asset> GetByIsinCode(string isin);
        Task<IEnumerable<AssetResponse>> Search(string code, int? activeType);
    }
}