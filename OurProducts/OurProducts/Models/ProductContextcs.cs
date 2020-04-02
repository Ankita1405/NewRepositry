using Microsoft.EntityFrameworkCore;


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

