using System;

public class AgeCalculator
{
    static void Main(string[] args)
    {
        // Ask for name
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        // Ask for age
        Console.Write("Please enter your age: ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            // Call the testable method
            (int yearsTo100, int yearAt100) = CalculateAgeTo100(age);
            // Display the personalized message
            Console.WriteLine($"\nHello {name}!");
            Console.WriteLine($"You will be 100 years old in {yearsTo100} years, in the year {yearAt100}.");
        }
        else
        {
            Console.WriteLine("Invalid age entered. Please enter a valid number.");
        }
        // Keep console window open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    public static (int yearsTo100, int yearAt100) CalculateAgeTo100(int age)
    {
        int yearsTo100 = 100 - age;
        int yearAt100 = DateTime.Now.Year + yearsTo100;
        return (yearsTo100, yearAt100);
    }
}