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
        public static readonly ChallengeRepository ChallengeRepository = new ChallengeRepository();


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Warren's C# Skills Lab");
            ChallengeRepository.LoadData();
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

            UserOption();
        }

        static void UserOption()
        {
            var userInput = Console.ReadLine();
            Int32.TryParse(userInput, out int userInputInt);

            switch (userInputInt)
            {
                case 1:
                    Console.WriteLine();
                    ChallengeRepository.ShowSolutionById(1);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine();
                    ChallengeRepository.ShowSolutionById(2);
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine();
                    ChallengeRepository.ShowSolutionById(3);
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine();
                    ChallengeRepository.ShowSolutionById(4);
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine();
                    ChallengeRepository.ShowSolutionById(5);
                    Console.ReadLine();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.Write("Select a number from the list above");
                    Console.ReadLine();
                    break;
            }
        }
    }

}