using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    /// <summary>
    /// use to store output result of operations
    /// </summary>
    public class OutputResult
    {
        /// <summary>
        /// either operation was successful or not
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// any exception or custom message during the operation
        /// </summary>
        public string Message { get; set; }
    }
    public class UserInfo
    {
        /// <summary>
        /// unique id for each user
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// unique username for each user
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// hashed password for security
        /// </summary>
        public string PasswordHash { get; set; }
        /// <summary>
        /// datetime when the user was created
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// datetime when the user was last updated
        /// </summary>
        public DateTime UpdatedAt { get; set; }
    }
}
