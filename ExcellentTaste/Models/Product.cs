using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExcellentTaste.Models
{
    public enum ConsumableType
    {
        [Display(Name = "Dranken")] Drink,
        [Display(Name = "Gerechten")] Food
    } 

    public enum VAT
    {
        [Display(Name = "Laag")] Low,
        [Display(Name = "Hoog")] High
    }

    [Table("Products")]
    public class Product
    {
        public Product()
        { 
        }

        public Product(ProductViewModel pvm)
        {
            this.ProductID = pvm.ProductID;
            this.ConsumableType = pvm.ConsumableType;
            this.Name = pvm.Name;
            this.Price = pvm.Price;
            this.VAT = pvm.VAT;
            this.Availability = pvm.Availability;
        }
        [Key]
        public int ProductID { get; set; }
        [Required]
        [Display(Name = "Soort")]
        public ConsumableType ConsumableType { get; set; }
        [Required]
        [Display(Name = "Naam")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Prijs")]
        [DataType(DataType.Currency)]
        //[DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = true)]
        public double Price { get; set; }
        [Required]
        [Display(Name = "BTW")]
        public VAT VAT { get; set; }
        [Required]
        [Display(Name = "Beschikbaarheid")]
        public bool Availability { get; set;}

        public virtual Category Category { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
    [NotMapped]
    public class ProductViewModel : Product
    {
        public ProductViewModel() { }
        public ProductViewModel(Product product)
        {
            this.ProductID = product.ProductID;
            this.ConsumableType = product.ConsumableType;
            this.Name = product.Name;
            this.Price = product.Price;
            this.VAT = product.VAT;
            this.Availability = product.Availability;
        }

        public SelectList ListCategories { get; set; }
    }
}