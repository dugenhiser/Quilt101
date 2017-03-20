using quilt101.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quilt101.ViewModels
{
    public class QuilstListViewModel
    {
        public IEnumerable<Quilt> Quilts { get; set; }

        public string CurrentCategory { get; set; }
    }
}
