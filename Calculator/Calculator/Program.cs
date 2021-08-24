using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jose's C# Calculator\n\n\n");

            ///Variables to store values
            float number1, number2, answer;
            string operand;

            ///User inputs the values
            Console.Write("Enter first number-"\n);
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a operand <+, -, *, />\n");
            operand = Console.ReadLine();

            Console.Write("Enter second number-"\n);
            number2 = Convert.ToInt32(Console.ReadLine());

            ///User decides on which math output to be used
            
            switch(operand)
            {
                case "+":
                    answer = number1 + number2
                        break;

                case "-":
                    answer = number1 - number2
                        break;

                case "*":
                    answer = number1 * number2
                        break;

                case "/":
                    answer = number1 / number2
                        break;

            }





        }
    }
}
