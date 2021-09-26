using Arcane.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arcane.API.Services.Interfaces
{
    public interface IUserProfileRepository
    {
        Task<List<UserProfile>> GetAllUserProfileAsync();
        
    }
}
