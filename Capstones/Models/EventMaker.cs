using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Capstones.Models
{
    public class EventMaker
    {
        [Key]
        public int ID { get; set; }
        [Display(Name ="First Name")]
        public string FirstName{ get; set; }
        [Display(Name ="Last Name")]
        public string LastName { get; set; }


        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}