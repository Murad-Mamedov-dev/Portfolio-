using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositeries.ContentRepositories
{
    public class ContentRepository : IContentRepository
    {
        private readonly CvPortfolioDbContext _context;
        public ContentRepository(CvPortfolioDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Caption> GetCaptions()
        {
            return _context.Captions.Include("Icons")
                                    .Include("Photo")
                                    .Where(s => s.Status)
                                    .ToList();
        }

        public IEnumerable<EECart> GetEduCarts()
        {
            return _context.EECart

                                     .Where(s => s.Status)
                                    .Where(s => s.IsEdu)
                                     .ToList();
        }

        public IEnumerable<EECart> GetexpCarts()
        {
            return _context.EECart

                                    .Where(s => s.Status)
                                   .Where(s => s.IsExp)
                                    .ToList();
        }

        public Info GetInfos()
        {
            return _context.Infos.Include("Photo").FirstOrDefault(i=>i.Status);
        }

        public IEnumerable<PortfolioLevel> GetPortfolioLevels()
        {
            return _context.PortfolioLevels.Include("Photos")
                
                                      .Where(s => s.Status)
                                      .ToList();
        }

        public IEnumerable<PortfolioPhoto> GetPortfolioPhotos()
        {
            return _context.PortfolioPhotos.Include("Icons")
                                      .Include("PortfolioLevel")
                                      .Include("PortfolioDetail")
                                      .Where(s => s.Status)
                                      .ToList();
        }

        public IEnumerable<Service> GetServices()
        {
            return _context.Services

                                   .Where(s => s.Status)
                                   .ToList();
        }

        public IEnumerable<SkillValue> GetSkils()
        {
            return _context.SkillValues

                                   .Where(s => s.Status)
                                   .ToList();
        }
    }
}

