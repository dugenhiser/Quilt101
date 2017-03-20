using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quilt101.Model
{
    public interface IQuiltRepository
    {
        IEnumerable<Quilt> Quilts { get; }

        Quilt GetQuiltById(int quiltId);
    }
}
