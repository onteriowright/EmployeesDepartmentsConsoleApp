using System;
using System.Collections.Generic;
using EmployeesDepartments.Data;
using EmployeesDepartmentsConsole.Data;
using EmployeesDepartmentsConsole.Models;

namespace EmployeesDepartmentsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepo = new EmployeeRepository();
            var departmentRepo = new DepartmentRepository();
            var getEmployees = employeeRepo.GetAllEmployees();

            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("");
                Console.WriteLine("1. Show all departments in database");
                Console.WriteLine("2. Show specific department by Id");
                Console.WriteLine("3. Create a new department");
                Console.WriteLine("4. Delete department by Id");
                Console.WriteLine("5. Show all employees in database");
                Console.WriteLine("6. Show specific employee by Id");
                Console.WriteLine("7. Show all employees by department");
                Console.WriteLine("8. Create a new employee");
                Console.WriteLine("9. Delete employee by Id");
                Console.WriteLine("10. Exit");
                Console.WriteLine();

                Console.Write("Please choose selection and press return key: ");
                var choice = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine();

                if (choice == 1)
                {
                    Console.WriteLine("Getting All Departments:");
                    Console.WriteLine();

                    var allDepartments = departmentRepo.GetAllDepartments();

                    foreach (var department in allDepartments)
                    {
                        Console.WriteLine($"{department.Id}. {department.DeptName}");
                        Console.WriteLine();
                    }

                    break;
                }
                else if (choice == 2)
                {
                    Console.Write("Enter Department ID and press return key: ");

                    var departmentId = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine($"Getting department with ID: {departmentId}");

                    var individualDepartment = departmentRepo.GetDepartmentById(departmentId);


                    Console.WriteLine();
                    Console.Write($"Found department associated with that ID: ");
                    Console.WriteLine($"{individualDepartment.Id}. {individualDepartment.DeptName}");

                    break;

                }
                else if (choice == 3)
                {
                    Console.Write("Enter new department: ");
                    var departmentName = Console.ReadLine();

                    var newDepartment = new Department()
                    {
                        DeptName = departmentName
                    };

                    departmentRepo.AddDepartment(newDepartment);
                    Console.WriteLine();

                    Console.WriteLine($"The new {departmentName} department has been added!");

                    break;
                }
                else if (choice == 4)
                {
                    Console.Write("Enter ID department ID you want to delete: ");
                    var departmentToDelete = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    departmentRepo.DeleteDepartment(departmentToDelete);

                    Console.WriteLine($"Department ID: {departmentToDelete} has been deleted!");
                    break;
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Getting all employees:");
                    Console.WriteLine();

                    var allEmployees = employeeRepo.GetAllEmployees();

                    foreach (var employee in allEmployees)
                    {
                        Console.WriteLine($"{employee.FirstName} {employee.LastName}");
                        Console.WriteLine();
                    }

                    break;
                }
                else if (choice == 6)
                {
                    Console.Write("Enter ID of employee: ");

                    var employeeId = int.Parse(Console.ReadLine());

                    var individualEmployee = employeeRepo.GetEmployeeById(employeeId);

                    Console.WriteLine();
                    Console.Write($"Found employee associated with that ID: ");
                    Console.WriteLine($"{individualEmployee.Id}. {individualEmployee.FirstName} {individualEmployee.LastName}");

                    break;
                }
                else if (choice == 7)
                {
                    var allDepartmentEmployees = employeeRepo.GetAllEmployeesWithDepartment();

                    foreach (var departmentEmployee in allDepartmentEmployees)
                    {
                        Console.WriteLine($"{departmentEmployee.FirstName} {departmentEmployee.LastName}: {departmentEmployee.Department.DeptName}");
                    }

                    break;
                }
                else if (choice == 8)
                {
                    Console.Write("Enter employees first name: ");
                    var firstName = Console.ReadLine();

                    Console.WriteLine();

                    Console.Write("Enter employees last name: ");
                    var lastName = Console.ReadLine();

                    Console.WriteLine();

                    Console.Write("Enter employees department ID: ");
                    var employeesDepartmentId = int.Parse(Console.ReadLine());

                    var newEmployee = new Employee()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        DepartmentId = employeesDepartmentId
                    };

                    employeeRepo.CreateNewEmployee(newEmployee);

                    Console.WriteLine();
                    Console.WriteLine($"{newEmployee.FirstName} {newEmployee.LastName} was added to the database as a new employee");

                    break;
                }
                else if (choice == 9)
                {
                    Console.Write("Enter employee ID that you would like to delete: ");
                    var employeeIdToDelete = int.Parse(Console.ReadLine());

                    employeeRepo.DeleteEmployee(employeeIdToDelete);

                    Console.WriteLine();
                    Console.WriteLine($"Employee ID: {employeeIdToDelete} has been deleted!");

                    break;
                }
                else if (choice == 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid selection");
                    Console.WriteLine();
                }

            }
        }
    }
}
