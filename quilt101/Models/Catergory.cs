using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quilt101.Model
{
    public class Catergory
    {
        public int CategoryId { get; set; }
        public string CaegoryName { get; set; }
        public string Desription { get; set; }
        public List<Quilt> Quilts { get; set; }
    }
}
