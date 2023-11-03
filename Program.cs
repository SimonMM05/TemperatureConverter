using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! Welcome to this program. The program allows you to convert between Celsius and Fahrenheit.");
        while (true)
        {
            Console.WriteLine("Enter the temperature you would like to convert (or 'q' to quit):");
            string input = Console.ReadLine();

            if (input == "q" || input == "quit" || input == "exit")
            {
                break;
            }

            if (double.TryParse(input, out double temperature))
            {
                Console.WriteLine($"You entered: {temperature}");

                Console.WriteLine("Select conversion: (1) Celsius to Fahrenheit, (2) Fahrenheit to Celsius");
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    double convertedTemperature = 0.0;
                    string conversionType = "";

                    if (choice == 1)
                    {
                        convertedTemperature = (temperature * 9 / 5) + 32;
                        conversionType = "Celsius to Fahrenheit";
                    }
                    else if (choice == 2)
                    {
                        convertedTemperature = (temperature - 32) * 5 / 9;
                        conversionType = "Fahrenheit to Celsius";
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please select (1) or (2).");
                        continue;
                    }

                    Console.WriteLine($"Converted temperature in {conversionType}: {convertedTemperature}");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select (1) or (2).");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
