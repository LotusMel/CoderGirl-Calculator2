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
        
        
        /// <summary>
        /// Adds firstNumber and SecondNumber
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>The total of the two numbers</returns>
        public static double Add(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            
            return result;
        }
        
        /// <summary>
        /// Subtracts secondNumber from firstNumber         
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>The difference of the two numbers</returns>
        public static double Subtract(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;

            return result;
        }
        
        /// <summary>
        /// Multiplies the firstNumber by the secondNumber
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>The product of the two numbers</returns>
        public static double Multiply(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;

            return result;
        }

        /// <summary>
        /// Divides the firstNumber by the secondNumber
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>The quotient of the two numbers</returns>
        public static double Divide(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;

            return result;
        }

        




    }
}
