/*
Title: Validation
description: This class is  used to validate the data for the employee class
Author: Gokul
Created by: Gokul
reviewed by:
last edited : 12/10/2021
*/

using System;
using System.Text.RegularExpressions;
using System.Globalization;
namespace employee
{

    class Validate{

        static string[] formats= {"M/d/yyyy","MM/dd/yyyy","d/M/yyyy","dd/MM/yyyy","yyyy/MM/d","yyyy/MM/dd","yyyy/d/MM","yyyy/d/MM","yyyy/d/M","yyyy/dd/M"};

        public static bool validateId(string ID){
            bool result = false;
            Regex pattern = new Regex(@"^(ace|ACE)[0-9]{1,4}$");
            result = pattern.IsMatch(ID);
            return result;
        }

        public static bool validateName(string NAME){
            bool result = false;
            Regex pattern = new Regex(@"^[a-zA-z ]{3,}$");
            result = pattern.IsMatch(NAME);
            return result;
        }

        public static bool validateMobile(string MOBILE){
            bool result = false;
            Regex pattern = new Regex(@"^[6-9][0-9]{9}$");
            result = pattern.IsMatch(MOBILE);
            return result;
        }

        public static bool validateDOB(string DOB, ref DateTime DateOfBirth){
            bool result = false;
            result = DateTime.TryParseExact(DOB, formats,new CultureInfo("en-US"),DateTimeStyles.None,out DateOfBirth);
            if((DateTime.Now.Year - DateOfBirth.Year) < 18 || (DateTime.Now.Year - DateOfBirth.Year) > 60){
                result = false;
            }
            return result;
        }

        public static bool validateDOJ(string DOJ, ref DateTime DateOfJoining, ref DateTime DateOfBirth){
            bool result = false;
            result = DateTime.TryParseExact(DOJ, formats,new CultureInfo("en-US"),DateTimeStyles.None,out DateOfJoining);
            if(result){
                if((DateOfJoining.Year - DateOfBirth.Year) < 18){
                    result = false;
                }
            }
            return result;
        }

        public static bool validateSex(string SEX){
            bool result = false;
            Regex pattern = new Regex(@"^(?:m|M|male|Male|f|F|female|Female)$");
            result = pattern.IsMatch(SEX);
            return result;
        }
        
        public static bool validateSalary(string SALARY, ref int validSalary){
            bool result = false;
            result = int.TryParse(SALARY, out validSalary); 
            if(result){
                if(validSalary > 10000 || validSalary < 0){
                    return false;
                }
            }
            return result;
        }
    }
}