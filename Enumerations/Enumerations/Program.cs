using System;

enum Day
{
    Sunday = 1,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Program
{
    static void Main()
    {
        // Assigning an enum value
        Day today = Day.Monday;
        Console.WriteLine($"Today is: {today}");

        // Accessing enum value by integer
        Day tomorrow = (Day)3;  // 2 corresponds to Monday
        Console.WriteLine($"Tomorrow is: {tomorrow}");

        // Displaying all days of the week
        Console.WriteLine("\nDays of the Week:");
        foreach (Day day in Enum.GetValues(typeof(Day)))
        {
            Console.WriteLine($"{(int)day}. {day}");
        }
    }
}
