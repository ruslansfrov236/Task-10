using System;
using System.Collections.Generic;
using Task10.customer;
using Task10.IModel;

namespace Task10.Model
{
    public class EmployeeModel : IEmployeeModel<Employee>
    {
        private List<Employee> employees = new List<Employee>();

        public bool CreateEmployee()
        {
            Employee employee = new Employee();

           
                employee.Id = employees.Count + 1;
            

            Console.WriteLine("Enter the information");
            Console.Write("Enter the name:");
            employee.Name = Console.ReadLine();
            Console.Write("Enter the Surname:");
            employee.SurName = Console.ReadLine();
            Console.Write("Enter the age");
            if (byte.TryParse(Console.ReadLine(), out byte age))
            {
                employee.Age = age;
            }
            else
            {
                Console.WriteLine("Entered age is not valid!");
                return false;
            }
            Console.Write("Enter the salary:");
            if (double.TryParse(Console.ReadLine(), out double salary))
            {
                employee.Salary = salary;
            }
            else
            {
                Console.WriteLine("Entered salary is not valid");
                return false;
            }

            employees.Add(employee);
            return true;
        }

        public void GetEmployeeById(int id)
        {
         
            Employee employee = employees.Find(e => e.Id == id);

            if (employee != null)
            {
                Console.WriteLine($"Employee Id: {employee.Id}, Name: {employee.Name}, Surname: {employee.SurName}, Age: {employee.Age}, Salary: {employee.Salary}");
            }
            else
            {
                Console.WriteLine("Employee not found!");
            }
        }

        public List<Employee> GetEmployees()
        {
            if(employees.Count== 0)
            {
                Console.WriteLine("There is no information about the employee!");
            }
            else
            {
                foreach (var item in employees)
                {
                    Console.WriteLine($"Employee Id: {item.Id}, Name: {item.Name}, Surname: {item.SurName}, Age: {item.Age}, Salary: {item.Salary}");
                }
            }
           

            return employees;
        }
    }
}
