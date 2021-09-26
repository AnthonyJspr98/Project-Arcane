using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arcane.API.Data;
using Arcane.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Arcane.API.Controllers
{
    [ApiController]
    [Route("api/UserProfile")]
    public class UserProfileController : Controller
    {
        private readonly IUserProfileRepository _userProfileRepository;
        private readonly ILogger<UserProfileController> _logger;

        public UserProfileController(IUserProfileRepository userProfileRepository, ILogger<UserProfileController> logger)
        {
            _userProfileRepository = userProfileRepository;
            _logger = logger;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllUserProfile()
        {
            try
            {
                List<UserProfile> userProfiles = await _userProfileRepository.GetAllUserProfileAsync();

                if (!userProfiles.Any())
                {
                    _logger.LogError(404, "GetAllUserProfile = No UserProfile Found");
                    return NotFound();
                }

                return Ok(userProfiles);
            }
            catch (Exception ex)
            {
                _logger.LogError(400, $"GetAllUserProfile - Error:{ex.Message}");
                return BadRequest();
            }
        }

    }
}