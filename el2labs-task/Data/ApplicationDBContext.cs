using el2labs.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace el2labs.Data
{
    public class ApplicationDBContext:DbContext
{
    public ApplicationDBContext(DbContextOptions options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
    public DbSet<Product> Products { get; set; }
}
}
