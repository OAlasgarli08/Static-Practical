using Domain.Data;
using Domain.Models;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;
        public ProductService()
        {
            _context = new AppDbContext();
        }

        public Product[] GetAll()
        {
            return _context.Products();
        }

        public int GetCount()
        {
            var products = _context.Products();
            return products.Length;
        }

        public Product[] Search(string searchText)
        {
            return _context.Products().Where(m => m.Name.Trim().ToLower().Contains(searchText.Trim().ToLower())).ToArray();
        }

        public decimal GetAveragePrice()
        {
            var products = _context.Products();
            int producCount = products.Length;
            decimal sumOfPrice = products.Sum(m => m.Price);
            return sumOfPrice / producCount;
        }

        public Product[] OrderByDate()
        {
            return _context.Products().OrderByDescending(m => m.CreateDate).ToArray();
        }

        public Product[] GetAllByCategoryNames(string categoryName)
        {
            return _context.Products().Where(m => m.Category.Name == categoryName).ToArray();
        }

        public Product[] GetAllByCategoryID(int categoryID)
        {
            return _context.Products().Where(m => m.Category.Id == categoryID).ToArray();
        }
    }
}
