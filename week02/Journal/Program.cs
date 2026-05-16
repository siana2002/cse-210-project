using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Journal journal = new Journal();

        int choice = 0;
        while (choice != 5)
        {
            string prompt = promptGenerator.GetRandomPrompt();

            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. New entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Enter filename to save file to");
            Console.WriteLine("4. Enter filename to load file");
            Console.WriteLine("5. Quit");
            
            Console.Write("Choose your option: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine(prompt);
                
                Console.Write(" ");
                string response = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = dateText;
                entry._promptText = prompt;
                entry._entryText = response;

                Console.WriteLine();
                journal.AddEntry(entry);
            }

            else if (choice == 2)
            {
                Console.WriteLine();
                journal.DisplayAll();
                Console.WriteLine();
            }

            else if (choice == 3)
            {
                Console.WriteLine();
                Console.Write("Enter filename to save entry: ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);

                Console.WriteLine("Journal saved. ");
            }

            else if (choice == 4)
            {
                Console.WriteLine();
                Console.Write("Enter filename to load entry: ");
                string filename = Console.ReadLine();

                journal._entry.Clear();

                journal.LoadFromFile(filename);

                Console.WriteLine("File loaded. ");
            }

            else if (choice == 5)
            {
                Console.WriteLine("Goodbye");
            }

            else
            {
                Console.WriteLine("Invalid choice. ");
            }

            Console.WriteLine();
        }
    }   

}

    