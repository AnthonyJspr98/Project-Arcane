using Arcane.API.Data;
using Arcane.API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arcane.API.Services.Repositories
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly UserProfileDbContext _dbContext;
        public UserProfileRepository(UserProfileDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<UserProfile>> GetAllUserProfile()
        {
            return await _dbContext.UserProfiles.ToListAsync();
        }
    }
}
