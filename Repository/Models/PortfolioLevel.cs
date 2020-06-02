using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class PortfolioLevel : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Land { get; set; }
        public ICollection<PortfolioPhoto> Photos { get; set; }
    }
}
