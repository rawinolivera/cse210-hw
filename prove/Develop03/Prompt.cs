using System;

class Prompt{
    private string textReq = "Type the text of the scripture";
    private string refeReq = "Type de reference of the scripture";

    public void ReqText(){
        Console.WriteLine(textReq);
    }

    public void ReqRefe(){
        Console.WriteLine(refeReq);
    }
}