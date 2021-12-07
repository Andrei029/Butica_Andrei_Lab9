using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Butica_Andrei_Lab8.Models;

namespace Butica_Andrei_Lab8.Data
{
    public class Butica_Andrei_Lab8Context : DbContext
    {
        public Butica_Andrei_Lab8Context (DbContextOptions<Butica_Andrei_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Butica_Andrei_Lab8.Models.Book> Book { get; set; }

        public DbSet<Butica_Andrei_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Butica_Andrei_Lab8.Models.Category> Category { get; set; }
    }
}
