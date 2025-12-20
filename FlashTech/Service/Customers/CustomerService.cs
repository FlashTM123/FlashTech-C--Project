using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlashTech.Models;
using FlashTech.Service;
using FlashTech.Data;
using Microsoft.EntityFrameworkCore;

namespace FlashTech.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly AppDBContent _context;
        public CustomerService(AppDBContent context)
        {
            _context = context;
        }
        public Task CreateCustomerAsync(Customers customer)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCustomerAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customers>> GetAllCustomersAsync()
        {
            return _context.customers.ToListAsync();
        }

        public Task<Customers?> GetCustomerByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCustomerAsync(Customers customer)
        {
            throw new NotImplementedException();
        }
    }
}