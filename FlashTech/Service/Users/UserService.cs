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

        public async Task CreateUserAsync(Users user)
        {
            _context.users.Add(user);
            await  _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(int id)
        {
           var user = await _context.users.FindAsync(id);
           if (user != null){
                _context.users.Remove(user);
                await _context.SaveChangesAsync();
           } 
        }

        public async Task<List<Users>> GetAllUsersAsync()
        {
             return await _context.users.ToListAsync();
        }

        public Task<Users?> GetUserByIdAsync(int id)
        {
            return _context.users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public Task UpdateUserAsync(Users user)
        {
            _context.users.Update(user);
            return _context.SaveChangesAsync();
        }
    }
}