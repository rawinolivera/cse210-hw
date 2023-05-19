using System;

class Program
{
    static void Main(string[] args)
    {
        int opt = -1;

        
        //creamos un nuevo objeto de la clase Journal
        Journal journal = new Journal();

        while(opt != 5){

            if(opt == 1){
                journal.SetEntryList();

            } else if(opt == 2){
                journal.DisplayJournal();
            } else if (opt == 3){
                Console.WriteLine("What is the filename?");
                journal._name = Console.ReadLine();
                journal.LoadJournal();
            } else if(opt == 4){
                Console.WriteLine("What is the filename?");
                journal._name = Console.ReadLine();
                journal.SaveJournal();
            }



            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            string answer = Console.ReadLine();
            opt = int.Parse(answer);
        }
        
    }
}