using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExcellentTaste.Models
{
    [Table("Tables")]
    public class Table
    {
        public Table()
        { }

        public Table(TableViewModel tvm)
        {

        }
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Tafel nr.")]
        public string TableNumber { get; set; }

        public Reservation Reservation { get; set; }
    }
    [NotMapped]
    public class TableViewModel : Table
    { 
    }
}