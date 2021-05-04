using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace new_leave_management.Data
{
    public class LeaveAllocation
    {
        [Key]
        public int Id{ get; set; }
        public int NumerOfDays{ get; set; }
        public DateTime DateCreated{ get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee{ get; set; }
        public String EmployeeId{ get; set; }
        [ForeignKey("LeaveTypeId")]
        public LeaveType Leave{ get; set; }
        public int LeaveTypeId{ get; set; }
    }
}
