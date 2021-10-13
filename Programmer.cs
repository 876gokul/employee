/*
Title: Validation
description: This class is  used to validate the data for the employee class
Author: Gokul
reviewed by:
last edited : 12/10/2021
*/

using System;
using System.Text.RegularExpressions;
using System.Globalization;
namespace employee
{
    class Programmer:Employee{
        private string prof1;
        private string prof2;

        public string GetProf1() {
            return this.prof1;
        }

        public void SetProf1(string prof1) {
            this.prof1 = prof1;
        }

        public string GetProf2() {
            return this.prof2;
        }

        public void SetProf2(string prof2) {
            this.prof2 = prof2;
        }

        public Programmer(string Id, string Name, DateTime DateOfBirth, DateTime DateOfJoining, string Mobile, string Sex, int Salary,string Email, string prof1, string prof2): base (Id, Name, DateOfBirth, DateOfJoining, Mobile, Sex, Salary,Email){
            this.prof1 = prof1;
            this.prof2 = prof2;
        }

        public override void displayData(){
            Console.WriteLine($"Employee id : {this.Id}"); 
            Console.WriteLine($"Employee Name : {this.Name}"); 
            Console.WriteLine($"Employee Mobile : {this.Mobile}"); 
            Console.WriteLine($"Employee Date of Birth : " + "{0}",this.DateOfBirth.ToString("dd/MM/yyyy")); 
            Console.WriteLine($"Employee Date of Joining : " + "{0}",this.DateOfJoining.ToString("dd/MM/yyyy")); 
            Console.WriteLine($"Employee Sex : {this.Sex}"); 
            Console.WriteLine($"Employee Salary : {this.Salary}"); 
            Console.WriteLine($"Employee Email : {this.Email}"); 
            Console.WriteLine($"Employee prof1 : {this.prof1}"); 
            Console.WriteLine($"Employee prof2 : {this.prof2}"); 
        }
    }
}