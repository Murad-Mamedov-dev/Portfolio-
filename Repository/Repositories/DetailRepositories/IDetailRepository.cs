using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.DetailRepositories
{
  public  interface IDetailRepository
    {
        PortfolioDetail GetPortfolioDetailById(int id);
    }
}
