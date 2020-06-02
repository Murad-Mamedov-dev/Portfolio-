using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvPortfolio.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public string Name { get; set; }
      
        public string Comment { get; set; }
    }
}
