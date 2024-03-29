﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Capstones.Models
{
    public class Tourist
    {
      [Key]
        public int ID { get; set; }
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "what city do you wish to search?")]
        

        public string SelectedCity { get; set; }
        [Display(Name = "what state do you wish to search?")]
        public string SelectedState { get; set; }

        [Display(Name = "what 1 interest do you wish to search with?")]
        
        public string Interests { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

    }
}