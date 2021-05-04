using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace new_leave_management.Models
{
    public class EmployeeVM
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public String LastName { get; set; }
        public String TaxId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
