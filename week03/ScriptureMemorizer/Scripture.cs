using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {

    }

    public string GetDisplayText()
    {
        string scriptureText = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            scriptureText += word.GetText() + " ";
        }

        return scriptureText.TrimEnd();
    }
    
    public bool IsCompletelyHidden()
    {
        
    }
}