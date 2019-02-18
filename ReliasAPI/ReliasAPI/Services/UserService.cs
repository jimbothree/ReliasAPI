using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ReliasAPI.Services.Interfaces;
using ReliasAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace ReliasAPI.Services
{
    public class UserService : IUserService
    {
        private readonly UserContext _userContext;
        public UserService(UserContext userContext)
        {
            _userContext = userContext;
        }

        public Task<UserEntity> GetUser(int userId)
        {
            return _userContext.Users.FindAsync(userId);
        }

        public Task<List<UserEntity>> GetUsers()
        {
            return _userContext.Users.ToListAsync();
        }
    }
}
