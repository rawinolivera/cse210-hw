using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome!!");
        Console.WriteLine("Let's memorize a new scripture");
        Scripture scripture = new Scripture();
        Word currentVerse = new Word();
        Reference currentRefe = new Reference();
        string textRefe = currentRefe.TypeReference();
        string textVers = currentVerse.CatchVerse();
        scripture.DisplayScripture(textRefe, textVers);
        string signal = "";

        while(signal != "quit"){
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            signal = Console.ReadLine();
            Console.Clear();
            scripture.HideWords(textRefe, textVers);
        }
        Console.WriteLine("Thank!");
    }
}
