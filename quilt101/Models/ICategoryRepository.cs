using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quilt101.Model
{
    public interface ICategoryRepository
    {
        IEnumerable<Catergory> Categories { get; }
    }
}
