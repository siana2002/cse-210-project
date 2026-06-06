using System;

public class Listing : Activity
{
    private List<string> _randomPrompts;
    public Listing() : base(
        "Listing Activity", 
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area "
        )
    {
        _randomPrompts = new List<string>()
        {
            "Who are people that you appreciate? ",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week? ",
            "When have felt the Holy Ghost this month? ",
            "Who are some of your personal heroes? "
        };
    }

    public void List()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("Get ready...");
        ShowAnimation();
        Console.WriteLine();

        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine();

        Random random = new Random();
        string items = _randomPrompts[random.Next(_randomPrompts.Count)];
        Console.WriteLine($"--- {items} --- ");
        Console.WriteLine();

        Console.Write("You may begin in : ");
        ShowCountdown(4);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        int itemCount = 0;

        while (DateTime.Now < endTime)

        {
            Console.Write("> ");
            string answer = Console.ReadLine();
            itemCount = itemCount + 1;

            if (DateTime.Now > endTime)
            {
                break;
            }
        }

        Console.WriteLine($"You listed {itemCount} items! ");

        DisplayFinishingMessage();
    }
}