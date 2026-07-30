using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        
        Video video1 = new Video("How To Fish", "Bob Line", 300);

        Comment comment1 = new Comment("Tim", "Great catch!");
        video1.addComment(comment1);
        Comment comment2 = new Comment("Jeff", "I caught a big one with your technique!");
        video1.addComment(comment2);
        Comment comment3 = new Comment("Jessie", "Now we'll never go home hungry!");
        video1.addComment(comment3);
        Comment comment4 = new Comment("Troy", "No more 'fish tales' now I'm bringing home the big ones!");
        video1.addComment(comment4);


        Video video2 = new Video("Gardening with Clara", "Clara Green", 450);

        Comment comment5 = new Comment("Jenny", "Love your gardening tips!");
        video2.addComment(comment5);
        Comment comment6 = new Comment("Mark", "You thought of everything in the raised bed plans!");
        video2.addComment(comment6);
        Comment comment7 = new Comment("Terry", "My garden is already thriving after making the changes from your video.");
        video2.addComment(comment7);
        

        Video video3 = new Video("Baking for Dummies", "Becky Baker", 600);

        Comment comment8 = new Comment("Stephanie", "Your recipes are so easy to follow!");
        video3.addComment(comment8);
        Comment comment9 = new Comment("Michael", "I made my daughter's wedding cake using your recipe!");
        video3.addComment(comment9);
        Comment comment10 = new Comment("Leah", "Wow, it turned out amazing!");
        video3.addComment(comment10);
       

        List<Video> videos = new List<Video> { video1, video2, video3 }; 

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.getTitle());
            Console.WriteLine("Author: " + video.getAuthor());
            Console.WriteLine("Length: " + video.getLength() + " seconds");
            Console.WriteLine("Number of Comments: " + video.getNumberOfComments());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.getComments())
            {
                Console.WriteLine(comment.getName() + ": " + comment.getText());
            }

            Console.WriteLine();
        }
        
    }
}