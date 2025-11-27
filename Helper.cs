using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TMS
{
    public static class Helper
    {
        /// <summary>
        /// generate hashed password from plain text password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string HashPassword(string password)
        {
                var hasher = new PasswordHasher<object>();
                return hasher.HashPassword(null, password);
        }

            public static bool VerifyPassword(string hashedPassword, string providedPassword)
            {
                var hasher = new PasswordHasher<object>();
                var result = hasher.VerifyHashedPassword(null, hashedPassword, providedPassword);

                return result == PasswordVerificationResult.Success;
            }

    }
}
