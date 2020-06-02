using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.UserRepositories
{
 public  interface IUserRepository
    {
         IEnumerable<User> GetUsers();
        User CreateUser(User user);
              
    }
}
