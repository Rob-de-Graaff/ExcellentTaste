using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExcellentTaste.Models
{
    [Table("Customers")]
    public class Customer
    {
        public Customer()
        {
        }

        public Customer(CustomerViewModel custvm)
        {
            CustomerID = custvm.CustomerID;
            LastName = custvm.LastName;
            PhoneNumber = custvm.PhoneNumber;
            EmailAdress = custvm.EmailAdress;
        }

        [Key]
        public int CustomerID { get; set; }
        [Required]
        [Display(Name = "Achternaam")]
        public string LastName { get; set; }
        [Required]
        [Phone]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "tel. nr.")]
        public string PhoneNumber { get; set;}
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "e-mailadres")]
        public string EmailAdress { get; set; }
        
        public virtual ICollection<Reservation> Reservation { get; set; }
    }

    [NotMapped]
    public class CustomerViewModel : Customer
    {
    }
}