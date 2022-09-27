
using Employee_Management_system.Model;
using Employee_Management_system.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_system.Controller
{

    class EmployeeController
    {

        internal static ServiceInterface? ServiceInterface;

        internal static void controllerService(ServiceInterface serviceInterface)
        {
            ServiceInterface = serviceInterface;
        }

        internal static void createEmployee(List<Employee> empList)
        {
            bool found;
            //Console.WriteLine("\nEnter employee id:");
            //int empId = Convert.ToInt32(Console.ReadLine());

            string empId = ServiceInterface!.generateID();

            found = ServiceInterface!.findEmployee(empList, empId);

            if (found)
            {
                Console.WriteLine("\nEmployee already exists...");
            }
            else
            {
                found = ServiceInterface.createEmployee(empList, empId);
                if (found)
                {
                    Console.WriteLine("\nEmployee created successfully...");
                }
                else
                {
                    Console.WriteLine("\nEmployee create failed please try again...");
                }
            }

        }

        internal static void findEmployees(List<Employee> empList)
        {
            ServiceInterface!.findEmployees(empList);
        }

        internal static void findEmployee(List<Employee> empList)
        {
            // bool found = false;
            Console.WriteLine("\nEnter employee id to search");
            string? empId = Console.ReadLine();
            
            bool found = ServiceInterface!.findEmployee(empList, empId);
            if (!found)
            {
                Console.WriteLine("\nEmployee not found...");
            }
            else
            {
                Console.WriteLine("\nEmployee found successfully...");
            }
        }

        internal static void updateEmployee(List<Employee> empList)
        {
            //bool found = false;
            Console.WriteLine("\nEnter employee id to update...");
            string? empId = Console.ReadLine();

            bool found = ServiceInterface!.updateEmployee(empList, empId);
            if (!found)
            {
                Console.WriteLine("\nEmployee update failed or Employee not found...");
            }
            else
            {
                Console.WriteLine("\nEmployee details update successfully...");
            }
        }

        internal static void deleteEmployee(List<Employee> empList)
        {
           // bool found = false;
            Console.WriteLine("\nEnter employee id to delete: ");
            string? empId = Console.ReadLine();

            bool found = ServiceInterface!.deleteEmployee(empList, empId);
            if (found)
            {
                Console.WriteLine("\nEmployee deleted successfully...");
            }
            else
            {
                Console.WriteLine("\nEmployee not found...");
            }
        }

    }
}
