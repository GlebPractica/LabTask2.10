using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task1.Models;

namespace Task1.Data
{
    public class Task1Context : DbContext
    {
        public Task1Context (DbContextOptions<Task1Context> options)
            : base(options)
        {
        }

        public DbSet<Task1.Models.Movie> Movie { get; set; } = default!;
    }
}
