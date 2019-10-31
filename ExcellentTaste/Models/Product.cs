using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExcellentTaste.Models
{
    public enum ConsumableType
    {
        [Display(Name = "Dranken")] Drink,
        [Display(Name = "Gerechten")] Food
    }

    public enum DishType
    {
        [Display(Name = "Voorgerecht")] Entree,
        [Display(Name = "Warme Gerechten")] Hot,
        [Display(Name = "Koude Gerechten")] Cold,
        [Display(Name = "Nagerecht")] Dessert
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

        }
        [Key]
        public int ProductID { get; set; }
        [Required]
        [Display(Name = "Soort")]
        public ConsumableType ConsumableType { get; set; }
        [Required]
        [Display(Name = "Type")]
        public DishType DishType { get; set; }
        [Required]
        [Display(Name = "Naam")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Prijs")]
        public double Price { get; set; }
        [Required]
        [Display(Name = "BTW")]
        public VAT VAT { get; set; }

        public Order Order { get; set; }
    }
    [NotMapped]
    public class ProductViewModel : Product
    {
    }
}