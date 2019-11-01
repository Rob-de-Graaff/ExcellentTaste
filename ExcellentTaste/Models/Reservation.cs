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
            ReservationDate = rvm.ReservationDate;
            StartTime = rvm.StartTime;
            EndTime = rvm.EndTime;
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
        [Display(Name = "Reserveerdatum")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime ReservationDate { get; set; }
        [Required]
        [Display(Name = "Starttijd")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }
        [Required]
        [Display(Name = "Eindtijd")]
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }
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