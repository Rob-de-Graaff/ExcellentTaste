﻿using System;
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
            Done = ovm.Done;
            //TableNumbers = ovm.TableNumbers;
        }

        [Key]
        public int OrderID { get; set; }
        [Required]
        [Display(Name = "Tijd")]
        [DataType(DataType.Time)]
        public DateTime Time { get; set; }
        [Required]
        [Display(Name = "Bestelling klaar")]
        public bool Done { get; set; }
        //[Required]
        //[Display(Name = "Tafel nr.")]
        //public List<Table> TableNumbers { get; set; }

        public Reservation Reservation { get; set; }
        public virtual ICollection<Product> Products { get; set;}
    }

    [NotMapped]
    public class OrderViewModel : Order
    {
    }
}
