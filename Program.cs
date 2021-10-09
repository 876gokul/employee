using System;

namespace employee
{
    class Program
    {
        static void Main(string[] args)
        {
            string id="",name="",mobile="",dob="",doj ="",sex="",salary="";
            string[] subStrings = {"id","name","mobile","DOB","DOJ","sex","salary"}; 
            int index = 0;

            void getUserInput(string subString, int index){
                Console.WriteLine($"enter the employee {subString}");
                switch(index){
                    case 0:id = Console.ReadLine();
                    break;
                    case 1:name = Console.ReadLine();
                    break;
                    case 2:mobile = Console.ReadLine();
                    break;
                    case 3:dob = Console.ReadLine();
                    break;
                    case 4:doj = Console.ReadLine();
                    break;
                    case 5:sex = Console.ReadLine();
                    break;
                    case 6:salary = Console.ReadLine();
                    break;
                }
            }

            void displayData(string subString, int index){
                switch(index){ 
                    case 0: Console.WriteLine($"Employee {subString} : {id}"); 
                    break;
                    case 1: Console.WriteLine($"Employee {subString} : {name}"); 
                    break;
                    case 2: Console.WriteLine($"Employee {subString} : {mobile}"); 
                    break;
                    case 3: Console.WriteLine($"Employee {subString} : {dob}"); 
                    break;
                    case 4: Console.WriteLine($"Employee {subString} : {doj}"); 
                    break;
                    case 5: Console.WriteLine($"Employee {subString} : {sex}"); 
                    break;
                    case 6: Console.WriteLine($"Employee {subString} : {salary}"); 
                    break;
                }
            }

            Console.WriteLine("Welcome to the Employee application, Please enter the following details\n");

            foreach(var str in subStrings){    
                getUserInput(str, index);
                index++;
            }
            
            Console.WriteLine("\nThank you for the deatils, Please check them");
            index = 0;
            foreach(var str in subStrings){    
                displayData(str, index);
                index++;
            }
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
