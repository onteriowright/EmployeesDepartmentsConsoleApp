using EmployeesDepartments.Data;
using EmployeesDepartmentsConsole.Data;
using EmployeesDepartmentsConsole.Models;
using System;
using System.Collections.Generic;

namespace EmployeesDepartmentsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepo = new EmployeeRepository();
            var departmentRepo = new DepartmentRepository();
            var getEmployees = employeeRepo.GetAllEmployees();
            var getDepartments = departmentRepo.GetAllDepartments();

            //foreach (var employee in getEmployees)
            //{
            //    Console.WriteLine($"{employee.FirstName} {employee.LastName} is in {employee.Department.DeptName}");
            //}


            //Console.WriteLine("Let's get an employee with the ID 2");

            //var employeeWithId2 = employeeRepo.GetEmployeeById(2);

            //Console.WriteLine($"Employee with Id 2 is {employeeWithId2.FirstName} {employeeWithId2.LastName}");

            //Console.WriteLine("Getting All Departments:");
            //Console.WriteLine();

            //foreach (var dept in getDepartments)
            //{
            //    Console.WriteLine($"{dept.Id} {dept.DeptName}");
            //}

            //Department legalDept = new Department
            //{
            //    DeptName = "Legal"
            //};

            //departmentRepo.AddDepartment(legalDept);

            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Added the new Legal Department!");

            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("");
                Console.WriteLine("1. Show all departments");
                Console.WriteLine("2. Show specific department by Id");
                Console.WriteLine("3. Add new department");
                Console.WriteLine("4. Update department information");
                Console.WriteLine("5. Delete department by Id");
                Console.WriteLine("6. Show all employees");
                Console.WriteLine("7. Show specific employee by Id");
                Console.WriteLine("8. Show all employees by department");
                Console.WriteLine("9. Add new employee");
                Console.WriteLine("10. Update employee information");
                Console.WriteLine("11. Delete employee by Id");
                Console.WriteLine();

                Console.Write("Please choose selection and press return key: ");
                var choice = Console.ReadLine();

                Console.WriteLine();

                if (int.Parse(choice) == 1)
                {
                    Console.WriteLine("Getting All Departments:");
                    Console.WriteLine();

                    foreach (var dept in getDepartments)
                    {
                        Console.WriteLine($"{dept.Id}. {dept.DeptName}");
                        Console.WriteLine();
                    }

                    break;
                }

            }
        }
    }
}
