using System;

class Word{
    string verse;
    public string CatchVerse(){
        Prompt prompt = new Prompt();
        prompt.ReqText();
        verse = Console.ReadLine();
        return verse;
    }

    public void DisplayVerse(string text){
        Console.WriteLine(text);
    }
}

/*
class Word {
    private bool _stateHiden; //hidden or shown
    private string _word;
    public Word(){
        _stateHiden = false;
        _word = "";
    }

    public void PassingText(){
        Referenc refer = new Referenc();
        refer.SetScriptureRef();
        Scripture scripture = new Scripture();
        scripture.SetScripture();
        string[] separatingStrings = { ";",",","."," ","!","?" };

        string text = scripture.GetScripture();

        string [] words = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
        
        Console.Write(refer.GetScriptureRef());

        foreach (var singleWord in words)
        {
            _word = singleWord;
            if(_stateHiden == true){
                int count = _word.Length;
                Console.Write(" ");
                for(int i = 0; i < count; i++){
                    Console.Write("-");
                }
                }else{
                    Console.Write($" {_word}");
                }
        }
    }
} */