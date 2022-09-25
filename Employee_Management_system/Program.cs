
using System;
using System.Drawing;
using Employee_Management_system.Controller;
using Employee_Management_system.Model;
using Employee_Management_system.Service;

namespace main
{
    class EmployeeMain : EmployeeController
    {

        public static void Main(string[] args)
        {

            // empty emp list
            List<Employee> empList = new List<Employee>();

            // service object
            // using reference variable of interface
            ServiceInterface empSer = new ServiceEmployee();
            controllerService(empSer);
            

            Console.WriteLine("Please enter your name: ");
            string? userName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("******************************************");
            Console.WriteLine("\tEmployee Management System");
            Console.WriteLine("******************************************");
            Console.WriteLine("\tWelcome " + userName);
            int ch;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine(
                    """
                    1. Create
                    2. Read
                    3. Search
                    4. Update
                    5. Delete
                    6. Exit
                    """
                    );
                Console.WriteLine("Enter your choice:");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        createEmployee(empList);
                        break;
                    case 2:
                        findEmployees(empList);
                        break;
                    case 3:
                        findEmployee(empList);
                        break;
                    case 4:
                        updateEmployee(empList);
                        break;
                    case 5:
                        deleteEmployee(empList);
                        break;
                }

            }while(ch!= 6);
        }
    }
}