using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jose's C# Calculator\n\n\n");

            ///Variables to store values
            float number1= 0, number2= 0, answer= 0;
            string operand;

            ///User inputs the values
            Console.Write("Enter first number-\n");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a operand +, -, *, /\n");
            operand = Console.ReadLine();

            Console.Write("Enter second number-\n");
            number2 = Convert.ToInt32(Console.ReadLine());

            ///User decides on which math output to be used
            
            switch(operand)
            {
                case "+":
                    answer = number1 + number2;
                        break;

                case "-":
                    answer = number1 - number2;
                        break;

                case "*":
                    answer = number1 * number2;
                        break;

                case "/":
                   answer = number1 / number2;
                  break;

            }
            ///Answer from user inputs
            Console.WriteLine("Equals = {0}{1}{2} = {3}", number1, operand, number2, answer);

            Console.Write("Enter any key to exit program");
            Console.ReadKey();






        }
    }
}
