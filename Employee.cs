using System;
namespace employee
{
    class Employee
    {
        // data attributes
        public string id, name, sex, mobile;
        public int salary; 
        public DateTime DOB,DOJ;

        // constructor
        public Employee(string id, string name, DateTime DOB, DateTime DOJ, string mobile, string sex, int salary){
            this.id = id;
            this.name = name;
            this.DOB = DOB;
            this.DOJ = DOJ;
            this.mobile = mobile;
            this.sex = sex;
            this.salary = salary;
        }

        // data member
        public void displayData(){
            Console.WriteLine($"Employee id : {this.id}"); 
            Console.WriteLine($"Employee name : {this.name}"); 
            Console.WriteLine($"Employee mobile : {this.mobile}"); 
            Console.WriteLine($"Employee Date of Birth : " + "{0}",this.DOB.ToString("dd/MM/yyyy")); 
            Console.WriteLine($"Employee Date of Joining : " + "{0}",this.DOJ.ToString("dd/MM/yyyy")); 
            Console.WriteLine($"Employee sex : {this.sex}"); 
            Console.WriteLine($"Employee Salary : {this.salary}"); 
        }
    }
}