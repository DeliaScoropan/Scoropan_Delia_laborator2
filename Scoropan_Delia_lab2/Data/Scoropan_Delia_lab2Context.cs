using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Scoropan_Delia_lab2.Models;

namespace Scoropan_Delia_lab2.Data
{
    public class Scoropan_Delia_lab2Context : DbContext
    {
        public Scoropan_Delia_lab2Context (DbContextOptions<Scoropan_Delia_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Scoropan_Delia_lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Scoropan_Delia_lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Scoropan_Delia_lab2.Models.Author> Author { get; set; }

        public DbSet<Scoropan_Delia_lab2.Models.Category> Category { get; set; }
    }
}
