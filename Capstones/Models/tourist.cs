using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Capstones.Models
{
    public class Tourist
    {
      [Key]
        public int ID { get; set; }

        [Display(Name = "City to Search")]
        public string SelectedCity { get; set; }
        [Display(Name = "What are your interests?")]
        public List<string> Interests { get; set; }
    }
}