using WebbilirProductAPI.Models;

namespace WebbilirProductAPI.Interfaces
{
    public interface IProductService
    {
        Task<Product?> GetProductByIdAsync(string id);
    }
}