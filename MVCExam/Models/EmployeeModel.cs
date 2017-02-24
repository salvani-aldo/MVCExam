﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExam.Models
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddelName { get; set; }
        public System.DateTime BirthDate { get; set; }
    }
}