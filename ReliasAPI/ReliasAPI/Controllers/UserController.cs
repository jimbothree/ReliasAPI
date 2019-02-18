using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using ReliasAPI.Services.Interfaces;
using ReliasAPI.Entities;

namespace ReliasAPI.Controllers
{
    [Route("v1/users")]
    public class UserController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public Task<UserEntity> GetUserById(int id)
        {
            return _userService.GetUser(id);
        }

        [HttpGet]
        public Task<List<UserEntity>> GetAllUsers()
        {
            return _userService.GetUsers();
        }
        
    } 
}
