using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExcellentTaste.Models
{
    [Table("Reservations")]
    public class Reservation
    {
        public Reservation()
        {
        }

        public Reservation(ReservationViewModel rvm)
        {
            ReservationID = rvm.ReservationID;
            LastName = rvm.LastName;
            PhoneNumber = rvm.PhoneNumber;
            ReservationBool = rvm.ReservationBool;
            Start = rvm.Start;
            End = rvm.End;
        }
        [Key]
        public int ReservationID { get; set;}
        [Required]
        [Display(Name = "Achternaam")]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "tel. nr.")]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Tafel(s)")]
        public virtual ICollection<Table> Tables { get; set; }
        [Required]
        [Display(Name = "Reservering")]
        public bool ReservationBool { get; set; }
        [Required]
        [Display(Name = "Start")]
        public DateTime Start { get; set; }
        [Required]
        [Display(Name = "Eind")]
        public DateTime End { get; set; }
        [Required]
        [Display(Name = "Bestelling(en)")]
        public virtual ICollection<Order> Orders { get; set; }

        public Employee Employee { get; set; }
    }
    [NotMapped]
    public class ReservationViewModel : Reservation
    {
    }
}