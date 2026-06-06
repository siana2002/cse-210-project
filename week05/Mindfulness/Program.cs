using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 4)

        {
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Breathing breathing = new Breathing();
                breathing.Timer();
            }

            else if (choice == 2)
            {
                Reflection reflection = new Reflection();
                reflection.Reflect();
            }

            else if (choice == 3)
            {
                Listing listing = new Listing();
                listing.List();
            }

            else if (choice == 4)
            {
                break;
            }

            else
            {
                Console.WriteLine("Invalid Choice. Try again. ");
            }
        }
    }
}