﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace new_leave_management.Data
{
    public class LeaveType
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name{ get; set; }
        public DateTime  DateCreated{ get; set; }
    }
}
