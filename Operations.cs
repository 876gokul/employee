/*
Title: Main program
description: This file includes the CRUD operations for the EmployeeList
Author: Gokul
reviewed by:
last edited : 10/12/2021
*/

using System;
using System.Collections.Generic;

namespace employee
{
    class Operations
    {
        static DateTime DateOfBirth = new DateTime();
        static DateTime DateOfJoining = new DateTime();
        
        static string Id="", Name="", Mobile="", Dateofbirth="", Dateofjoining ="", Sex="", Salary="",Email="",prof1="",prof2="";

        static string[] SubStrings = {"id","name","mobile","DOB","DOJ","sex","salary","email"}; 
        static string[] SubStrings1 = {"id","name","mobile","DOB","DOJ","sex","salary","email","prof1","prof2"}; 


        static int Index = 0;
        static int ValidSalary = 0;

        static bool ToContinue = false;

        // Creation of list Employee type
        static List<Employee> EmployeeList = new List<Employee>();
        static void DisplayMessage(string subString, int index){

        }

        static bool GetAndValidateId(){
            bool Result = false;
            Id = Console.ReadLine();
            Result = Validate.Id(Id);
            return Result;
        }
        static bool GetAndValidateName(){
            bool Result = false;
            Name = Console.ReadLine();
            Result = Validate.Name(Name);
            return Result;
        }
        static bool GetAndValidateMobile(){
            bool Result = false;
            Mobile = Console.ReadLine();
            Result = Validate.Mobile(Mobile);
            return Result;
        }
        static bool GetAndValidateDOB(){
            bool Result = false;
            Dateofbirth = Console.ReadLine();
            Result = Validate.DOB(Dateofbirth, ref DateOfBirth);
            return Result;
        }
        static bool GetAndValidateDOJ(){
            bool Result = false;
            Dateofjoining = Console.ReadLine();
            Result = Validate.DOJ(Dateofjoining, ref DateOfJoining, ref DateOfBirth);
            return Result;
        }
        static bool GetAndValidateSex(){
            bool Result = false;
            Sex = Console.ReadLine();
            Result = Validate.Sex(Sex);
            return Result;
        }
        static bool GetAndValidateSalary(){
            bool Result = false;
            Salary = Console.ReadLine();
            Result = Validate.Salary(Salary, ref ValidSalary);
            return Result;
        }
        static bool GetAndValidateEmail(){
            bool Result = false;
            Email = Console.ReadLine();
            Result = Validate.Email(Email);
            return Result;
        }

        static bool GetUserInput(string subString, int index){
            bool Result = false;
            Console.WriteLine($"enter the employee {subString}");
            switch(index){
                case 0:
                    Result = GetAndValidateId();
                break;
                case 1:
                    Result = GetAndValidateName();
                break;
                case 2:
                    Result = GetAndValidateMobile();
                break;
                case 3:
                    Result = GetAndValidateDOB();
                break;
                case 4:
                    Result = GetAndValidateDOJ();
                break;
                case 5:
                    Result = GetAndValidateSex();
                break;
                case 6:
                    Result = GetAndValidateSalary();
                break;
                case 7:
                    Result = GetAndValidateEmail();
                break;
                case 8:
                    Console.WriteLine("Enter the prof1");
                    prof1 = Console.ReadLine();
                    Result = true;
                break;
                case 9:
                    Console.WriteLine("Enter the prof2");
                    prof2 = Console.ReadLine();
                    Result = true;
                break;
            }
            return Result;
        }

        public static void Create(){    
            Console.WriteLine("\nPlease enter the following details\n");

            foreach(var SubString in SubStrings){    
                ToContinue = GetUserInput(SubString, Index);
                validate:
                if(!ToContinue){
                    Console.Write("\nSorry re ");
                    ToContinue = GetUserInput(SubString, Index);
                    goto validate;
                }
                Index++;
            }
            
            Console.WriteLine("\nThank you for the deatils");
            
            // creating a employee object 
            Employee e = new Employee(Id, Name, DateOfBirth, DateOfJoining, Mobile, Sex, ValidSalary, Email);
            // adding it to the employee object list
            EmployeeList.Add(e);
            Index=0;
        }

        public static void CreateProgrammer(){
            foreach(var SubString in SubStrings1){    
                ToContinue = GetUserInput(SubString, Index);
                validate:
                if(!ToContinue){
                    Console.Write("\nSorry re ");
                    ToContinue = GetUserInput(SubString, Index);
                    goto validate;
                }
                Index++;
            }
            Console.WriteLine("\nThank you for the deatils");

            Programmer p = new Programmer(Id, Name, DateOfBirth, DateOfJoining, Mobile, Sex, ValidSalary, Email, prof1, prof2);
            EmployeeList.Add(p);
            Index=0;
            
        }

        public static void Read(){
            Console.WriteLine("\nPlease enter the employee id : ");
            Id = Console.ReadLine();
            bool Result = Validate.Id(Id);
            if(Result){
                foreach (var Employee in EmployeeList)
                {
                    if(Employee.Id == Id){
                        Employee.displayData();
                    }
                }
            }
        }
        
