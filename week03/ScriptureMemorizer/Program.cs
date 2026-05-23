using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("AAA");

        string text = "If you love me keep my commandments";

        Reference reference = new Reference("John", 14, 15);
        Console.WriteLine(reference.GetDisplayText());

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("Press ENTER to continue or type quit to exit: ");
            string answer = Console.ReadLine();

            if (answer == "quit")
            {
                break;
            }
            scripture.HideRandomWords(1);

        }
    }
}