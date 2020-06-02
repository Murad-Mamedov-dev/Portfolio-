using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.DetailRepositories
{
  public  class DetailRepository:IDetailRepository
    {
        private readonly CvPortfolioDbContext _context;
        public DetailRepository(CvPortfolioDbContext context)
        {
            _context = context;
        }

        public PortfolioDetail GetPortfolioDetailById(int id)
        {
            return _context.PortfolioDetails.Include("Photos").FirstOrDefault(p=>p.Id== id);
        }
    }
}