        public static void Delete(){
            Console.WriteLine("\nPlease enter the employee id : ");
            Id = Console.ReadLine();
            bool Result = Validate.Id(Id);
            bool isRemoved = false;
            if(Result){
                foreach (var Employee in EmployeeList)
                {
                    if(Employee.Id == Id){
                        EmployeeList.Remove(Employee);
                        isRemoved = true;
                        break;
                    }
                }
            }
            if(isRemoved){
                Console.WriteLine("\nEmployee was removed successfully");
            }else{
                Console.WriteLine("\nEmployee was not found");
            }
        }

        public static void Update(){
            Console.WriteLine("\nPlease enter the employee id : ");
            Id = Console.ReadLine();
            string choice;
            bool isUpdated = false;
            bool Result = Validate.Id(Id);
            bool Flag = true;
            if(Result){
                foreach (var Employee in EmployeeList)
                {
                    if(Employee.Id == Id){
                        isUpdated = true;
                        do{
                            Console.WriteLine("Choose what you want to update");
                            Console.WriteLine("1.Update Name");
                            Console.WriteLine("2.Update Mobile");
                            Console.WriteLine("3.Update Date Of Birth");
                            Console.WriteLine("4.Update Date Of Joining");
                            Console.WriteLine("5.Update Sex");
                            Console.WriteLine("6.Update Salary");
                            Console.WriteLine("7.Exit");
                            choice = Console.ReadLine();
                            switch (choice)
                            {
                                case "1":
                                Name:
                                Console.WriteLine("enter the Name : ");
                                Result = GetAndValidateName();
                                if(!Result){
                                    Console.Write("\nSorry re ");
                                    goto Name;
                                }else{
                                    Employee.SetName(Name);
                                }
                                break;

                                case "2":
                                Mobile:
                                Console.WriteLine("enter the Mobile : ");
                                Result = GetAndValidateMobile();
                                if(!Result){
                                    Console.Write("\nSorry re ");
                                    goto Mobile;
                                }else{
                                    Employee.SetMobile(Mobile);
                                }
                                break;

                                case "3":
                                DOB:
                                Console.WriteLine("enter the Date Of Birth : ");
                                Result = GetAndValidateDOB();
                                if(!Result){
                                    Console.Write("\nSorry re ");
                                    goto DOB;
                                }else{
                                    Employee.SetDateOfBirth(DateOfBirth);
                                }
                                break;

                                case "4":
                                DOJ:
                                Console.WriteLine("enter the Date of Joining : ");
                                Result = GetAndValidateDOJ();
                                if(!Result){
                                    Console.Write("\nSorry re ");
                                    goto DOJ;
                                }else{
                                    Employee.SetDateOfJoining(DateOfJoining);
                                }
                                break;

                                case "5": 
                                Sex:
                                Console.WriteLine("enter the Sex : ");
                                Result = GetAndValidateSex();
                                if(!Result){
                                    Console.Write("\nSorry re ");
                                    goto Sex;
                                }else{
                                    Employee.SetSex(Sex);
                                }
                                break;
                                
                                case "6": 
                                Salary:
                                Console.WriteLine("enter the Salary : ");
                                Result = GetAndValidateSalary();
                                if(!Result){
                                    Console.Write("\nSorry re ");
                                    goto Salary;
                                }else{
                                    Employee.SetSalary(ValidSalary);
                                }
                                break;

                                case "7":
                                Flag = false;
                                break;

                                default: Console.WriteLine("Enter a vaild option between 1 and 7");
                                break;

                            }
                        }while(Flag);
                    }
                }
                if(isUpdated){
                    Console.WriteLine("\nThe Employee was updated successfully");
                }else{
                    Console.WriteLine("\nThe Employee was not found");
                }
            }
        }   

        public static void DisplayAll(){
            foreach(var Employee in EmployeeList){
                Employee.displayData(Employee.GetId());
                Console.WriteLine();
            }
        }  

        public static void Run(){
            string Ch;
            bool Flag = true;
            string Operation;

            do{
                Console.WriteLine("\nWelcome to employee application");
                Console.WriteLine("choose a opeartion");
                Console.WriteLine("1.Create a employee");
                Console.WriteLine("2.Read or Display a employee");
                Console.WriteLine("3.Update a Employee");
                Console.WriteLine("4.Delete a Employee");
                Console.WriteLine("5.Display all Employee");
                Console.WriteLine("6.Create a programmer employee");
                Console.WriteLine("7.Exit");
                Operation = Console.ReadLine();
                switch(Operation){
                    case "1": 
                        Create();
                        Console.WriteLine("\nThe employee was created successfully\n");
                    break;
                    case "2": 
                        Read();
                    break;
                    case "3": 
                        Update();
                    break;
                    case "4": 
                        Delete();
                    break;
                    case "5":
                        DisplayAll();
                    break;
                    case "6":
                        CreateProgrammer();
                    break;
                    case "7":
                        return;
                    default: 
                        Console.WriteLine("\nEnter a valid choice");
                    break;
                }
                Console.WriteLine("press c to continue");
                Ch = Console.ReadLine();
                if(Ch == "c" || Ch == "C"){
                    Flag  = true;
                }else{
                    Flag = false;
                }
            }while(Flag);
        }

    }
}