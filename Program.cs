using System.Diagnostics;

namespace starter;

class Program
{
    public static void Main(string[] args)
    {
        // MARK: Setup
        Console.Write("How old are you? ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            // MARK: Result
            int presidents = CalculatePresidents(age);
            Console.WriteLine($"You've voted for {presidents} presidents!");
        }
        else
        {
            // MARK: Invalid input
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.ReadKey();
    }

    // MARK: Write your solution here
    public static int CalculatePresidents(int age)
    {
        if (age <= 18) return 0;
        int yearOver18 = age - 18;
        return ((yearOver18 - (yearOver18 % 4)) / 4);
    }
}