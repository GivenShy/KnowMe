using KnowMeRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowMeRepository.Interfaces
{
    public interface IUserRepository
    {
        public Task CreateUserAsync(User user);
    }
}
