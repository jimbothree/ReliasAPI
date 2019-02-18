using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ReliasAPI.Entities;

namespace ReliasAPI.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserEntity>> GetUsers();
        Task<UserEntity> GetUser(int userId);     
    }
}
