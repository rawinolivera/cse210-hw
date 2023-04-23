using System;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("What is your grade percentage? ");
        string newValue = Console.ReadLine();
        int grade = int.Parse(newValue);
/*
        if (grade >= 90){
            Console.WriteLine("Your letter grade is A");
        } else if(grade >= 80){
            Console.WriteLine("Your letter grade is B");
        } else if(grade >= 70){
            Console.WriteLine("Your letter grade is C");
        } else if(grade >= 60){
            Console.WriteLine("Your letter grade is D");
        } else {
            Console.WriteLine("Your letter grade is E");
        }
*/      
        string letter;
        if (grade >= 90){
            letter = "A";
            if (grade < 93){
                letter = "A-";
            }
        } else if(grade >= 80){
            letter = "B";
            if(grade > 87){
                letter = "B+";
            }
            if(grade < 83){
                letter = "B-";
            }
        } else if(grade >= 70){
            letter = "C";
            if(grade > 77){
                letter = "C+";
            }
            if(grade < 73){
                letter = "C-";
            }
        } else if(grade >= 60){
            letter = "D";
            if(grade > 67){
                letter = "D+";
            }
            if(grade < 63){
                letter = "D-";
            }
        } else {
            letter = "E";
        }

        Console.WriteLine($"Your grade letter is {letter}");

        if (grade >= 70){
            Console.Write("Congratulations!! You passed the class!!");
        } else {
            Console.Write("Sorry you did not pass the class! You should consider work hard to success nest time!");
        }
    }
}