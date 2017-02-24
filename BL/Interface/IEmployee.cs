using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interface
{
    public interface IEmployee
    {
        IEnumerable<EmployeeMaster> GetAllEmployees();
    }
}
