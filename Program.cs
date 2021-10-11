using System;
using System.Text.RegularExpressions;
using System.Globalization;

namespace employee
{
    class Program
    {
        static void Main(string[] args)
        {
            string id="",name="",mobile="",dob="",doj ="",sex="",salary="";

            string[] subStrings = {"id","name","mobile","DOB","DOJ","sex","salary"}; 
            string[] formats= {"M/d/yyyy","MM/dd/yyyy","d/M/yyyy","dd/MM/yyyy","yyyy/MM/d","yyyy/MM/dd","yyyy/d/MM","yyyy/d/MM","yyyy/d/M","yyyy/dd/M"};

            DateTime DateOfBirth = new DateTime();
            DateTime DateOfJoining = new DateTime();

            int index = 0;
            int validSalary = 0;

            bool toContinue = false;

            Regex pattern;

            bool validateId(string ID){
                bool result = false;
                pattern = new Regex(@"^(ace|ACE)[0-9]{1,4}$");
                result = pattern.IsMatch(ID);
                return result;
            }

            bool validateName(string NAME){
                bool result = false;
                pattern = new Regex(@"^[a-zA-z ]{3,}$");
                result = pattern.IsMatch(NAME);
                return result;
            }

            bool validateMobile(string MOBILE){
                bool result = false;
                pattern = new Regex(@"^[6-9][0-9]{9}$");
                result = pattern.IsMatch(MOBILE);
                return result;
            }

            bool validateDOB(string DOB){
                bool result = false;
                result = DateTime.TryParseExact(DOB, formats,new CultureInfo("en-US"),DateTimeStyles.None,out DateOfBirth);
                if((DateTime.Now.Year - DateOfBirth.Year) < 18){
                    result = false;
                }
                return result;
            }

            bool validateDOJ(string DOJ){
                bool result = false;
                result = DateTime.TryParseExact(DOJ, formats,new CultureInfo("en-US"),DateTimeStyles.None,out DateOfJoining);
                if((DateTime.Now.Year - DateOfJoining.Year) < 0 && (DateOfJoining.Year < DateOfBirth.Year)){
                    result = false;
                }
                return result;
            }

            bool validateSex(string SEX){
                bool result = false;
                pattern = new Regex(@"^(?:m|M|male|Male|f|F|female|Female)$");
                result = pattern.IsMatch(SEX);
                return result;
            }
            
            bool validateSalary(string SALARY){
                bool result = false;
                result = int.TryParse(SALARY, out validSalary); 
                return result;
            }

            bool getUserInput(string subString, int index){
                bool result = false;
                Console.WriteLine($"enter the employee {subString}");
                switch(index){
                    case 0:
                        id = Console.ReadLine();
                        result = validateId(id);
                    break;
                    case 1:
                        name = Console.ReadLine();
                        result = validateName(name);
                    break;
                    case 2:
                        mobile = Console.ReadLine();
                        result = validateMobile(mobile);
                    break;
                    case 3:
                        dob = Console.ReadLine();
                        result = validateDOB(dob);
                    break;
                    case 4:
                        doj = Console.ReadLine();
                        result = validateDOJ(doj);
                    break;
                    case 5:
                        sex = Console.ReadLine();
                        result = validateSex(sex);
                    break;
                    case 6:
                        salary = Console.ReadLine();
                        result = validateSalary(salary);
                    break;
                }
                return result;
            }

            void displayData(string subString, int index){
                switch(index){ 
                    case 0: Console.WriteLine($"Employee {subString} : {id}"); 
                    break;
                    case 1: Console.WriteLine($"Employee {subString} : {name}"); 
                    break;
                    case 2: Console.WriteLine($"Employee {subString} : {mobile}"); 
                    break;
                    case 3: Console.WriteLine($"Employee {subString} : " + "{0}",DateOfBirth.ToString("dd/MM/yyyy")); 
                    break;
                    case 4: Console.WriteLine($"Employee {subString} : " + "{0}",DateOfJoining.ToString("dd/MM/yyyy")); 
                    break;
                    case 5: Console.WriteLine($"Employee {subString} : {sex}"); 
                    break;
                    case 6: Console.WriteLine($"Employee {subString} : {salary}"); 
                    break;
                }
            }

            void run(){    
                Console.WriteLine("Welcome to the Employee application, Please enter the following details\n");

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
                
                Console.WriteLine("\nThank you for the deatils, Please check them");
                index = 0;
                foreach(var str in subStrings){    
                    displayData(str, index);
                    index++;
                }
                Console.WriteLine("press any key to exit");
                Console.ReadKey();
            }

            run();

        }
    }
}
