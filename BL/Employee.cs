using BL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Utilities;
using Model;

namespace BL
{
    public class Employee : IEmployee
    {
        EmployeeInformationEntities db = new EmployeeInformationEntities();

        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            List<EmployeeModel> model = new List<EmployeeModel>();
            EmployeeModel mapResult;
            var results = db.EmployeeMasters;

            foreach (var result in results)
            {
                mapResult = result.MapToModel<EmployeeModel, EmployeeMaster>();
                model.Add(mapResult);
            }

            return model.ToList();
        }
    }
}
