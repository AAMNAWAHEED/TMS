using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    [ApiController]
    [Route("api/[controller]")]
    /// <summary>
    /// constroller for user-related operations
    /// </summary>
    class UserController : ControllerBase
    {
        private readonly UserService _userService;
        public UserController(UserService userService) 
        {
            _userService = userService;
        }

        /// <summary>
        /// register a new user
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> RegisterUser(UserInfo userInfo)
        {
            OutputResult outputResult =  await _userService.RegisterUser(userInfo);
            return Ok(outputResult);
        }
    }
}
