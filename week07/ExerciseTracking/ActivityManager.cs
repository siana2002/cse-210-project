using System;
using System.Diagnostics;

public class ActivityManager
{
    private List<Activity> _activity;
    
    public ActivityManager()
    {
        _activity = new List<Activity>();
    }
    
    public void Start()
    {
        Console.Clear();
        Activity running = new Running("03 Nov 2022", 30, 3);
        Activity running1 = new Running("04 Nov 2022", 50, 5);
        _activity.Add(running);
        _activity.Add(running1);

        Activity cycling = new Cycling("05 Nov 2023", 20, 2);
        Activity cycling1 = new Cycling("06 Nov 2023", 40, 4);
        _activity.Add(cycling);
        _activity.Add(cycling1);

        Activity swimming = new Swimming("10 Nov 2024", 25, 6);
        Activity swimming1 = new Swimming("12 Nov 2024", 15, 3);
        _activity.Add(swimming);
        _activity.Add(swimming1);

        foreach (Activity activity in _activity)
        {
            string activityDetails = activity.GetSummary();
            Console.WriteLine(activityDetails);
            Console.WriteLine();
        }
    }
}