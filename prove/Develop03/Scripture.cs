using System;

class Scripture{
    public void DisplayScripture(string textRefe, string textScri){
        Console.WriteLine(textRefe + " -> " + textScri);
    }

    public int RandonNumb(int numbWords){
        Random rndNum = new Random();
        int rndIndex = rndNum.Next(0, numbWords);
        return rndIndex;
    }

    public void HideWords(string textRefe, string textScri){
        string reference = textRefe;
        string scripture = textScri;
        string[] words = scripture.Split(" ");
        int wordsList = words.Length;
        int rndIndex = RandonNumb(wordsList);
        List<string> processedScripture = new List<string>();
        for(int i = 0; i < wordsList; i++){
            if(rndIndex == i){
                words[i] = new string('-', words[i].Length);
            }
            processedScripture.Add(words[i]);
        }
        DisplayUpdatedScripture(reference, words);
    }

    public void DisplayUpdatedScripture(string refe, string[] hiddenWords){
        Console.Write(refe);
        foreach (string word in hiddenWords){
            Console.Write(" " + word);
        }
        Console.WriteLine();
    }

    public bool StatusChanged(){
        return 1 == 2;
    }
}
/*
class Scripture {
    private string _text;
    private string _reference;
    
    public Scripture(){
        _text = "";
        _reference = "";
    }
    public string GetScripture(){
        Console.Clear();
        return $"{_reference} {_text}";
    }

    public void SetScripture(){
        Console.Write("Write scripture: ");
        _text = Console.ReadLine();
        Referenc referenc = new Referenc();
        _reference = referenc.GetScriptureRef();
    }
} */