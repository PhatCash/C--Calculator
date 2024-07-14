// See https://aka.ms/new-console-template for more information
using System;

class Calculator {

    static void Main(string[] args) {
        Console.WriteLine("Welcome to the calculator app!");

        Console.WriteLine("Please enter your first number: ");
        float num1 = Convert.ToSingle(Console.ReadLine());  

        Console.WriteLine("Please enter the second number: ");
        float num2 = Convert.ToSingle(Console.ReadLine());  

        Console.WriteLine($"\nYou have entered {num1} and {num2}.\n\tNow enter your operation (+, -, *, /): ");
        string? operation = Console.ReadLine();

        double result = 0;
        bool valid = true;

        switch (operation) {

            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num1 > 0) {
                    result = num1 / num2;
                } else {
                    Console.WriteLine("ERROR CODE: Cannot divide by zero");
                }
                break;
            default:
                Console.WriteLine("ERROR CODE: Invalid Operation");
                break;
        }

        Console.WriteLine($"The result of the operation is {result}");
    }
}
