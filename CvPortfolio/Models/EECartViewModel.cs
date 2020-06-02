using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvPortfolio.Models
{
    public class EECartViewModel
    {
        public string ModifiedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Logo { get; set; }
        
        public string Title { get; set; }
      
        public string Detail { get; set; }
    }
}
