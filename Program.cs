using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello! Tell us about yourself.");
        string name, course;
        GetInput(out name, out course);
        checkCourse(course);
        AskContinue();
    }

    static void GetInput(out string name, out string course)
    {
        Console.WriteLine("\nEnter your name: ");
        name = Console.ReadLine() ?? "Anonymous";

        Console.WriteLine("\nEnter your Course (BSCS, BSIT): ");
        course = Console.ReadLine() ?? "Undeclared";

        Console.WriteLine("Hello, " + name + "!");
    }

    static void checkCourse(string course)
    {
        if (course.ToLower() == "bscs")
        {
            Console.WriteLine("You're in Computer Science.");
        }
        else if (course.ToLower() == "bsit")
        {
            Console.WriteLine("You're in Information Technology.");
        }
        else
        {
            Console.WriteLine("Course Invalid");
        }
    }

    static void AskContinue()
    {
        Console.WriteLine("\nWould you like to input again? (y/n): ");
        string answer = (Console.ReadLine() ?? "").Trim().ToLower();

        if (answer == "y")
        {
            Console.Clear();
            Main();
        }
        else
        {
            Console.WriteLine("\nThank you! Program ended.");
        }
    }

}
