using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProductDetailProject.Models
{

    [Table("CategoryTable")]
    public class CategoryTable
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }

        
        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual ProductTable ProductTable { get; set; }
    }
}