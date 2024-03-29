using System.Collections.Generic;

namespace Entites.Models
{
    public class IssuingCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public int IndustryId { get; set; }
        public Industry Industry { get; set; }

        public List<Asset> Assets { get; set; }
    }
}