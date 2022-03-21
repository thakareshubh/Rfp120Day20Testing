using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Program
    {
        
        public string UserChecker(string email, string password)
        {
            if (email == "shubhamthakare721@gmail.com" && password == "12345678")
            {
                return " Logging Succesfull";
            }
            else
            {
                return "Entered Invalid Details";
            }
        }
        public string AgeChecker(int age)
        {
            if (age >= 18)
            {
                return "Welcome";
            }
            else
            {
                return "Invalid Age";
            }
           
        }
        static void Main(string[] args)
        {   
            Console.WriteLine("User Registration Problem");
        }
    }
}
