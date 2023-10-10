using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPData
{
    public static class Data
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee()
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Jones",
                    AnnualSalary = 60000.3m,
                    isManager = true,
                    DepartmentId = 1,
                },
                new Employee()
                {
                    Id = 2,
                    FirstName = "Sarah",
                    LastName = "Jameson",
                    AnnualSalary = 80000.1m,
                    isManager = true,
                    DepartmentId = 3,
                },
                new Employee()
                {
                    Id = 3,
                    FirstName = "Douglas",
                    LastName = "Robert",
                    AnnualSalary = 40000.1m,
                    isManager = false,
                    DepartmentId = 2,
                },
                new Employee()
                {
                    Id = 4,
                    FirstName = "Jane",
                    LastName = "Steven",
                    AnnualSalary = 30000.1m,
                    isManager = false,
                    DepartmentId = 3,
                }
            };
            return employees;
        }
        public static List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>
            {
                new Department() { 
                    Id = 1,
                    shortName= "A",
                    longName= "Automatic"
                },
                new Department() {
                    Id = 2,
                    shortName= "P",
                    longName= "Programming"
                },
                new Department() {
                    Id = 3,
                    shortName= "S",
                    longName= "Sales"
                }
            };
            return departments;
        }
    }
}
