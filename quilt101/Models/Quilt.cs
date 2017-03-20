using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quilt101.Model
{
    public class Quilt
    {
        public int QuiltId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription{ get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbNailUrl { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public virtual Catergory Catergory { get; set; }
    }
}
