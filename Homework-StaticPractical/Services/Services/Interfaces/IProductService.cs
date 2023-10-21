using Domain.Models;

namespace Services.Services.Interfaces
{
    public interface IProductService
    {
        int GetCount();
        Product[] Search(string searchText);
        Product[] GetAll();
        decimal GetAveragePrice();
        Product[] OrderByDate();
        Product[] GetAllByCategoryNames(string categoryName);
        Product[] GetAllByCategoryID(int categoryID);

    }
}
