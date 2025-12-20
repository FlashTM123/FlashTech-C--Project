using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlashTech.Models;
namespace FlashTech.Service
{
    public interface ICustomerService
    {
        Task<List<Customers>> GetAllCustomersAsync();
        Task<Customers?> GetCustomerByIdAsync(int id);
        Task CreateCustomerAsync(Customers customer);
        Task UpdateCustomerAsync(Customers customer);
        Task DeleteCustomerAsync(int id);
    }
}