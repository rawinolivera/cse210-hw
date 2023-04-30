using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "yes";

        while (answer == "yes"){
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 500);
            /*
            Console.Write("What is the magic number? ");
            string newValue = Console.ReadLine();
            int magicNumber = int.Parse(newValue);
            */
            int guessNumber = 1000000;
            string newValue;
            int nTimes = 0;
            
            do {
                Console.Write("What is your guess? ");
                newValue = Console.ReadLine();
                guessNumber = int.Parse(newValue);
                nTimes++;

                if (guessNumber > magicNumber){
                    Console.WriteLine("Lower");
                }else if(guessNumber < magicNumber){
                    Console.WriteLine("Higher");
                } else {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You did it in {nTimes} times.");
                }
            } while(magicNumber != guessNumber);
            Console.Write("Would you like to play again? yes/no: ");
            answer = Console.ReadLine();
            
        }
    }
}