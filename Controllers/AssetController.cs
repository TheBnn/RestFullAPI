using Entites.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestFullAPI.Controllers
{
    /// <summary>
    /// Контроллер активов
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AssetsController : Controller
    {
        private IAssetRepository _repository;

        public AssetsController(IAssetRepository repository) => _repository = repository;

        [HttpGet]
        [Route("[action]/{id:int}")]
        public async Task<Asset> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<Asset> GetByIsinCode([FromQuery(Name = "isin")] string isin)
        {
            return await _repository.GetByIsinCode(isin);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IEnumerable<AssetResponse>> Search([FromQuery(Name = "code")] string code, [FromQuery(Name = "activeType")] int? activeType)
        {
            return await _repository.Search(code, activeType);
        }
    }
}
