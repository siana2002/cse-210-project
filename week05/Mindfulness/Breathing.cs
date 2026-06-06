using System;

public class Breathing : Activity
{
    public Breathing() : base(
        "Breathing Activity", 
        "This will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. ")
    {}

    public void Timer()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("Get ready ...");
        ShowAnimation();

        int elapsed = 0;

        while (elapsed < GetDuration())
        {
            Console.WriteLine();
            Console.Write($"Breathe in...");
            ShowCountdown(5);
            elapsed = elapsed + 5;

            if (elapsed > GetDuration())
            {
                break;
            }

            Console.WriteLine();
            Console.Write($"Breathe out...");
            ShowCountdown(5);
            elapsed = elapsed + 5;
            Console.WriteLine();
        }

        DisplayFinishingMessage();
    }

}