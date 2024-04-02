using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticeProj.Models;

namespace PracticeProj.Data
{
    public class MyDataContext : DbContext
    {
        public MyDataContext (DbContextOptions<MyDataContext> options)
            : base(options)
        {
        }

        public DbSet<PracticeProj.Models.Expenses> Expenses { get; set; } = default!;
        
    }
}
