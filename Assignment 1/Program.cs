using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {


        static void Main()
        {
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
            string Input, tag; // holds input from user for menu 
            int[] numbers = new int[5];
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
                            Console.WriteLine(Input + " : is " + (client.CheckPrime(int.Parse(Input)) ? "" : "NOT ") + "a prime number");
                            break;
                        case 2:
                            Console.WriteLine("Enter Number");
                            Input = Console.ReadLine();
                            Console.WriteLine("Sum of " + Input + "'s digits are " + client.SumOfDigits(int.Parse(Input)));
                            break;
                        case 3:
                            Console.WriteLine("Enter String");
                            Input = Console.ReadLine();
                            Console.WriteLine("Reverse of " + Input + " is " + client.ReverseString(Input));
                            break;
                        case 4:
                            Console.WriteLine("Enter Tag");
                            tag = Console.ReadLine();
                            Console.WriteLine("Enter Content");
                            Input = Console.ReadLine();
                            Console.WriteLine("html is " + client.PrintHtml(tag, Input));
                            break;
                        case 5:
                            Console.WriteLine("Ascending? (y/n)");
                            Input = Console.ReadLine();
                            asc = Input.Equals("y");

                            Console.WriteLine("Enter numbers");
                            while (count < 5)
                            {
                                Input = Console.ReadLine();
                                numbers[count] = int.Parse(Input);
                                count++;
                            }

                            numbers = client.SortNumbers(numbers, asc);

                            StringBuilder sb = new StringBuilder("Numbers: ");
                            foreach (int item in numbers)
                            {
                                sb.Append(item).Append(", ");
                            }
                            Console.WriteLine(sb.ToString().Substring(0, sb.ToString().Length - 2));
                            count = 0;
                            numbers = new int[5];
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
