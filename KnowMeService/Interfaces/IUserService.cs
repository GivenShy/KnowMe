using KnowMeService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowMeService.Interfaces
{
    public interface IUserService
    {
        public Task CreateUserAsync(CreateUserDTO userDTO, string subject);
    }
}
