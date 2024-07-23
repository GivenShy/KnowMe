using KnowMeRepository.Interfaces;
using KnowMeRepository.Models;
using KnowMeService.DTOs;
using KnowMeService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowMeService
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService (IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task CreateUserAsync(CreateUserDTO userDTO, string subject)
        {
            User user = new User
            {
                Subject = subject,
                FirstName = userDTO.FirstName,
                LastName = userDTO.LastName,
                Email = userDTO.Email,
                Description = userDTO.Description,
            };

            await _userRepository.CreateUserAsync(user);
        }
    }
}
