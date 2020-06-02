using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.AdminRepositories
{
   public interface IAdminRepository
    {
        Admin Login(string email, string password);
        bool AdminExsist(string email);
        Admin CheckByToken(string token);
        void UpdateToken(int id, string token);

    }
}
