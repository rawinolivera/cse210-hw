using System;

class Program
{
    static void Main(string[] args)
    {
        int opt = -1;

        
        //creamos un nuevo objeto de la clase Journal
        Journal journal = new Journal();
        Entry entry = new Entry();

        while(opt != 5){

            if(opt == 1){
                List<string> rPrompts = new List<string>();

                rPrompts.Add("Something good from today that you want to remember");
                rPrompts.Add("What was the most meaningfull action you did today?");
                rPrompts.Add("Write about an important event that happend today");
                rPrompts.Add("Write about an important conversation you had today");
                rPrompts.Add("Write about something new you learned today");

                //definimos la fecha
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                //iterate the random thing
                List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
        
                Random rnd = new Random();
                int randIndex = rnd.Next(numbers.Count);
                int random = numbers[randIndex];

                //inicializamos la variable
                int marca = 0;
                foreach(string prompt in rPrompts){
                    marca++;
                    if(marca == random){

                        Console.WriteLine(prompt);
                        string data = Console.ReadLine();
                        //cargamos los valores en la clase Entry
                        entry._prompt = prompt;
                        entry._date = dateText;
                        entry._response = data;
                        journal._entries.Add(entry);
                    }
                }
                

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