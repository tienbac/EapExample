using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EapExample.Models
{
    public class EapExampleContext : DbContext
    {
        public EapExampleContext (DbContextOptions<EapExampleContext> options)
            : base(options)
        {
        }

        public DbSet<EapExample.Models.Employee> Employee { get; set; }
    }
}
