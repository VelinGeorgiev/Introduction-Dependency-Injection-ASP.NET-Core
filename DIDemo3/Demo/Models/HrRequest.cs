using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class HrRequest
    {
        [Key]
        public int Id { get; set;  }
        public string Message { get; set; }
        public string AssignedTo { get; set; }
        public DateTime Created { get; set; }
    }
}