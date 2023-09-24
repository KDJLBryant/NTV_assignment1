using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{   
    class Program
    {
        static void Main(string[] args)
        {
            // Initialise variables
            List<int> numbers = new List<int>();
            int index = 0;
            bool loop = true;

            while (loop)
            {
                // Get user input
                Console.Write($"Number {index++}: ");
                string enteredNumber = Console.ReadLine();

                int parsedInt;

                // If not an empy value
                if (int.TryParse(enteredNumber, out parsedInt))
                {
                    numbers.Add(parsedInt);
                }

                // If an empty value
                else
                {
                    Console.WriteLine("\nEnded! Your list is list - ");

                    foreach (int i in numbers) 
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine($"Biggest = {numbers.Max()} / Smallest = {numbers.Min()}");
                    loop = false;
                }
            }
        }
    }

}

