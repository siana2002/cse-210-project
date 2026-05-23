using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word()
    {
        _text = "faith";
    }

    public Word(string scripture)
    {
        _text = scripture;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string hidden = "";

            foreach (char c in _text)
            {
                if (char.IsLetter(c))
                {
                    hidden = hidden + "_";
                }

                else
                {
                    hidden = hidden + c;
                }
            }
            return hidden;
        }
        
        return _text;
    }
}