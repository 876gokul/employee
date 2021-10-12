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
        
        static string Id="", Name="", Mobile="", Dateofbirth="", Dateofjoining ="", Sex="", Salary="";

        static string[] SubStrings = {"id","name","mobile","DOB","DOJ","sex","salary"}; 


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
            Employee e = new Employee(Id, Name, DateOfBirth, DateOfJoining, Mobile, Sex, ValidSalary);
            // adding it to the employee object list
            EmployeeList.Add(e);
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
                Console.WriteLine("Employee was removed successfully");
            }else{
                Console.WriteLine("Employee was not found");
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
                        do{
                            Console.WriteLine("Choose what you want to update");
                            Console.WriteLine("1.Update Name");
                            Console.WriteLine("2.Update Mobile");
                            Console.WriteLine("3.Update Date Of Birth");
                            Console.WriteLine("4.Update Date Of Joining");
                            Console.WriteLine("5.Update Sex");
                            Console.WriteLine("6.Update Salary");
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
                                    Employee.SetDateOfBirth(DOB);
                                }
                                break;

                                case "4":
                                DOJ:
                                Console.WriteLine("enter the Date of Joining : ");
                                Result = GetAndValidateDOJ();
                                
                            }
                        }while(Flag)
                    }
                }
                if(isUpdated){
                    Console.WriteLine("Employee was updated successfully");
                }else{
                    Console.WriteLine("Employee was not found");
                }
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
                Console.WriteLine("5.Exit");
                Operation = Console.ReadLine();
                switch(Operation){
                    case "1": 
                        Create();
                        Console.WriteLine("The employee was created successfully\n");
                    break;
                    case "2": 
                        Read();
                    break;
                    case "3": 
                        Update();
                        Console.WriteLine("The employee was updated successfully\n");
                    break;
                    case "4": 
                        Delete();
                        Console.WriteLine("The employee was removed successfully\n");
                    break;
                    case "5":
                        return;
                    default: 
                        Console.WriteLine("Enter a valid choice");
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