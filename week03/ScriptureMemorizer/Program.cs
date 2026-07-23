using System;


class Program
{
    static void Main(string[] args)
    {
//To add creativity and exceed requirements, A boolean variable was added to allow the user to play again.
        bool playAgain = true;

        while (playAgain)
        {
            Reference reference = new Reference("John", 3, 16);
            Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

            string input = "";


            while (!scripture.IsCompletelyHidden() && input != "quit")
            {
                Console.Clear();

                Console.WriteLine("Hello and welcome to The Scripture Memorizer!");
                Console.WriteLine("To play, press Enter to hide a few words from the scripture. Type 'quit' at any time, to exit the program.");
                Console.WriteLine();

                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");

                input = Console.ReadLine().Trim().ToLower();

                if (input != "quit")
                {
                    scripture.HideRandomWords(3);
                }
            }

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
            }

//To show creativity and exceed requirements, I have asked the user if they would like to play again.
//Sometimes it takes more than one round to memorize a scripture. 
//If the user types "yes", the program will restart. If they type "no", the program will exit.
            Console.WriteLine("\nWould you like to play again (yes/no)?");
            string answer = Console.ReadLine().Trim().ToLower();
            if (answer != "yes")
            {
                playAgain = false;
            }

        }    

    }
}