using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlashTech.Models;
namespace FlashTech.Service
{
    public interface IUserService
    {
        Task<List<Users>> GetAllUsersAsync();
        Task<Users> GetUserByIdAsync(int id);
        Task CreateUserAsync(Users user);
        Task UpdateUserAsync(Users user);

        Task DeleteUserAsync(int id);
    }
}