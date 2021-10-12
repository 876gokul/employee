/*
Title:Employee class
description: this class servers as a blueprint for the employee object
Author: Gokul
reviewed by:
last edited : 12/10/2020
*/

using System;
namespace employee
{
    class Employee
    {
        // data attributes
        public string id;
        private string name;
        private string sex;
        private string mobile;
        private int salary;
        private DateTime DOB;
        private DateTime DOJ;

         public string getId()
        {
            return this.id;
        }

        public void setId(string id)
        {
            this.id = id;
        }
        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getSex()
        {
            return this.sex;
        }

        public void setSex(string sex)
        {
            this.sex = sex;
        }

        public string getMobile()
        {
            return this.mobile;
        }

        public void setMobile(string mobile)
        {
            this.mobile = mobile;
        }

        public int getSalary()
        {
            return this.salary;
        }

        public void setSalary(int salary)
        {
            this.salary = salary;
        }

        public DateTime getDOB()
        {
            return this.DOB;
        }

        public void setDOB(DateTime DOB)
        {
            this.DOB = DOB;
        }

        public DateTime getDOJ()
        {
            return this.DOJ;
        }

        public void setDOJ(DateTime DOJ)
        {
            this.DOJ = DOJ;
        }


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