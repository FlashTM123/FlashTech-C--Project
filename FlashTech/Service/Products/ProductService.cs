using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlashTech.Models;
using FlashTech.Data;
using Microsoft.EntityFrameworkCore;

namespace FlashTech.Service.Products
{
    public class ProductService : IProductService
    {
        private readonly AppDBContent _context;
        public ProductService(AppDBContent context)
        {
            _context = context;
        }
        public Task CreateProductAsync(Models.Products product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Models.Products>> GetAllProductsAsync()
        {
            return await _context.products.Include(product => product.brandId).ToListAsync();
        }

        public Task<Models.Products?> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(Models.Products product)
        {
            throw new NotImplementedException();
        }
    }
}