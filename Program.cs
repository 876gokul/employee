using System;

namespace employee
{
    class Program
    {
        static void Main(string[] args)
        {
            string id,name,mobile,dob,doj,sex,salary;
            Console.WriteLine("Welcome to the Employee application, Please enter the following details\n");
            Console.WriteLine("enter the employee id");
            id = Console.ReadLine();
            Console.WriteLine("enter the employee name");
            name = Console.ReadLine();
            Console.WriteLine("enter the employee mobile");
            mobile = Console.ReadLine();
            Console.WriteLine("enter the employee DOB");
            dob = Console.ReadLine();
            Console.WriteLine("enter the employee DOJ");
            doj = Console.ReadLine();
            Console.WriteLine("enter the employee sex");
            sex = Console.ReadLine();
            Console.WriteLine("enter the employee salary");
            salary = Console.ReadLine();

            Console.WriteLine("\nThank you for the deatils, Please check them");
            Console.WriteLine($"Employee id: {id}");
            Console.WriteLine($"Employee name: {name}");
            Console.WriteLine($"Employee mobile: {mobile}");
            Console.WriteLine($"Employee sex: {sex}");
            Console.WriteLine($"Employee dob: {dob}");
            Console.WriteLine($"Employee doj: {doj}");
            Console.WriteLine($"Employee salary: {salary}");
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
