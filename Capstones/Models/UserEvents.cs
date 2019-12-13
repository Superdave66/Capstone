using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Capstones.Models
{
    public class UserEvents
    {
        [Key, Column(Order = 0)]
        public string ApplicationUserID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Key, Column(Order = 1)]
        public int EventID { get; set; }
        public virtual  Events Event{ get; set; }

       
    }



}
