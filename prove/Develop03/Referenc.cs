using System;

class Referenc {
    private string _book;
    private int _chapter;
    private int _verse;
    private int _finalVerse;

    public Referenc(){
        _book = "";
        _chapter = 0;
        _verse = 0;
        _finalVerse = 0;
    }

    public string GetScriptureRef(){
        if(_finalVerse == 0){
            string reference = $"{_book} {_chapter}:{_verse}";
            return reference;
        } else {
            string reference = $"{_book} {_chapter}:{_verse}-{_finalVerse}";
            return reference;
        }
    }
}