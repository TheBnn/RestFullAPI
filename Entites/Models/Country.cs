using System.Collections.Generic;

namespace Entites.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public List<IssuingCompany> IssuingCompanies { get; set; }
    }
}