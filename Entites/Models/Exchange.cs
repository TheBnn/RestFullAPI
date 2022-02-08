using System.Collections.Generic;

namespace Entites.Models
{
    public class Exchange
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public List<Asset> Assets { get; set; }
    }
}