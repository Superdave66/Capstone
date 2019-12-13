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
        [Display(Name ="Name of Event")]
        public string NameOfEvent { get; set; }

        [Display(Name ="Date and Time of Event")]
        public DateTime? DateTImeOfEvent { get; set; }

        [Display(Name ="Number of Attendess")]
        public  int Attendees { get; set; }
        [Display(Name ="Interest to Assiocate Event to")]
        public string KeyWord { get; set; }
        [ForeignKey("Address")]
        public Address Address  { get; set; }
        public ApplicationDbContext ApplicationDbContext { get; set; }


    }
}