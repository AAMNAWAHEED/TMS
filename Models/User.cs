using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Models
{
    public class User
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
