using System;
using System.Security.Cryptography.X509Certificates;


public class Reflection : Activity
{
    private List<string> _randomPrompts;
    private List<string> _randomQuestions;

    public Reflection() : base(
        "Reflection Activity", 
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. ")
    {
        _randomPrompts = new List<string>()
        {
            "Think of a time when you stood up for someone else. ",
            "Think of a time when you did something really difficult. ",
            "Think of a time when you helped someone in need. ",
            "Think of a time when you did something truly selfless. "
        };

        _randomQuestions = new List<string>()
        {
            "Why was this experience meaningful to you? ",
            "Have you ever done anything like this before? ",
            "How did you get started? ",
            "How did you feel when it was complete? ", 
            "What made this time different than other times when you were not as successful? ",
            "What is your favorite thing about this experience? ",
            "What could you learn from this experience that applies to other situations? ",
            "What did you learn about yourself through this experience? ",
            "How can you keep this experience in mind in the future? "
        };
    }

    public void Reflect()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("Get ready ...");
        ShowAnimation();
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();

        Random random = new Random();
        string prompt = _randomPrompts[random.Next(_randomPrompts.Count)];
        Console.WriteLine($"--- {prompt} --- ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press ENTER to continue. ");
        string answer = Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience. ");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Random random1 = new Random();
            string questions = _randomQuestions[random1.Next(_randomQuestions.Count)];
            Console.Write($"> {questions}"); 
            ShowAnimation();
            Console.WriteLine();

            if (DateTime.Now > endTime)
            {
                break;
            }
        }

        DisplayFinishingMessage();
    }
}