using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsAndIfElseConsoleApp
{
    internal class ifElseMethods
    {
        public static void Run()
        {
            Console.Clear();
            string selectedOption = GetUserChoice("Please select an option:");
            ExecuteOption(selectedOption);
            
        }

        static string GetUserChoice(string question)
        {
            ConsoleKeyInfo key; // lagre key press
            int cursorPosition = 0; // 0 = Assignment 1, 1 = Assignment 2 = Assignment 3
            string[] options = new string[] { "Assignment 1", "Assignment 2", "Assignment 3", "Exit" };

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to this Console app with If/Else methods");
                Console.WriteLine(question);

                for (int i = 0; i < options.Length; i++)
                {
                    if (i == cursorPosition)
                    {
                        Console.WriteLine($"> {options[i]}"); // Vise '>' på det valgte valge.
                    }
                    else
                    {
                        Console.WriteLine($"  {options[i]}");
                    }
                }

                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.UpArrow)
                {
                    cursorPosition = (cursorPosition - 1 + options.Length) % options.Length; // Beveg seg oppover, og rundt om nødvendig.
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    cursorPosition = (cursorPosition + 1) % options.Length; // Beveg seg nedover, og rundt om nødvendig.
                }
            } while (key.Key != ConsoleKey.Enter);

            return options[cursorPosition];
        }

        static void ExecuteOption(string option)
        {
            switch (option)
            {
                case "Assignment 1":
                    Console.Clear();
                    doAssignment1();
                    Run();
                    break;
                case "Assignment 2":
                    Console.Clear();
                    doAssignment2();
                    Run();
                    break;
                case "Assignment 3":
                    Console.Clear();
                    doAssignment3();
                    Run();
                    break;
                case "Exit":
                    Console.WriteLine("Exiting application...");
                    Environment.Exit(0); // stenger console vinduet
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }

        internal static void doAssignment1()
        {
            int firstNumber;
            int secondNumber;
            Console.WriteLine("Here we will check if the numbers are alike or not");
            Console.WriteLine("I will need 2 numbers from you");
            Console.WriteLine("First numbers please");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number please");
            secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Checking. . .");
            bool isAlike = CheckIfNumbersAreAlike(firstNumber, secondNumber);
            Console.WriteLine(isAlike ? "These numbers are alike" : "These numbers are NOT alike");
            Console.WriteLine("Press any key to return to option menu");
            Console.ReadKey();
        }

        internal static bool CheckIfNumbersAreAlike(int x, int y)
        {
            return x == y;
        }

        internal static void doAssignment2()
        {
            int firstNumber;
            int secondNumber;
            Console.WriteLine("Here we will give the total if numbers are alike, else we will multiply them");
            Console.WriteLine("I will need 2 numbers from you");
            Console.WriteLine("First numbers please");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number please");
            secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Checking. . .");
            int result = mulitplyIfUnlikeElseSum(firstNumber, secondNumber);
            Console.WriteLine($"The result became = {result}");
            Console.WriteLine("Press any key to return to option menu");
            Console.ReadKey();
        }

        private static int mulitplyIfUnlikeElseSum(int x, int y)
        {
            if (x == y) return x + y;
            return x * y;
        }

        internal static void doAssignment3()
        {
            int firstNumber;
            int secondNumber;
            Console.WriteLine("Here we will check if one the numbers or the sum of them is 30");
            Console.WriteLine("I will need 2 numbers from you");
            Console.WriteLine("First numbers please");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number please");
            secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Checking. . .");
            bool isNumberOrSum30 = CheckIfNumberOrSumIs30(firstNumber, secondNumber);
            Console.WriteLine(isNumberOrSum30 ? "Et tall eller summer er 30!" : "Tallene eller summen er ikke 30!");
            Console.WriteLine("Press any key to return to option menu");
            Console.ReadKey();
        }

        private static bool CheckIfNumberOrSumIs30(int x, int y)
        {
            return x == 30 || y == 30 || x + y == 30;
        }
    }
}
