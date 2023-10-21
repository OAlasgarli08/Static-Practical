using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data
{
    public class AppDbContext
    {

        public Category[] Categories()
        {
            return new Category[]
            {
                new Category{Id = 1, Name = "Phone"},
                new Category{Id = 2, Name = "Television"},
                new Category{Id = 3, Name = "Gaming Console"},
                new Category{Id = 4, Name = "Computer"}
            };
        }

        public Product[] Products()
        {
            return new Product[]
            {
                new Product { Id = 1, Name = "Product 1 Phone", Price = 1500, CreateDate = new DateTime(2000,01,02), Category = Categories()[0] },
                new Product { Id = 2, Name = "Product 2 TV", Price = 6000, CreateDate = new DateTime(2000,11,04), Category = Categories()[1] },
                new Product { Id = 3, Name = "Product 3 Phone", Price = 1700, CreateDate = new DateTime(2020,10,12), Category = Categories()[0] },
                new Product { Id = 3, Name = "Product 3 Gaming Console", Price = 1500, CreateDate = new DateTime(2010,10,11), Category = Categories()[2] },
            };
        }
    }
}
