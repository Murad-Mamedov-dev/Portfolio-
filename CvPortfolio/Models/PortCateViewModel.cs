using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvPortfolio.Models
{
    public class PortCateViewModel
    {
        public string ModifiedBy { get; set; }
        public string Name { get; set; }
        public string Land { get; set; }
        public List<PortfolioPhotoViewModel> Photos { get; set; }
    }
}
