using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class PortfolioIcon : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public int PortfolioPhotoId { get; set; }
        public PortfolioPhoto PortfolioPhoto { get; set; }
        [Required]
        [MaxLength(50)]
        public string EndPoint { get; set; }
    }
}
