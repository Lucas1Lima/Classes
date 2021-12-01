using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DATA
{
    public class TClasseContext : DbContext
    {

            public TClasseContext(DbContextOptions<TClasseContext> options) : base(options)
            { }

            public DbSet<TClasse> TClasses { get; set; }
            public DbSet<TClasseLog> TClasseLogs { get; set; }

    }
}
