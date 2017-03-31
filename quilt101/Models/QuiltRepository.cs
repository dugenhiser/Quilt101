using Microsoft.EntityFrameworkCore;
using quilt101.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quilt101.Models
{
    public class QuiltRepository : IQuiltRepository
    {
        private readonly AppDbContext _appDbContext;

        public QuiltRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Quilt> Quilts
        {
            get
            {
                return _appDbContext.Quilts.Include(c => c.Category);
            }
        }

        public Quilt GetQuiltById(int quiltId)
        {
            return _appDbContext.Quilts.FirstOrDefault(q => q.QuiltId == quiltId);
        }

    }
}
