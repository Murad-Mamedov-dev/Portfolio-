using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class PortfolioPhoto : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Photo { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public ICollection<PortfolioIcon> Icons { get; set; }
        public int PortfolioLevelId { get; set; }
        public PortfolioLevel PortfolioLevel { get; set; }
        public int PortfolioDetailId { get; set; }
        public PortfolioDetail PortfolioDetail { get; set; }

    }
}
