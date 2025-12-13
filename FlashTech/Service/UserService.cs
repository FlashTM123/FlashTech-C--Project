using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlashTech.Data;
using FlashTech.Models;
using Microsoft.EntityFrameworkCore;

namespace FlashTech.Service
{
    public class UserService : IUserService
    {
        private readonly AppDBContent _context;
        public UserService(AppDBContent context)
        {
            _context = context;
        }
        public async Task<List<Users>> GetAllUsersAsync()
        {
            return await _context.users.ToListAsync();
        }
     
        public Task<Users> CreateUserAsync(Users user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAsync(int id)
        {
            throw new NotImplementedException();
        }


        public Task<Users> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Users> UpdateUserAsync(Users user)
        {
            throw new NotImplementedException();
        }
    }
}