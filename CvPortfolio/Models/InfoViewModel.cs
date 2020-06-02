using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvPortfolio.Models
{
    public class InfoViewModel
    {
        public string Title { get; set; }
       
        public string Text { get; set; }
   
        public string Name { get; set; }
     
        public string Address { get; set; }
     
        public int Age { get; set; }
       
        public string Email { get; set; }
 
       
        public string University { get; set; }

        public string Phone { get; set; }

        public string EndPoint { get; set; }
        public int PersonPhotoId { get; set; }
        public PersonPhoto Photo { get; set; }
    }
}
