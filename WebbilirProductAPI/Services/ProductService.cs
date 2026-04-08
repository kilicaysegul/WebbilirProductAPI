using WebbilirProductAPI.Models;
using WebbilirProductAPI.Interfaces;
using WebbilirProductAPI.Dbcontext;
using Microsoft.EntityFrameworkCore;

namespace WebbilirProductAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Product?> GetProductByIdAsync(string id)
        {
            
            return await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}