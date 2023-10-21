using Services.Services;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_StaticPractical.Controller
{
    internal class CategoryController
    {
        private readonly ICategoryService _categoryService;
        public CategoryController()
        {
            _categoryService = new CategoryService();
        }

        public void GetAll()
        {
            var result = _categoryService.GetAll();
            foreach (var item in result)
            {
                string data = $"Name: {item.Name}";
                Console.WriteLine(data);
            }            
        }
    }
}
