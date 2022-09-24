using System;

namespace sess06_ClassesAndMethods
{
    /// <summary>
    /// Class with methods to perform simple arithmetic operations.
    /// </summary>
    public class SimpleMath
    {
        public long AddNums(int num1, int num2)
        {
            return num1 + num2;
        }

        public long MultiplyNums(int num1, int num2)
        {
            return num1 * num2;
        }

        public long SubtractNums(int num1, int num2)
        {
            return num1 - num2;
        }

        public long DivideNums(int num1, int num2)
        {
            //check if the demonstrator is 0 'zero' to prevent division by 0 error
            if (num2 == 0)
            {
                Console.WriteLine("Sorry, you hve entered 0 \"zero\" as a"
                        + "denominator which will lead to division errors."
                        + "\nPlease enter a non-zero denominator and try again.");
                Environment.Exit(1);//Terminate the program           
            }
            return num1 / num2;
        }
        public int GetRemainder(int num1, int num2)
        {
            return num1 % num2;
        }
    }
}
