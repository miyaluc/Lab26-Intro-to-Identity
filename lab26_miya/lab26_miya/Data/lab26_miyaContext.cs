using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab26_miya.Models
{
    public class lab26_miyaContext : DbContext
    {
        public lab26_miyaContext (DbContextOptions<lab26_miyaContext> options)
            : base(options)
        {
        }

        public DbSet<lab26_miya.Models.CPS> CPS { get; set; }
    }
}
