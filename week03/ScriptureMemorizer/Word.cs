public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string _text, bool _isHidden)
    {

    }

    public void Hide();

    public void Show();

    public bool IsHidden();

    public string GetText();


}