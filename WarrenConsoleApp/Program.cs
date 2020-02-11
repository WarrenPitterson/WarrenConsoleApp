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
            ChallengesRepository.WelcomeMenu();
        }
    }

}