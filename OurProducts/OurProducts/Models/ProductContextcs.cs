using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OurProducts.Models
{
    public class ProductContext:DbContext
    {
     
            public ProductContext(DbContextOptions options) : base(options)
            {
            }
            public DbSet<Products> Products { get; set; }
    

        }
    }

