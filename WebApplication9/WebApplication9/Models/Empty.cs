using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication9.Models
{
    public class Empty
    {

        [Key]
     
        public int EventID { get; set; }
        [Required]
        public string EventName { get; set; }
        [Required]
        public string Detail { get; set; }
         
         public DateTime Start{ get; set; }
        [Required]

        public DateTime End { get; set; }
        public string Color { get; set; }
       
    }
}
