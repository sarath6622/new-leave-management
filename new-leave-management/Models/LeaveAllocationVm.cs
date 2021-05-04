using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace new_leave_management.Models
{
    public class LeaveAllocationVm
    {
        public int Id { get; set; }
        public int NumerOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public EmployeeVM Employee { get; set; }
        public String EmployeeId { get; set; }
        public DetailsLeaveTypeVM Leave { get; set; }
        public int LeaveTypeId { get; set; }
        public IEnumerable<SelectListItem> Employees { get; set; }
        public IEnumerable<SelectListItem> LeaveTypes { get; set; }
    }
}
