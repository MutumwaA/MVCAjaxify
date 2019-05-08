using Microsoft.EntityFrameworkCore;
using MVCAjaxify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAjaxify.Data
{
    public class MVCAjaxifyDbContext : DbContext
    {
        public MVCAjaxifyDbContext(DbContextOptions options) : base(options)
        {
        }
       public DbSet<Customer> Customer { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
}
