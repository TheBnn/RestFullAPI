using Entites.Models;
using Services.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IIssuingCompanyRepository
    {
        Task<IEnumerable<IssuingCompany>> GetAll();
        Task<IEnumerable<AssetWithIssuerResponse>> GetAssetsByIssuedId(int id);
    }
}