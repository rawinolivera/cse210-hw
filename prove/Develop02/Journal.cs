using System;
using System.IO;

public class Journal{
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
        Entry entry = new Entry();
        
        int i = 0;
        int j = 1;
        int k = 2;
        for(int f = 0; f <= side; f = f + 3){ 
            entry._date = lines[i];   //0, 3
            Console.WriteLine(entry._date);
            entry._prompt = lines[j];  //1,4
            Console.WriteLine(entry._prompt);
            entry._response = lines[k];   //2,5
            Console.WriteLine(entry._response);
            i = i + 3;
            j = j + 3;
            k = k + 3;
            _entries.Add(entry);

            DisplayJournal();
        }
    }

    public void DisplayJournal(){
        foreach(Entry entry in _entries){
            entry.DisplayEntry();
        }
    }

}