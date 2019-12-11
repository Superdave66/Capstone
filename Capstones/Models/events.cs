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
        public int Id;
        [Display (Name ="Location of Event")]
        public string Location { get; set; }
        [Display(Name ="Date and Time of Event")]
        public DateTime DateTImeOfEvent { get; set; }

        [Display(Name ="number of Attendess")]
        public  int Attendees { get; set; }
        [ForeignKey ("EventID")]
        public string ApplicationID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }


    }
}