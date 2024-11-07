using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bg_lib.Models;

namespace bg_lib.Data
{
    public class bg_libContext : DbContext
    {
        public bg_libContext (DbContextOptions<bg_libContext> options)
            : base(options)
        {
        }

        public DbSet<bg_lib.Models.Game> Game { get; set; } = default!;
    }
}
