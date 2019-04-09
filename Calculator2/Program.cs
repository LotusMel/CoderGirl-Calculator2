using System;

namespace Calculator2
{
    public static class Program
    {
        

        public static void Main()
        {
            Console.Write("Please enter your first number: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Please enter your second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Would you like to add, subtract, multiply, or divide? ");
            string operation = Console.ReadLine();

            if (operation == "add")
            {
                Add(firstNumber, secondNumber);
                Console.WriteLine($"Total = {Add(firstNumber, secondNumber)}");
            }
            
            if (operation == "subtract")
            {
                Subtract(firstNumber, secondNumber);
                Console.WriteLine($"Total = {Subtract(firstNumber, secondNumber)}");
            }

            if (operation == "multiply")
            {
                Multiply(firstNumber, secondNumber);
                Console.WriteLine($"Total = {Multiply(firstNumber, secondNumber)}");
            }

            if (operation == "divide")
            {
                Divide(firstNumber, secondNumber);
                Console.WriteLine($"Total = {Divide(firstNumber, secondNumber)}");
            }


            Console.ReadLine();
        }

        // Use methods for each type of calculation.
        public static double Add(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            
            return result;
        }
        
        public static double Subtract(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;

            return result;
        }

        public static double Multiply(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;

            return result;
        }

        public static double Divide(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;

            return result;
        }

        




    }
}
