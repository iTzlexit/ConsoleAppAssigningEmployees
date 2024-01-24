using Entities;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsumesEmployees
{
    public class ConsumesEmployeesAssignment
    {
        public static void Main()
        {
            // initializing the static field. 
            Employee.organizationName = "Harsha Inc";

            for (int i = 0; i < 5; i++)
            {

                string employeeNumber;

                switch (i)
                {
                    case 0: employeeNumber = "1st Employee:"; break;
                    case 1: employeeNumber = "2nd Employee:"; break;
                    case 2: employeeNumber = "3rd Employee:"; break;
                    case 3: employeeNumber = "4th Employee:"; break;
                    case 4: employeeNumber = "5th Employee:"; break;
                    default: employeeNumber = "Other employee"; break;

                }

                Console.WriteLine(employeeNumber);
                // create Employee Object 

                Employee employee = new Employee();
                // enter employee id 
                Console.Write("Enter the employees Id: ");
                employee.empId = uint.Parse(Console.ReadLine()); // from string to unit 

                // enter employees name 
                Console.Write("Enter employees name: ");
                employee.empName = Console.ReadLine();

                // enter employee salary per hour 
                Console.Write("Salary Per Hour :");
                employee.salaryPerHour = uint.Parse(Console.ReadLine());

                // no of working hours 

                Console.Write("Number of working hours");
                employee.noOfWorkingHours = uint.Parse(Console.ReadLine());

                //calc the salary
                employee.salary = employee.noOfWorkingHours * employee.salaryPerHour;

                //display Employee Details
                System.Console.WriteLine("\nDETAILS OF " + employeeNumber);
                System.Console.WriteLine("Employee ID: " + employee.empId);
                System.Console.WriteLine("Employee Name: " + employee.empName);
                System.Console.WriteLine("Salary per Hour: " + employee.salaryPerHour);
                System.Console.WriteLine("No. of Working Hours: " + employee.noOfWorkingHours);
                System.Console.WriteLine("Net Salary: " + employee.salary);
                System.Console.WriteLine("Type of Employee: " + Employee.typeOfEmployee);
                System.Console.WriteLine("Department Name: " + employee.departmentName);

                Console.WriteLine();

                System.Console.Write("Do you want to continue to next employee? Yes / No: ");
                string choice = System.Console.ReadLine();

                if (!(choice == "yes" || choice == "YES" || choice == "Yes" || choice == "y" || choice == "Y"))
                {
                    break; // breaks from the current i et
                }

                System.Console.WriteLine("-----------------------------------"); //Separator line

            }

            System.Console.WriteLine("\nThank you.");
            System.Console.ReadKey();


        }



    }



}