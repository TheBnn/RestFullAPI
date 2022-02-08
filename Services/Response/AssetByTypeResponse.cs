using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Response
{
    public class AssetByTypeResponse
    {
        public int ActiveType { get; set; }
        public IEnumerable<AssetResponse> Assets { get; set; }
    }
}
