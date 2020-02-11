using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WarrenConsoleApp
{
    public class Program 
    {
        private static readonly ChallengesRepository ChallengesRepository = new ChallengesRepository();


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Warren's C# Skills Lab");
            ChallengesRepository.LoadData();
            WelcomeMenu();
            
        }


        static void WelcomeMenu()
        {
            Console.WriteLine("1) Multiples of 3 & 5");
            Console.WriteLine("2) Even Fibonacci numbers");
            Console.WriteLine("3) Largest prime factor");
            Console.WriteLine("4) Largest palindrome product");
            Console.WriteLine("5) Smallest multiple");
            Console.WriteLine("6) Exit \n");
            Console.WriteLine("Select a number from the list above");

            ChallengesRepository.UserOption();
        }

        
    }

}