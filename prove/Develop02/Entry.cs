using System;

public class Entry{

    public string _date;
    public string _response;
    public string _prompt;
    public void DisplayEntry(){
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine();
    }

    
}