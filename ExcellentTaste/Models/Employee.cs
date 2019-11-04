using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExcellentTaste.Models
{
    public enum Role
    {
        Administrator,
        Barman,
        Ober,
        Kok
    }

    [Table("Employees")]
    public class Employee
    {
        public Employee()
        {
        }
        public Employee(EmployeeViewModel evm)
        {
            EmployeeID = evm.EmployeeID;
            EmailAdress = evm.EmailAdress;
            Password = evm.Password;
            Role = evm.Role;
            FirstName = evm.FirstName;
            LastName = evm.LastName;
            //DateOfBirth = evm.DateOfBirth;
            //City = evm.City;
            Reservations = evm.Reservations;
        }
        
        [Key]
        public int EmployeeID { get; set; }
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "e-mailadres")]
        public string EmailAdress { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Wachtwoord")]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Rol")]
        public Role Role { get; set; }
        [Required]
        [Display(Name = "Voornaam")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Achternaam")]
        public string LastName { get; set; }
        [NotMapped]
        [Display(Name = "Volledige Naam")]
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        //[Required]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[DataType(DataType.Date)]
        //[Display(Name = "Geboortedatum")]
        //public DateTime DateOfBirth { get; set; }
        //[Required]
        //[Display(Name = "Woonplaats")]
        //public string City { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
    [NotMapped]
    public class EmployeeViewModel : Employee
    {

    }
}