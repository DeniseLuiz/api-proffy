using Microsoft.EntityFrameworkCore;
using ProffyApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProffyApi.Context
{
    public class ProffyContext : DbContext
    {
        public ProffyContext(DbContextOptions<ProffyContext> options) : base(options)
        {
                
        }
        public DbSet<Proffy> Proffys { get; set; }
    }

}
