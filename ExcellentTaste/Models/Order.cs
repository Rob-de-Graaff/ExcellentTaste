using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExcellentTaste.Models
{
    [Table("Orders")]
    public class Order
    {
        public Order()
        {
        }

        public Order(OrderViewModel ovm)
        { 
            OrderID = ovm.OrderID;
            Time = ovm.Time;
            TableNumbers = ovm.TableNumbers;
            Products = ovm.Products;
        }

        [Key]
        public int OrderID { get; set; }
        [Required]
        [Display(Name = "Tijd")]
        public DateTime Time { get; set; }
        [Required]
        [Display(Name = "Tafel nr.")]
        public List<Table> TableNumbers { get; set; }
        [Required]
        [Display(Name = "Gerechten")]
        public virtual ICollection<Product> Products { get; set; }

        public Reservation Reservation { get; set; }
        //public virtual ICollection<Product> Products { get; set;}
    }

    [NotMapped]
    public class OrderViewModel : Order
    {
    }
}
