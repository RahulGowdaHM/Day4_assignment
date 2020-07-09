using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day4_assignment.Entities
{
    public class CustomerContext:DbContext
    {
        public DbSet<Customer> customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-ORQF3GD2;User ID=sa;Password=12345");
        }
    }
}
