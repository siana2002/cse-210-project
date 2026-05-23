using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _scripture = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] splitText = text.Split(' ');
        foreach (string word in splitText)
        {
            _scripture.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_scripture.Count);

            if (!_scripture[index].IsHidden())
            {
                _scripture[index].Hide();
                hiddenCount = hiddenCount + 1;
            }
        }
    }
    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " ";

        foreach (Word w in _scripture)
        {
            result = result + w.GetDisplayText() + " ";
        }

        return result;

    }
    public bool IsCompletelyHidden()
    {
        foreach (Word w in _scripture)
        {
            if (!w.IsHidden())
            {
                return false;
            }
            
        }
        return true;
    }
}