using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Capstones.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        [Display(Name ="StreetAdress")]
        public string Streetaddress { get; set; }
        [Display(Name ="city")]
        public string City  { get; set; }
        [Display(Name= "State")]
        public string State { get; set; }
        [Display(Name ="ZipCode")]
        public int ZipCode { get; set; }


    }   
}