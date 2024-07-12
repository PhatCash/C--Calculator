// See https://aka.ms/new-console-template for more information
using System;

class Calculator {

    static void Main(string[] args) {
        Console.Write("\nWelcome to the calculator app!");

        Console.Write("\nPlease enter your first number: ");
        float num1 = Convert.ToSingle(Console.ReadLine());  

        Console.Write("\nPlease enter the second number: ");
        float num2 = Convert.ToSingle(Console.ReadLine());  

        Console.WriteLine($"\nYou have entered {num1} and {num2}");
    }

}
