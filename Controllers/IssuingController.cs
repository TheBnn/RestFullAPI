using Entites.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestFullAPI.Controllers
{
    /// <summary>
    /// Контроллер эмитентов
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class IssuingCompaniesController : Controller
    {
        private IIssuingCompanyRepository _repository;

        public IssuingCompaniesController(IIssuingCompanyRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IEnumerable<IssuingCompany>> GetAll()
        {
            return await _repository.GetAll();
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IEnumerable<AssetWithIssuerResponse>> GetAssetsByIssuingId(int id)
        {
            return await _repository.GetAssetsByIssuedId(id);
        }
    }
}
