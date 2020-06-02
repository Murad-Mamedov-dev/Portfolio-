using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.UserRepositories
{
   public class UserRepository : IUserRepository
    {
        private readonly CvPortfolioDbContext _context;
        public UserRepository(CvPortfolioDbContext context)
        {
            _context = context;
        }

        public User CreateUser(User user)
        {
            user.ModifiedDate = DateTime.Now;
            user.ModifiedBy = "System";
            user.AddedBy = "System";
            user.Status = true;


            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public IEnumerable<User> GetUsers( )
        {
            return _context.Users

                                     .Where(s => s.Status)
                                  
                                     .ToList();
        }
    }
}
