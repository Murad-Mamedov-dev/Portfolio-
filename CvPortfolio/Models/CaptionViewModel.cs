using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvPortfolio.Models
{
    public class CaptionViewModel
    {
        public int Id { get; set; }
        public PersonPhoto Photo { get; set; }

        public string Logo { get; set; }

        public string Title { get; set; }

        public string Detail { get; set; }

        public string Video { get; set; }
        public List<CaptionIcon> Icons { get; set; }
    }
}
