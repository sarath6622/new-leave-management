using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace new_leave_management.Models
{
    public class DetailsLeaveTypeVM
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }
    public class CreateLeaveTypeVM
    {
        [Required]
        public string Name { get; set; }
    }
}
