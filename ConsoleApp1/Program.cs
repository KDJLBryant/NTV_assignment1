using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{   
    public class WeatherData
    {
        public double Temp { get; set; }
        public int Humid { get; set; }
        public string Scale { get; set; }

        public WeatherData(double temp, int humid, string scale)
        {
            Temp = temp;
            Humid = humid;
            Scale = scale;
        }

        public bool CheckValidTemp()
        {
            if (Scale == "C")
            {
                if (Temp < -60 || Temp > 60)
                {
                    Console.WriteLine("This temperature is not valid!");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (Temp < -76 || Temp > 140)
                {
                    Console.WriteLine("This temperature is not valid!");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public bool CheckValidHumidity()
        {
            if (Humid < 0 || Humid > 100)
            {
                Console.WriteLine("This humidity is not valid!");
                return false;
            }
            else
            {
                return true;
            }
        }
        
        public double Convert()
        {
            if (Scale == "C")
            {
                Console.Write("C to F is - ");
                Temp = (Temp * 9 / 5) + 32;
                Scale = "F";
                return Temp;
            }
            else
            {
                Console.Write("F to C is - ");
                Temp = (Temp - 32) * 5 / 9;
                Scale = "C";
                return Temp;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // TASK 1 -----

            // Initialise variables
            List<int> numbers = new List<int>();
            int index = 0;
            bool loopOne = true;

            while (loopOne)
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
                    loopOne = false;
                }
            }
            // TASK 2 -----
            bool loopTwo = true;

            while (loopTwo)
            {
                Console.WriteLine("\nEnter Weather info - ");
                Console.Write("Enter temp Scale: ");
                string setScale = Console.ReadLine();
                Console.Write("Enter Temp: ");
                double setTemp = double.Parse(Console.ReadLine());
                Console.Write("Enter Humidity: ");
                int setHumid = int.Parse(Console.ReadLine());

                WeatherData weatherData = new WeatherData(setTemp, setHumid, setScale);
            }
        }
    }

}

