using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlashTech.Models;
using FlashTech.Data;

namespace FlashTech.Service.Products
{
    public interface IProductService
    {
        Task<List<Models.Products>> GetAllProductsAsync();
        Task<Models.Products?> GetProductByIdAsync(int id);
        Task CreateProductAsync(Models.Products product);
        Task UpdateProductAsync(Models.Products product);
        Task DeleteProductAsync(int id);
        
    }
}