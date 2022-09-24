using System;

namespace sess06_ClassesAndMethods
{
    public class DemoSimpleMath
    {
        static void Main(String[] args)
        {
            //Variables to be used in the progrm
            int num1 = 8, num2 = 7;
            long sum, product;
            int difference, quotient, remainder;

            //Declare and instantiate a simpleMath object
            SimpleMath sm = new SimpleMath();
            sum = sm.AddNums(num1, num2);
            product = sm.MultiplyNums(num1, num2);
            difference = (int)sm.SubtractNums(num1, num2);
            quotient = (int)sm.DivideNums(num1, num2);
            remainder = (int)sm.GetRemainder(num1, num2);

            //Display the results
            Console.WriteLine("Results of different arithmetic operations"
                      + $"\n========================="
                      + $"\nAddition {num1} + {num2} = {sum}"
                      + $"\nMultiplication {num1} x {num2} = {product}"
                      + $"\nsubraction {num1} - {num2} = {difference}"
                      + $"\nDivision {num1}{'\u00f7'} {num2} {quotient}"
                      + $"\nRemainder/Modulus {num1} % {num2} = {remainder}"
                      + $"\n=========================\n");

        }
    }
}
