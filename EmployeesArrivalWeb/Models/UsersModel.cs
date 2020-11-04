using EmployeesArrivalWeb.GeneralClass;
using System.Collections.Generic;

namespace EmployeesArrivalWeb.Models
{
    public class UsersModel
    {
        private List<Employee> _employees;


        public List<Employee> Employees
        {
            get => _employees ?? (_employees = new List<Employee>());
            set => _employees = value;
        }
    }
}
