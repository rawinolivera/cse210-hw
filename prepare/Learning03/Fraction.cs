using System;

class Fraction {
    private int _topNumber;
    private int _bottomNumber;

    public Fraction(){
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int numerator){
        _topNumber = numerator;
        _bottomNumber = 1;
    }

    public Fraction(int topNum, int botNum){
        _topNumber = topNum;
        _bottomNumber = botNum;
    }

    public string GetFractionString(){
        string textNum = $"{_topNumber}/{_bottomNumber}";
        return textNum;
    }

    public double GetDecimalValue(){
        return (double)_topNumber / (double)_bottomNumber;
    }
}