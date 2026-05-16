using System;
using System.Collections.Generic;
using System.IO;

public class PromptGenerator
{
    Random random = new Random();
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of your day?",
        "What did you learn today?",
        "Who did you help today?",
        "What made you smile today?",
        "What are you grateful for today?"
    };
    public string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}

   