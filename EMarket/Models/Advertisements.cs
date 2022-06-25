using EMarket.Areas.Identity.Pages.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EMarket.Models
{
    public class Advertesiments
    {
        [Key]
        public int AdvertesimentsID { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Categories Categories { get; set; }

        [ForeignKey("Id")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        public string ArticleName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Images { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]

        public DateTime Date { get; set; }





    }
}
