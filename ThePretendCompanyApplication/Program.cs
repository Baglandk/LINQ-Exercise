using System;
using TCPData;
using TCPExtentions;

namespace ThePretend
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments();

            /////////// Sorting
            //var result = employees.Join(departments, e=>e.DepartmentId, c=>c.Id,
            //    (emp, dept) => new
            //    {
            //        Id = emp.Id,
            //        DepartmentId = dept.Id,
            //        FulName = emp.FirstName +" "+ emp.LastName
            //    }).OrderBy(o=>o.DepartmentId).ThenBy(o=>o.Id);///orderbydecending, orderby,thenbydecending

            //var result = from employee in employees
            //             join dept in departments
            //             on employee.DepartmentId equals dept.Id
            //             orderby dept.Id descending, employee.Id descending
            //             select new
            //             {
            //                 Id = employee.Id,
            //                 DepartmentId = dept.Id,
            //                 FulName = employee.FirstName + " " + employee.LastName
            //             };

            ///////Grouping
            //var result = from emp in employees
            //             join dept in departments
            //             on emp.DepartmentId equals dept.Id
            //             orderby emp.DepartmentId
            //             select new
            //             {
            //                 Id = emp.Id,
            //                 FirstName = emp.FirstName,
            //                 LastName = emp.LastName,
            //                 DepartmentName = dept.longName
            //             };
            //var result2 =from emp in result group emp by emp.DepartmentName;
            //foreach(var percon in  result2)
            //{
            //    Console.WriteLine("Department Name: "+percon.Key);
            //    foreach(var p in percon)
            //    {
            //        Console.WriteLine(p.FirstName+" "+p.LastName);
            //    }
            //}
            ////////All, any
            ///
            //var anu = 20000;
            //bool isAll = employees.All(x=>x.AnnualSalary>=anu);
            //if (isAll)
            //{
            //    Console.WriteLine("Greate");
            //}
            //else
            //{
            //    Console.WriteLine("So saad");
            //}
            //bool isAny = employees.Any(x=>x.AnnualSalary >= anu);
            //if (isAny)
            //{
            //    Console.WriteLine("Greate at least");
            //}
            //else
            //{
            //    Console.WriteLine("So so saad");
            //}
            var contains = employees.Contains(new Employee()
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Jones",
                AnnualSalary = 60000.3m,
                isManager = true,
                DepartmentId = 1,
            });
            if (contains)
            {
                Console.WriteLine("Greate at least");
            }
            else
            {
                Console.WriteLine("So so saad");
            }
            //// ElementAt(), ElementAtOrDefault(), First, FirstOrDefaul, Last,LastOrDefault
            ///Single, SingleOrDefault
            ///
            var s = employees.Single(x=>x.Id == 1);
            Console.WriteLine(s);
            ///SequenceEqual IEqualityCompare<> .Concat
            // SELECT and Where method quary
            //var result = employees.Select(e => new
            //{
            //    FullName = e.FirstName + ' ' + e.LastName,
            //    AnnualSalary = e.AnnualSalary
            //}).Where(e=>e.AnnualSalary>=50000);

            ///method syntax
            //var result = departments.Join(employees,
            //    departments=>departments.Id, 
            //    employees=>employees.DepartmentId,
            //    (departments, employees) => new
            //    {
            //        FullName = employees.FirstName + " "+ employees.LastName,
            //        AnnualSalary = employees.AnnualSalary,
            //        Department = departments.longName
            //    });

            //var result = from dept in departments
            //             join emp in employees
            //             on dept.Id equals emp.DepartmentId
            //             select new
            //             {
            //                 FullName = emp.LastName+" " +emp.FirstName,
            //                 AnnualSalary = emp.AnnualSalary,
            //                 DepartmentName = dept.longName
            //             };

            //var result = from dept in departments
            //             join emp in employees
            //             on dept.Id equals emp.DepartmentId
            //             into emplyeeGroup
            //             select new
            //             {
            //                 Employees = emplyeeGroup,
            //                 DepartmentName = dept.longName
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.DepartmentName);
            //    foreach(var emp in  item.Employees)
            //    {
            //        Console.WriteLine(emp.FirstName + " " + emp.LastName);
            //    }
            //}



            /// from join on select new 
            //var res = from emp in employees
            //          join dept in departments
            //          on emp.DepartmentId equals dept.Id
            //          select new
            //          {
            //              FirstName = emp.FirstName,
            //              LastName = emp.LastName,
            //              AnnualSalary = emp.AnnualSalary,
            //              Manager = emp.isManager,
            //              Department = dept.longName
            //          };
            ////var filteredEmplyees = employees.Where(emp => emp.isManager==false);
            //var averageSalary = res.Average(x=>x.AnnualSalary);
            //Console.WriteLine("Average salaray is: "+averageSalary);
            //Console.WriteLine();
            //foreach (var employee in res)
            //{

            //    Console.WriteLine(employee.FirstName + " " + employee.LastName);
            //    Console.WriteLine(employee.Department + " " + employee.AnnualSalary);
            //    Console.WriteLine("is manager: " + employee.Manager);
            //    Console.WriteLine();
            //}
        }
    }
}