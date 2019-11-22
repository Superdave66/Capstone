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
        [ForeignKey("UserName")]
        public string UserName { get; set; }

        public virtual EventMaker eventMaker{ get; set; }
    }
}