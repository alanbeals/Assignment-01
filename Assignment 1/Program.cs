using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        private static bool CheckPrime(int val)
        {
            // gets rid of negaives 0, 1 and 2
            // (2 only put here because 2 / 2 + 1 runs into the rule of cant be div by itself unlike larger numbers where adding 1 doesnt reach itself)
            if (val < 3) return false; 
            for (int i = 3; i < (val / 2) + 1; i++)
            {
                if (val % i == 0) return false;
            }
            return true;
        }
        private static int SumOfDigits(int val1)
        {
            int sum = 0;
            foreach (char c in val1.ToString())
            {
                sum += int.Parse(c.ToString());
            }

            return sum;
        }
        private static string ReverseString(string val)
        {
            string reverse = "";
            foreach (char c in val.ToString())
            {
                reverse = c + reverse;
            }
            return reverse;
        }
        private static string PrintHtml(string tag, string content)
        {
            return "<"+tag+">"+content+"</"+tag+">";
        }
        private static List<int> SortNumbers(List<int> numbers, bool ascending)
        {

            numbers.Sort();

            if (!ascending)
            {
                numbers.Reverse();
            }
            return numbers;
        }

        static void Main()
        {

            string Input, tag; // holds input from user for menu 
            List<int> numbers = new List<int>();
            bool Continue = true, asc = false;
            int Select, count = 0; // holds their choice from the menu


            while (Continue)
            {

                Console.WriteLine("WCF Assignment 1\n");
                Console.WriteLine("1. Prime number");
                Console.WriteLine("2. Sum of digits");
                Console.WriteLine("3. Reverse a string");
                Console.WriteLine("4. Print HTML tags");
                Console.WriteLine("5. Sort 5 numbers");
                Console.WriteLine("6. Exit\n");

                Console.WriteLine("Enter Your Choice");
                Input = Console.ReadLine();
                try
                {
                    Select = int.Parse(Input);

                    switch (Select)
                    {
                        case 1:
                            Console.WriteLine("Enter Number");
                            Input = Console.ReadLine();
                            Console.WriteLine(Input + " : is " + (CheckPrime(int.Parse(Input)) ? "" : "NOT ") + "a prime number");
                            break;
                        case 2:
                            Console.WriteLine("Enter Number");
                            Input = Console.ReadLine();
                            Console.WriteLine("Sum of " + Input + "'s digits are " + SumOfDigits(int.Parse(Input)));
                            break;
                        case 3:
                            Console.WriteLine("Enter String");
                            Input = Console.ReadLine();
                            Console.WriteLine("Reverse of " + Input + " is " + ReverseString(Input));
                            break;
                        case 4:
                            Console.WriteLine("Enter Tag");
                            tag = Console.ReadLine();
                            Console.WriteLine("Enter Content");
                            Input = Console.ReadLine();
                            Console.WriteLine("html is " + PrintHtml(tag, Input));
                            break;
                        case 5:
                            Console.WriteLine("Ascending? (y/n)");
                            Input = Console.ReadLine();
                            asc = Input.Equals("y");

                            Console.WriteLine("Enter numbers");
                            while (count < 5)
                            {
                                Input = Console.ReadLine();
                                numbers.Add(int.Parse(Input));
                                count++;
                            }
                            numbers = SortNumbers(numbers, asc);
                            StringBuilder sb = new StringBuilder("Numbers: ");
                            foreach (int item in numbers)
                            {
                                sb.Append(item).Append(", ");
                            }
                            Console.WriteLine(sb.ToString().Substring(0, sb.ToString().Length-2));
                            count = 0;
                            numbers = new List<int>();
                            break;
                        case 6:
                            Continue = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;

                    }
                }
                catch (FormatException e)
                {
                    // tells the user they entered something invalid
                    Console.WriteLine("\n{0}\n Invalid input try again\n", e);
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
