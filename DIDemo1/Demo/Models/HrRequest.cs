using System;
using System.ComponentModel.DataAnnotations;

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