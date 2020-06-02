using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvPortfolio.Models
{
    public class PortfolioPhotoViewModel
    {
        
            public int Id { get; set; }
            public string Name { get; set; }
            public string Photo { get; set; }
            public IList<PortfolioIcon> Icons { get; set; }
            public PortCateViewModel PortfolioLevel { get; set; }
            public DetailViewModel PortfolioDetail { get; set; }
           public int PortfolioDetailId { get; set; }
    }
}
