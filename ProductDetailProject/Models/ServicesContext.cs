using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductDetailProject.Models
{
    public class ServicesContext:DbContext
    {
        public DbSet<CategoryTable> CategoryTable { get; set; }
        public DbSet<ProductTable> ProductTable { get; set; }
    }
}