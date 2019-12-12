using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Capstones.Models
{
    public class Events
    {
        [Key]
        public int Id { get; set; }
        [Display (Name ="Location of Event")]
        public string Location { get; set; }
        [Display(Name ="Date and Time of Event")]
        public DateTime DateTImeOfEvent { get; set; }

        [Display(Name ="number of Attendess")]
        public  int Attendees { get; set; }
        //[ForeignKey("EventId")]
        //public string ApplicationId { get; set; }
        //public ApplicationDbContext ApplicationDbContext { get; set; }


    }
}