using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.MVVM.Model.EmployeeModel
{
    internal class Employee
    {
        public string EmployeeName { get; set; }
        public Guid EmployeeId { get; set; }

        public string EmployeePwd { get; set; }

        public Employee(string employeeName, Guid employeeId, string employeePwd)
        {
            EmployeeName = employeeName;
            EmployeeId = employeeId;
            EmployeePwd = employeePwd;
        }
    }
}
