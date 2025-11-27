using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Exceptions;
using TMS.Models;

namespace TMS
{
    /// <summary>
    /// use by usercontroller to handle user-related operations
    /// </summary>
    public class UserService
    {
        private readonly UserRepository _userRepository;
        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// use to register user using userrepository
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public async Task<OutputResult> RegisterUser(UserInfo userInfo)
        {
            OutputResult outputResult = new OutputResult();
            outputResult.Success = false;
            try
            {
                if (userInfo == null)
                {
                    throw new InvalidUserDetails();
                }
                User user = new User();
                if (string.IsNullOrEmpty(userInfo.Username))
                {
                    throw new InvalidUserDetails();
                }
                else
                {
                    user.Username = userInfo.Username;
                }
                if (string.IsNullOrEmpty(userInfo.PasswordHash))
                {
                    throw new InvalidUserDetails();
                }
                else
                {
                    string hashedPassword = Helper.HashPassword(userInfo.PasswordHash);
                    user.PasswordHash = hashedPassword;
                }
                bool result = await _userRepository.AddUser(user);
                outputResult.Success = result;
            }
            catch (Exception ex)
            {
                outputResult.Message = ex.Message;
            }
            return outputResult;


        }
    }
}
