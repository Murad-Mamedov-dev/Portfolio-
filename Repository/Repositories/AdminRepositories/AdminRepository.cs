using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminRepositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly CvPortfolioDbContext _context;
        public AdminRepository(CvPortfolioDbContext context)
        {
            _context = context;
        }
        public bool AdminExsist(string email)
        {
            return _context.Admins.Any(a => a.Email == email);
        }

        public Admin CheckByToken(string token)
        {
            return _context.Admins.FirstOrDefault(a => a.Token == token);
        }

        public Admin Login(string email, string password)
        {
            Admin admin = _context.Admins.FirstOrDefault(a => a.Email == email);
            if (admin != null && admin.Password==password) 
            {
                return admin;
            }
            return null;
            
        }

        public void UpdateToken(int id, string token)
        {
            Admin admin = _context.Admins.Find(id);
            admin.Token = token;
            _context.SaveChanges();
        }
    }
}
