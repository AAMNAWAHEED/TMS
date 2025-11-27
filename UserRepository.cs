using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Models;

namespace TMS
{
    /// <summary>
    /// repository for user-related database operations
    /// </summary>
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        /// <summary>
        /// repository for user-related database operations
        /// </summary>
        /// <param name="appDbContext">DbContext use for database operations </param>
        public UserRepository(AppDbContext appDbContext) 
        {
            _context = appDbContext;

        }
        /// <summary>
        /// method to add a new user to the database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<bool> AddUser(User user)
        {
            await _context.Users.AddAsync(user);
            int changes = await  _context.SaveChangesAsync();
            return changes > 0;

        }
    }
}
