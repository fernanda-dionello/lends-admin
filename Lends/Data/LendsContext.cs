using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lends.Models;

namespace Lends.Data
{
    public class LendsContext : DbContext
    {
        public LendsContext (DbContextOptions<LendsContext> options)
            : base(options)
        {
        }

        public DbSet<Lends.Models.Address> Address { get; set; }

        public DbSet<Lends.Models.Producer> Producer { get; set; }

        public DbSet<Lends.Models.Client> Client { get; set; }

        public DbSet<Lends.Models.Game> Game { get; set; }

        public DbSet<Lends.Models.Rent> Rent { get; set; }
    }
}
