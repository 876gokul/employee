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
        public string Id;
        protected string Name;
        protected string Sex;
        protected string Mobile;
        protected string Email;
        protected int Salary;
        protected DateTime DateOfBirth;
        protected DateTime DateOfJoining;
        
        public string GetEmail() {
            return this.Email;
        }

        public void SetEmail(string Email) {
            this.Email = Email;
        }

        public string GetId()
        {
            return this.Id;
        }

        public void SetId(string Id)
        {
            this.Id = Id;
        }
        public string GetName()
        {
            return this.Name;
        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public string GetSex()
        {
            return this.Sex;
        }

        public void SetSex(string Sex)
        {
            this.Sex = Sex;
        }

        public string GetMobile()
        {
            return this.Mobile;
        }

        public void SetMobile(string Mobile)
        {
            this.Mobile = Mobile;
        }

        public int SetSalary()
        {
            return this.Salary;
        }

        public void SetSalary(int Salary)
        {
            this.Salary = Salary;
        }

        public DateTime GetDateOfBirth()
        {
            return this.DateOfBirth;
        }

        public void SetDateOfBirth(DateTime DateOfBirth)
        {
            this.DateOfBirth = DateOfBirth;
        }

        public DateTime GetDateOfJoining()
        {
            return this.DateOfJoining;
        }

        public void SetDateOfJoining(DateTime DateOfJoining)
        {
            this.DateOfJoining = DateOfJoining;
        }


        // constructor
        public Employee(string Id, string Name, DateTime DateOfBirth, DateTime DateOfJoining, string Mobile, string Sex, int Salary,string Email){
            this.Id = Id;
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
            this.DateOfJoining = DateOfJoining;
            this.Mobile = Mobile;
            this.Sex = Sex;
            this.Salary = Salary;
            this.Email = Email;
        }

        // data member
        public virtual void displayData(){
            Console.WriteLine($"Employee id : {this.Id}"); 
            Console.WriteLine($"Employee Name : {this.Name}"); 
            Console.WriteLine($"Employee Mobile : {this.Mobile}"); 
            Console.WriteLine($"Employee Date of Birth : " + "{0}",this.DateOfBirth.ToString("dd/MM/yyyy")); 
            Console.WriteLine($"Employee Date of Joining : " + "{0}",this.DateOfJoining.ToString("dd/MM/yyyy")); 
            Console.WriteLine($"Employee Sex : {this.Sex}"); 
            Console.WriteLine($"Employee Salary : {this.Salary}"); 
            Console.WriteLine($"Employee Email : {this.Email}"); 
        }
        
        public void displayData(string Id){
            Console.WriteLine($"Employee id : {Id}"); 
            Console.WriteLine($"Employee Name : {this.Name}"); 
            Console.WriteLine($"Employee Mobile : {this.Mobile}");
            Console.WriteLine($"Employee Salary : {this.Email}"); 
        }
    }
}