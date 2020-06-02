using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class PortfolioDetail : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        public string Detail { get; set; }
        [Required]
        [MaxLength(50)]
        public string CreatedBy { get; set; }
        [Required]
        [MaxLength(50)]
        public string Client { get; set; }
        [Required]
        [MaxLength(100)]
        public string EndPoint { get; set; }
        public decimal Price { get; set; }
        public ICollection<PortfolioPhoto> Photos { get; set; }


    }
}
