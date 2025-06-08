using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("WELCOME!");
        string name;
        GetInput(out name);

        Console.WriteLine("Enter name again? (y/n): ");
        string choice = Console.ReadLine();

        if (choice.ToLower() != "y")
        {
            return;
        }
        GetInput(out name);
    }

    static void GetInput(out string name)
    {
        Console.WriteLine("Enter name:");
        name = Console.ReadLine();

        Console.WriteLine("Hello, " + name + "!");
    }
}
