using KnowMeRepository.Context;
using KnowMeRepository.Interfaces;
using KnowMeRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowMeRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            context = _context;
        }

        public async Task CreateUserAsync(User user)
        {
            await _context.AddAsync(user);
        }
    }
}
