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

                Console.WriteLine("The user was created successfully, press any key");
                Console.ReadKey();
            }

            void read(){
                Console.WriteLine("Please enter the employee id : ");
                id = Console.ReadLine();
                bool result = Validate.validateId(id);
                if(result){
                    foreach (var employee in employeeList)
                    {
                        if(employee.id == id){
                            employee.displayData()
                        }
                    }
                }
            }
            
            void delete(){
                Console.WriteLine("Please enter the employee id : ");
                id = Console.ReadLine();
                bool result = Validate.validateId(id);
                if(result){
                    foreach (var employee in employeeList)
                    {
                        
                    }
                }
            }

            create();
            read();

            
        }
    }
}
