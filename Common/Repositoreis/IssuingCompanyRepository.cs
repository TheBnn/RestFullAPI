using Common.Data;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Services.Interfaces;
using Services.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public class IssuingCompanyRepository : IIssuingCompanyRepository
    {
        private ApplicationContext _context;

        public IssuingCompanyRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<IssuingCompany>> GetAll()
        {
            var query = from ic in _context.IssuingCompanies
                        select new IssuingCompany{
                            Id = ic.Id,
                            Name = ic.Name,
                            Country = ic.Country,
                            Industry = ic.Industry
                        };                  

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<AssetWithIssuerResponse>> GetAssetsByIssuedId(int id)
        {
            var query = from ic in _context.IssuingCompanies
                        join a in _context.Assets on ic.Id equals a.IssuingCompany.Id
                        where ic.Id.Equals(id) && 
                              a.EndDate.HasValue.Equals(false)
                        orderby a.BeginDate
                        select new AssetWithIssuerResponse{
                            ActiveType = a.ActiveType.Name,
                            AssetIsin = a.Isin,
                            AssetName = a.Name,
                            AssetTicket = a.Ticket,
                            Country = ic.Country.Name,
                            CurrencyType = a.CurrencyType.Name,
                            Industry = ic.Industry.Name,
                            Issuer = ic.Name
                        };

            return await query.ToListAsync();
        }
    }
}