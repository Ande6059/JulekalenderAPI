using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JulekalenderAPI.Models
{
    public class LågeContext : DbContext
    {
        public LågeContext(DbContextOptions<LågeContext> options)
            : base(options)
        {

        }
        public DbSet<Låge> Låger { get; set; }
    }
}
