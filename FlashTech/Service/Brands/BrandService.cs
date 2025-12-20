using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlashTech.Data;
using FlashTech.Models;
using FlashTech.Service;
using Microsoft.EntityFrameworkCore;

namespace FlashTech.Service.Brands
{
    public class BrandService : IBrandService
    {
        private readonly AppDBContent _context;
        public BrandService(AppDBContent context)
        {
            _context = context;
        }
        public Task CreateBrandAsync(Models.Brands brand)
        {
            _context.brands.Add(brand);
            return _context.SaveChangesAsync();
        }

        public async Task DeleteBrandAsync(int id)
        {
               var brand = await _context.brands.FindAsync(id);
           if (brand != null){
                _context.brands.Remove(brand);
                await _context.SaveChangesAsync();
           } 
        }

        public Task<List<Models.Brands>> GetAllBrandsAsync()
        {
            return _context.brands.ToListAsync();
        }

        public Task<Models.Brands?> GetBrandByIdAsync(int id)
        {
            return _context.brands.FirstOrDefaultAsync(b => b.Id == id);
        }

        public Task UpdateBrandAsync(Models.Brands brand)
        {
            _context.brands.Update(brand);
            return _context.SaveChangesAsync();
        }
    }

   
}