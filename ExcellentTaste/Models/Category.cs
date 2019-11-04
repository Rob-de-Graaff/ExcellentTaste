using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExcellentTaste.Models
{
   

    [Table("Categories")]
    public class Category
    {
        public Category()
        {
        }

        public Category(CategoryViewModel cvm)
        {
        }
        [Key]
        public int CategoryID { get; set; }
        [Required]
        [Display(Name = "Categorie eten/drinken")]
        public string CategoryType { get; set; }


        public virtual ICollection<Product> Products { get; set; }
    }
    [NotMapped]
    public class CategoryViewModel : Category
    {
    }
}