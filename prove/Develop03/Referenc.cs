using System;

class Reference{
    string reference;
    public string TypeReference(){
        Prompt prompt = new Prompt();
        prompt.ReqRefe();
        reference = Console.ReadLine();
        return reference;
    }

    public void DisplayRefe(string text){
        Console.WriteLine(text);
    }
}

/*
class Referenc {
    private string _book;
    private string _chapter;
    private string _verse;
    private string _finalVerse;

    public Referenc(){
        _book = "";
        _chapter = "";
        _verse = "";
        _finalVerse = "";
    }

    public string GetScriptureRef(){
        if(_finalVerse == ""){
            string reference = $"{_book} {_chapter}:{_verse}";
            return reference;
        } else {
            string reference = $"{_book} {_chapter}:{_verse}-{_finalVerse}";
            return reference;
        }        
    }

    public void SetScriptureRef(){
        Console.Write("Write the name of the book: ");
        _book = Console.ReadLine();
        Console.Write("Write chapter in numbers: ");
        _chapter = Console.ReadLine();
        Console.Write("Write the verse: ");
        _verse = Console.ReadLine();

        Console.Write("The reference has more than one verse (y/n): ");
        string dato = Console.ReadLine();
        if(dato == "y"){
            Console.WriteLine("Write the name of the book: ");
            _finalVerse = Console.ReadLine();
        }else if(dato == "n"){
            Console.Write("Reference saved!");
        }else{
            Console.Write("Invalid data, try again!: ");
        }

        
    }
} */