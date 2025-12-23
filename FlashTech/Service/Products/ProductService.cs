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
            _context.products.Add(product);
            return _context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = _context.products.FirstOrDefault(p => p.id == id);
            if (product != null)
            {
                _context.products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Models.Products>> GetAllProductsAsync()
        {
            return await _context.products.Include(product => product.brands).ToListAsync();
        }

        public async Task<Models.Products?> GetProductByIdAsync(int id)
        {
            return await _context.products.Include(product => product.brands).FirstOrDefaultAsync(product => product.id == id);
        }

        public Task UpdateProductAsync(Models.Products product)
        {
            _context.products.Update(product);
            return _context.SaveChangesAsync();
        }
    }
}