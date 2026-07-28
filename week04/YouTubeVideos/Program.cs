using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How To Fish", "Bob Line", 300);

        Comment comment1 = new Comment("Tim", "Great catch!");
        video1.addComment(comment1);

        Comment comment2 = new Comment("Jeff", "I caught a big one with your technique!");
        video1.addComment(comment2);

        Comment comment3 = new Comment("Jessie", "Now we'll never go home hungry!");
        video1.addComment(comment3);

        Comment comment4 = new Comment("Troy", "No more 'fish tales' now I'm bringing home the big ones!");
        video1.addComment(comment4);

        Console.WriteLine("Title: " + video1.getTitle());
        Console.WriteLine("Author: " + video1.getAuthor());
        Console.WriteLine("Length: " + video1.getLength() + " seconds");
        Console.WriteLine("Number of Comments: " + video1.getNumberOfComments());
        Console.WriteLine("Comments: ");

        foreach (Comment comment in video1.getComments())
        {
            Console.WriteLine(comment.getName() + ": " + comment.getText());

        }

        
    }
}