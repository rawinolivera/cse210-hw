using System;
using System.IO;

class Journal{
    public string _name;
    public List<Entry> _entries = new List<Entry>();

    public void SaveJournal(){
        string fileName = _name;

        using (StreamWriter outputFile = new StreamWriter(fileName)){
            foreach(Entry entry in _entries){
                outputFile.WriteLine(entry._date);
                outputFile.WriteLine(entry._prompt);
                outputFile.WriteLine(entry._response);
            }
        }
    }

    public void LoadJournal(){
        string filename = _name;
        string[] lines = System.IO.File.ReadAllLines(filename);

        int side = lines.Length;
        side = side - 1;
        Console.WriteLine(side);
        
        int i = 0;
        int j = 1;
        int k = 2;
        for(int f = 0; f <= side; f = f + 3){ 
            
            Entry entry = new Entry();
            entry._date = lines[i];   //0, 3
            entry._prompt = lines[j];  //1,4
            entry._response = lines[k];   //2,5
            i = i + 3;
            j = j + 3;
            k = k + 3;
            _entries.Add(entry);
        }
    }

    public void DisplayJournal(){
        foreach(Entry entry in _entries){
            entry.DisplayEntry();
        }   
    }

    public void SetEntryList(){
        List<string> rPrompts = new List<string>();

                rPrompts.Add("Something good from today that you want to remember");
                rPrompts.Add("What was the most meaningfull action you did today?");
                rPrompts.Add("Write about an important event that happend today");
                rPrompts.Add("Write about an important conversation you had today");
                rPrompts.Add("Write about something new you learned today");
                rPrompts.Add("What could you do different from this day?");

                //definimos la fecha
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                //iterate the random thing
                List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
        
                Random rnd = new Random();
                int randIndex = rnd.Next(numbers.Count);
                int random = numbers[randIndex];

                //inicializamos la variable
                int marca = 0;
                foreach(string prompt in rPrompts){
                    marca++;
                    if(marca == random){

                        Console.WriteLine($"Prompt: {prompt}");
                        string data = Console.ReadLine();
                        //creamosl el objeto entry
                        Entry entry = new Entry();
                        //cargamos los valores en la clase Entry
                        entry._prompt = prompt;
                        entry._date = dateText;
                        entry._response = data;
                        _entries.Add(entry);
                    }
                }
    }

}