using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesArrivalWeb.GeneralClass
{
    public class Employee
    {
        public Employee(int id, string name, string surName, int age, string role, int managerId, List<string> teams, int arrivalTime)
        {
            Id = id;
            Name = name;
            SurName = surName;
            Age = age;
            Role = role;
            ManagerId = managerId;
            Teams = teams;
            ArrivalTime = arrivalTime;
        }

        public int Id { get; }

        public string Name { get; }

        public string SurName { get; }

        public int Age { get; }

        public string Role { get; }

        public int ManagerId { get; }

        public List<string> Teams { get; }

        public int ArrivalTime { get; }
    }
}