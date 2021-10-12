/*
Title: Main program
description: This file includes the CRUD operations for the employeeList
Author: Gokul
Created by: Gokul
reviewed by:
last edited : 10/12/2021
*/

using System;
using System.Collections.Generic;

namespace employee
{
    class Program
    {
        static void Main(string[] args)
        {
            string id="",name="",mobile="",dob="",doj ="",sex="",salary="";

            string[] subStrings = {"id","name","mobile","DOB","DOJ","sex","salary"}; 

            DateTime DateOfBirth = new DateTime();
            DateTime DateOfJoining = new DateTime();

            int index = 0;
            int validSalary = 0;

            bool toContinue = false;

            // Creation of list Employee type
            List<Employee> employeeList = new List<Employee>();

            bool getUserInput(string subString, int index){
                bool result = false;
                Console.WriteLine($"enter the employee {subString}");
                switch(index){
                    case 0:
                        id = Console.ReadLine();
                        result = Validate.validateId(id);
                    break;
                    case 1:
                        name = Console.ReadLine();
                        result = Validate.validateName(name);
                    break;
                    case 2:
                        mobile = Console.ReadLine();
                        result = Validate.validateMobile(mobile);
                    break;
                    case 3:
                        dob = Console.ReadLine();
                        result = Validate.validateDOB(dob, ref DateOfBirth);
                    break;
                    case 4:
                        doj = Console.ReadLine();
                        result = Validate.validateDOJ(doj, ref DateOfJoining, ref DateOfBirth);
                    break;
                    case 5:
                        sex = Console.ReadLine();
                        result = Validate.validateSex(sex);
                    break;
                    case 6:
                        salary = Console.ReadLine();
                        result = Validate.validateSalary(salary, ref validSalary);
                    break;
                }
                return result;
            }

            void create(){    
                Console.WriteLine("Please enter the following details\n");

                foreach(var str in subStrings){    
                    toContinue = getUserInput(str, index);
                    validate:
                    if(!toContinue){
                        Console.Write("Sorry re ");
                        toContinue = getUserInput(str,index);
                        goto validate;
                    }
                    index++;
                }
                
                Console.WriteLine("\nThank you for the deatils");
               
                // creating a employee object 
                Employee e = new Employee(id, name, DateOfBirth, DateOfJoining, mobile, sex, validSalary);
                // adding it to the employee object list
                employeeList.Add(e);
                index=0;
            }

            void read(){
                Console.WriteLine("Please enter the employee id : ");
                id = Console.ReadLine();
                bool result = Validate.validateId(id);
                if(result){
                    foreach (var employee in employeeList)
                    {
                        if(employee.id == id){
                            employee.displayData();
                        }
                    }
                }
            }
            
            void delete(){
                Console.WriteLine("Please enter the employee id : ");
                id = Console.ReadLine();
                bool result = Validate.validateId(id);
                bool isRemoved = false;
                if(result){
                    foreach (var employee in employeeList)
                    {
                        if(employee.id == id){
                            employeeList.Remove(employee);
                            break;
                        }
                    }
                    if(isRemoved){
                        Console.WriteLine("Employee was removed successfully");
                    }else{
                        Console.WriteLine("Employee was not found");
                    }
                }
            }

            void update(){
                Console.WriteLine("Please enter the employee id : ");
                id = Console.ReadLine();
                string name;
                string mobile;
                bool isUpdated = false;
                bool result = Validate.validateId(id);
                if(result){
                    foreach (var employee in employeeList)
                    {
                        if(employee.id == id){
                            getName:
                            Console.WriteLine("enter the employee name");
                            name = Console.ReadLine();
                            result = Validate.validateName(name);
                            if(!result){
                                Console.Write("Sorry re ");
                                goto getName; 
                            }else{
                                employee.setName(name);
                            }
                            getmobile:
                            Console.WriteLine("enter the employee mobile");
                            mobile = Console.ReadLine();
                            result = Validate.validateMobile(mobile);
                            if(!result){
                                Console.Write("Sorry re ");
                                goto getmobile; 
                            }else{
                                employee.setMobile(mobile);
                            }
                            break;
                        }
                    }
                    if(isUpdated){
                        Console.WriteLine("Employee was removed successfully");
                    }else{
                        Console.WriteLine("Employee was not found");
                    }
                }
            }     

            void run(){
                string ch;
                bool flag = true;
                string operation;

                do{
                    Console.WriteLine("Welcome to employee application");
                    Console.WriteLine("choose a opeartion");
                    Console.WriteLine("1.Create a employee");
                    Console.WriteLine("2.Read or Display a employee");
                    Console.WriteLine("3.Update a Employee");
                    Console.WriteLine("4.Delete a Employee");
                    operation = Console.ReadLine();
                    switch(operation){
                        case "1": 
                            create();
                            Console.WriteLine("The employee was created successfully\n");
                        break;
                        case "2": 
                            read();
                        break;
                        case "3": 
                            update();
                            Console.WriteLine("The employee was updated successfully\n");
                        break;
                        case "4": 
                            delete();
                            Console.WriteLine("The employee was removed successfully\n");
                        break;
                        default: 
                            Console.WriteLine("Enter a valid choice");
                        break;
                    }
                    Console.WriteLine("press c to continue");
                    ch = Console.ReadLine();
                    if(ch == "c" || ch == "C"){
                        flag  = true;
                    }else{
                        flag = false;
                    }
                }while(flag);
            }

            run();

        }
    }
}
