using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lup_Mara_Lab2.Models;

namespace Lup_Mara_Lab2.Data
{
    public class Lup_Mara_Lab2Context : DbContext
    {
        public Lup_Mara_Lab2Context (DbContextOptions<Lup_Mara_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Lup_Mara_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Lup_Mara_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
