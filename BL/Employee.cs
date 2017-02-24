﻿using BL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class Employee : IEmployee
    {
        EmployeeInformationEntities db = new EmployeeInformationEntities();

        public IEnumerable<EmployeeMaster> GetAllEmployees()
        {
            return db.EmployeeMasters;
        }
    }
}
