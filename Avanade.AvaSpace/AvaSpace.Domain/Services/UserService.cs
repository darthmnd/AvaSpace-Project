using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaSpace.Domain.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }
    }
}
