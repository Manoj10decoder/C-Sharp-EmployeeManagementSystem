using Employee_Management_system.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Employee_Management_system.Service
{

    class ServiceEmployee : ServiceInterface
    {
         bool ServiceInterface.createEmployee(List<Employee> empList, string? empId)
        {
            Console.WriteLine("\nEnter employee name:");
            string? empName = Console.ReadLine();

            Console.WriteLine("Enter employee age:");
            int empAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter employee phone number:");
            string? empPhoneNumber = Console.ReadLine();
            try
            {
                empList.Add(new Employee(empId, empName, empAge, empPhoneNumber));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        void ServiceInterface.findEmployees(List<Employee> empList)
        {
            Console.WriteLine("\n|{0,-33}|{1,-15}|{2,-10}|{3,-15}|", "Id", "Name", "Age", "Phone number");
            foreach (Employee emp in empList)
            {
                emp.employeeDetails();
            }
        }

        bool ServiceInterface.findEmployee(List<Employee> empList, string? empId)
        {
            foreach (Employee e in empList)
            {
                if (e.EmployeeId == empId)
                {
                    Console.WriteLine("\n|{0,-33}|{1,-15}|{2,-10}|{3,-15}|", "Id", "Name", "Age", "Phone number");
                    e.employeeDetails();
                    return true;
                }
            }
            return false;
        }

        bool ServiceInterface.updateEmployee(List<Employee> empList, string? empId)
        {
            int ch;
            bool update = false;
            foreach (Employee e in empList)
            {
                if (e.EmployeeId == empId)
                {

                    Console.WriteLine(
                            """
                            1. Bulk update
                            2. Individual field update
                            3. Exit
                            """
                            );
                    Console.WriteLine("Enter your choice: ");
                    ch = Convert.ToInt32(Console.ReadLine());
                    if (ch == 1)
                    {
                        Console.WriteLine("\nEnter new name: ");
                        string? name = Console.ReadLine();
                        e.EmployeeName = name;

                        Console.WriteLine("\nEnter new age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        e.EmployeeAge = age;

                        Console.WriteLine("\nEnter new phone numeber: ");
                        string? phone = Console.ReadLine();
                        e.EmpPhoneNumber = phone;

                        update = true;
                        return update;
                    }
                    else if(ch == 2)
                    {
                        
                      
                        Console.WriteLine("\n");
                        Console.WriteLine("""
                        1. Change name
                        2. Change age
                        3. Change phone number
                        4. Exit
                        """);
                        Console.WriteLine("Choose you want to change...");
                        ch = Convert.ToInt32(Console.ReadLine());

                        switch (ch)
                        {
                            case 1:
                                Console.WriteLine("\nEnter new name: ");
                                string? name = Console.ReadLine();
                                e.EmployeeName = name;
                                update = true;
                                break;
                            case 2:
                                Console.WriteLine("\nEnter new age: ");
                                int age = Convert.ToInt32(Console.ReadLine());
                                e.EmployeeAge = age;
                                update = true;
                                break;
                            case 3:
                                Console.WriteLine("\nEnter new phone numeber: ");
                                string? phone = Console.ReadLine();
                                e.EmpPhoneNumber = phone;
                                update = true;
                                break;
                            default:
                                return update;
                        }
                        
                    }
                    else
                    {
                        return update;
                    }
                }
            }
            return update;
        }

        bool ServiceInterface.deleteEmployee(List<Employee> empList, string? empId)
        {
            try
            {
                var itemToRemove = empList.Single(r => r.EmployeeId == empId);
                empList.Remove(itemToRemove);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        string ServiceInterface.generateID()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
