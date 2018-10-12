using System;

namespace CalcAssign14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
  
            //Create a simple calculator that asks the user to input two different numbers and whether they want to add, 
            //subtract, multiple or divide them.
            //Remember our simple calculator program from Class 3 ? Update the application 
            //so that each of the math calculations(add, subtract, multiply, divide) is each
            //in its own method.The methods should return the value and the main method should 
            //print the value.Make sure your methods have XML comments for IntelliSense.Upload 
            //your program to a new repository called CG 5 - 2

            //Program  for the variables first number, second number, answer and operation.  Using double allows for fractions.
            double firstnumber = 0;
            double secondnumber = 0;
            double answer = 0;
            string operation = " ";

            //Ask the user to input the first number.
            Console.WriteLine("Welcome to a simple calculator. Please enter a simple math calculation " +
                "using (/, x, +, -). Write the calculation as: number, space, operator, space number, IE: 2 + 2 " +
                "and enter.");
            
            //Print the user input to the console.
            string input = Console.ReadLine();

            var parts = input.Split(" ");

            if (parts != null)
            {
                firstnumber = Convert.ToDouble(parts[0]);
                operation = parts[1];
                secondnumber = Convert.ToDouble(parts[2]);
            }

            //Ask the user to input the first number.
            //Console.WriteLine("Welcome to a simple calculator. Please enter the first number:");
            //Print the user input to the console.
            //firstnumber = Convert.ToDouble(Console.ReadLine());

            //Ask the user to input the second number.
            //Console.WriteLine("Enter the second number");
            //Print the user input to the console.
            //secondnumber = Convert.ToDouble(Console.ReadLine());

            //Ask the user to input the operator (x, +, -, or /).  Assuming the user knows symbols for multiplication, division, 
            //subtraction, and addition).
            //Console.WriteLine("Enter the operator by typing x, /, +, or -");
            //Print the user input to the console.
            //operation = Console.ReadLine();

            //Below calculates and prints the answer to the console depending on which operator chosen as an equation.

            //Checks if the variable to the cases, if not the default is selected. Break has to be used to exit the curly brackets.
            switch (operation)
            {
                case "x":
                    answer = Operators.Multiply(firstnumber, secondnumber);
                    Console.WriteLine(firstnumber + " x " + secondnumber + " = " + answer);
                    break;
                case "/":
                    answer = Operators.Divide(firstnumber, secondnumber);
                    Console.WriteLine(firstnumber + " / " + secondnumber + " = " + answer);
                    if (secondnumber == 0)
                    {
                        Console.WriteLine("Cannot divide by 0, please try again.");
                    }
                    break;
                case "+":
                    answer = Operators.Addition(firstnumber, secondnumber);
                    Console.WriteLine(firstnumber + " + " + secondnumber + " = " + answer);
                    break;
                case "-":
                    answer = Operators.Minus(firstnumber, secondnumber);
                    Console.WriteLine(firstnumber + " - " + secondnumber + " = " + answer);
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Incorrect format.  Must be number, operator, number with spaces in between each.");
            }
            Console.ReadLine();

        }
    }
}
