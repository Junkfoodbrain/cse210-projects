using System.ComponentModel;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int Length)
    {
        _title = title;
        _author = author;
        _length = Length;
        _comments = new List<Comment>();
    }

    public List<Comment> getComments()
    {
        return _comments;
    }
    
    public string getTitle()
    {
        return _title;
    }
    public string getAuthor()
    {
        return _author;
    }
    public int getLength()
    {
        return _length;
    }
    public void addComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int getNumberOfComments()
    {
        return _comments.Count;
    }
    public void setTitle(string title)
    {
        _title = title;
    }
    public void setAuthor(string author)
    {
        _author = author;
    }
    public void setLength(int length)
    {
        _length = length;
    }
}