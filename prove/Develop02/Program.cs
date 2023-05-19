using System;

class Program
{
    static void Main(string[] args)
    {
        int opt = -1000000000;

        
        //creamos un nuevo objeto de la clase Journal
        Journal journal = new Journal();

        while(opt != 5){

            if(opt == 1){
                journal.SetEntryList();

            } else if(opt == 2){
                journal.DisplayJournal();
            } else if (opt == 3){
                Console.Write("What is the filename? >>>");
                journal._name = Console.ReadLine();
                journal.LoadJournal();
            } else if(opt == 4){
                Console.Write("What is the filename? >>>");
                journal._name = Console.ReadLine();
                journal.SaveJournal();
            } else {
                if(opt == -1000000000){
                    //inicio del programa, se imprimira el menu
                } else {
                    Console.WriteLine("Invalid option!! Try Again...");
                }
            }


            Console.WriteLine();
            Console.WriteLine("*******************************************************");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string answer = Console.ReadLine();
            opt = int.Parse(answer);
        }
        
    }
}