using Microsoft.EntityFrameworkCore;
using quilt101.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quilt101.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Catergory> Categories { get; set; }

        public DbSet<Quilt> Quilts {get; set;}
    }

}
