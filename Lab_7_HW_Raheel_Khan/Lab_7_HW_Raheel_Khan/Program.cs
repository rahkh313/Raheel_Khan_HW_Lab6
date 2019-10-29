using System;
using System.Text.RegularExpressions;

namespace Lab_7_HW_Raheel_Khan
{
    class Program
    {

        static void Main(string[] args)
        {           
            Console.WriteLine("Please enter a valid Name:");
            string nameAnswer = Console.ReadLine();
            VerifyName(nameAnswer);

            Console.WriteLine("Please enter a valid email:");
            string emailAnswer = Console.ReadLine();
            VerifyEmail(emailAnswer);

            Console.WriteLine("Please enter a valid phone number:");
            string phoneAnswer = Console.ReadLine();
            VerifyPhone(phoneAnswer);

            Console.WriteLine("Please enter a valid date:");
            string dateAnswer = Console.ReadLine();
            VerifyDate(dateAnswer);
        }        
        public static void VerifyName(string nameAnswer)
        {
            if (Regex.IsMatch(nameAnswer, @"(^[A-Z][a-z]{1,29}$)"))
            {
                Console.WriteLine("Name is Valid!");
            }
            else
            {
                Console.WriteLine("Sorry, name is not valid!");
            }
        }
        public static void VerifyEmail(string emailAnswer)
        {
            if (Regex.IsMatch(emailAnswer, @"([0-9A-Za-z]{5,30}@{1}[0-9A-Za-z]{5,10}\.{1}[0-9A-Za-z]{2,3}$)"))  
            {
                Console.WriteLine("Email is Valid!");
            }
            else
            {
                Console.WriteLine("Sorry, email is not valid!");
            }
        }
        public static void VerifyPhone(string phoneAnswer)
        {
            if (Regex.IsMatch(phoneAnswer, @"([0-9]{3}[-][0-9]{3}[-][1-9]{4})"))  
            {
                Console.WriteLine("Phone is Valid!");
            }
            else
            {
                Console.WriteLine("Sorry, Phone is not valid!");
            }
        }
        public static void VerifyDate(string dateAnswer)
        {
            if (Regex.IsMatch(dateAnswer, @"^([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}$"))  
            {
                Console.WriteLine("Date is Valid!");
            }
            else
            {
                Console.WriteLine("Sorry, Date is not valid!");
            }
        }          
    }
}


