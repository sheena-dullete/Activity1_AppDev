using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello! Tell us about yourself.");
        string name;
        GetInput(out name);
    }

    static void GetInput(out string name)
    {
        Console.WriteLine("\nEnter your name: ");
        name = Console.ReadLine() ?? "Anonymous";

        Console.WriteLine("Hello, " + name + "!");
    }
}
