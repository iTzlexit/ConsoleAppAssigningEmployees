namespace Entities
{
    public class Employee
    {
        public uint empId; // non negative int 
        public string empName;
        public double salaryPerHour;
        public double noOfWorkingHours;
        public double salary;


        public static string organizationName; // initialize it in the main method 


        public const string typeOfEmployee = "Contract Based";
        public readonly string departmentName;

        //constructor: executes every time when we create an object for the Employee class.
        public Employee()
        {
            departmentName = "Finance Department"; 
        }

    }
}
