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

    class Validate{

        static string[] Formats= {"M/dd/yyyy","MM/dd/yyyy","M/d/yyyy","MM/d/yyyy","d/MM/yyyy","dd/MM/yyyy","dd/M/yyyy","d/M/yyyy","yyyy/M/d","yyyy/MM/d","yyyy/M/dd","yyyy/M/d","M-dd-yyyy","MM-dd-yyyy","M-d-yyyy","MM-d-yyyy","d-MM-yyyy","dd-MM-yyyy","dd-M-yyyy","d-M-yyyy","yyyy-M-d","yyyy-MM-d","yyyy-M-dd","yyyy-M-d"};

        public static bool Id(string ID){
            bool Result = false;
            Regex Pattern = new Regex(@"^(ace|ACE)[0-9]{1,4}$");
            Result = Pattern.IsMatch(ID);
            if(!Result){
                Console.WriteLine("\nThe Id Must be in the following format : ace or ACE followed by a number");
            }
            return Result;
        }

        public static bool Name(string NAME){
            bool Result = false;
            Regex Pattern = new Regex(@"^[a-zA-z ]{3,}$");
            Result = Pattern.IsMatch(NAME);
            if(!Result){
                Console.WriteLine("\nThe Name Must not contain numbers or special characters");
            }
            return Result;
        }

        public static bool Mobile(string MOBILE){
            bool Result = false;
            Regex Pattern = new Regex(@"^[6-9][0-9]{9}$");
            Result = Pattern.IsMatch(MOBILE);
            if(!Result){
                Console.WriteLine("\nThe Mobile Must begin with a number between 6 and 9 and should have exactly 10 digits");
            }
            return Result;
        }

        public static bool DOB(string DOB, ref DateTime DateOfBirth){
            bool Result = false;
            Result = DateTime.TryParseExact(DOB, Formats,new CultureInfo("en-US"),DateTimeStyles.None,out DateOfBirth);
            if((DateTime.Now.Year - DateOfBirth.Year) > 60 || (DateTime.Now.Year - DateOfBirth.Year) < 18){
                Console.WriteLine($"\nyour age is {DateTime.Now.Year - DateOfBirth.Year} Your age must be between 18 to 60 indorder to do work");
                Result = false;
            }
            return Result;
        }

        public static bool DOJ(string DOJ, ref DateTime DateOfJoining, ref DateTime DateOfBirth){
            bool Result = false;
            Result = DateTime.TryParseExact(DOJ, Formats,new CultureInfo("en-US"),DateTimeStyles.None,out DateOfJoining);
            if(Result){
                if((DateOfJoining.Year - DateOfBirth.Year) < 18){
                    Console.WriteLine($"\nyour age based on Date of Joining : {DateOfJoining.Year - DateOfBirth.Year} is less than 18, You must at least 18 years old inorder to work");
                    Result = false;
                }
                if((DateOfJoining.Year - DateOfBirth.Year) > 60){
                    Console.WriteLine($"\nyour age based on Date of Joining : {DateOfJoining.Year - DateOfBirth.Year} Your age must be between 18 to 60 indorder to do work");
                    Result = false;
                }
            }
            return Result;
        }

        public static bool Sex(string SEX){
            bool Result = false;
            Regex Pattern = new Regex(@"^(?:m|M|male|Male|f|F|female|Female)$");
            Result = Pattern.IsMatch(SEX);
            if(!Result){
                Console.WriteLine("\nyour sex Must be any one the following M or F or m or f or male or female or Male or Female");
            }
            return Result;
        }
        
        public static bool Salary(string SALARY, ref int ValidSalary){
            bool Result = false;
            Result = int.TryParse(SALARY, out ValidSalary); 
            if(Result){
                if(ValidSalary > 10000){
                    Console.WriteLine("\nThe salary must be less than 10,000");
                    return false;
                }else if(ValidSalary < 0){
                    Console.WriteLine("\nThe salary must be Greater than 0");
                    return false;
                }
            }
            return Result;
        }
    }
}