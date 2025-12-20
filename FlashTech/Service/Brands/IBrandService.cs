using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlashTech.Models;
namespace FlashTech.Service
{
    public interface IBrandService
    {
        Task<List<FlashTech.Models.Brands>> GetAllBrandsAsync();
        Task<FlashTech.Models.Brands?> GetBrandByIdAsync(int id);
        Task CreateBrandAsync(FlashTech.Models.Brands brand);
        Task UpdateBrandAsync(FlashTech.Models.Brands brand);
        Task DeleteBrandAsync(int id);
    }
}