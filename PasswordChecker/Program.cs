using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker
{
    class Program
    {
        // main method
        static void Main(string[] args)
        {


            // call login
            Login();

            // prop the console
            Console.ReadKey();



        }
        // method to check password
        static bool CheckPassword(string pwd)
        {
            if (pwd == "Password") return true;
            return false;
        }
        // ask for password and check
        static void Login()
        {
            // ask the user for their password
            Console.Write("Please enter your password ");
            string pwd = Console.ReadLine();

            // check password
            bool isCorrectPWD = CheckPassword(pwd);

            if (isCorrectPWD)
            {
                Console.WriteLine("You can enter");
            }
            else
            {
                Console.WriteLine("You can get lost");
                Login();
            }
        }
    }
} 
