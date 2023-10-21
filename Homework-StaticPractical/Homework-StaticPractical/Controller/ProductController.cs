using Services.Services;
using Services.Services.Interfaces;


namespace Homework_StaticPractical.Controller
{
    internal class ProductController
    {
        private readonly IProductService _productService;
        public ProductController()
        {
            _productService = new ProductService();
        }

        public void GetCount()
        {
            int count = _productService.GetCount();

            Console.WriteLine(count);
        }

        public void SearchByName()
        {
            Console.WriteLine("Search product");
            string searchText = Console.ReadLine();
            
            var result = _productService.Search(searchText);

            foreach (var item in result)
            {
                string data = $"Name: {item.Name}, Price: {item.Price}, Category: {item.Category.Name}";
                Console.WriteLine(data);
            }
        }

        public void GetAll()
        {
            var result = _productService.GetAll();

            foreach (var item in result)
            {
                string data = $"Name: {item.Name}, Price: {item.Price}, Category: {item.Category.Name}";
                Console.WriteLine(data);
            }
        }

        public void GetAveragePrice()
        {
            var result = _productService.GetAveragePrice();
            Console.WriteLine(result);
        }

        public void OrderByDate()
        {
            var result = _productService.OrderByDate();

            foreach (var item in result)
            {
                string data = $"Name: {item.Name}, Price: {item.Price}, Category: {item.Category.Name}, Date: {item.CreateDate:dd,MM,yyyy}";
                Console.WriteLine(data);
            }
        }

        public void GetAllByCategoryNames()
        {
            Console.WriteLine("Search a Category:");
            string categoryName = Console.ReadLine();
            var result = _productService.GetAllByCategoryNames(categoryName);

            foreach (var item in result)
            {
                string data = $"Name: {item.Name}, Price: {item.Price}, Category: {item.Category.Name}, Date: {item.CreateDate:dd,MM,yyyy}";
                Console.WriteLine(data);
            }
        }

        public void GetAllByCategoryID()
        {
            Console.WriteLine("Search Id of a Category:");
            int categoryId = int.Parse(Console.ReadLine());
            var result = _productService.GetAllByCategoryID(categoryId);

            foreach (var item in result)
            {
                string data = $"Name: {item.Name}, Price: {item.Price}, Category: {item.Category.Name}, Date: {item.CreateDate:dd,MM,yyyy}";
                Console.WriteLine(data);
            }
        }
    }
}
