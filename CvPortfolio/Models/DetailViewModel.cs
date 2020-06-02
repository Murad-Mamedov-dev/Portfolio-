using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvPortfolio.Models
{
    public class DetailViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string Detail { get; set; }
  
        public string CreatedBy { get; set; }
       
        public string Client { get; set; }
        
        public string EndPoint { get; set; }
        public decimal Price { get; set; }
        public IList<PortfolioPhotoViewModel> Photos { get; set; }
    }
}
