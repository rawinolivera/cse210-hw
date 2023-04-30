using System;

class Program
{
    static void Main(string[] args)
    {
        //using System.Collections.Generic;

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;
        double media = 0.0;
        int amount = 0;
        int largest = -100000000;
        int smallest = 100000000;

        while (number != 0) {
            Console.Write("Enter Number: ");
            string newValue = Console.ReadLine();
            number = int.Parse(newValue);
            if (number != 0) {
                numbers.Add(number);
                amount = amount + number; //amount += number;
                if (number > largest){
                    largest = number;
                }
                if (number > 0 && number < smallest){
                    smallest = number;
                }
            } else {
                media = ((float)amount) / numbers.Count;
                Console.WriteLine($"The sum is: {amount}");
                Console.WriteLine($"The average is: {media}");
                Console.WriteLine($"The largest number is: {largest}");
                Console.WriteLine($"The smallest positive number is: {smallest}");
                numbers.Sort();
                Console.WriteLine("The sorted list is:");
                    foreach(int element in numbers){

                    Console.WriteLine(element);
                } 
            }
            
        }

    }
}