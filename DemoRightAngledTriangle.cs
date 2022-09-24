using sess06_ClassesAndMethods;
using System;

namespace sess06_ClassesAndMethods
{
    /// <summary>
    /// Program to demonstrate the RightAngledTriangle class.
    /// </summary>
    public class DemoRightAngledTriangle
    {
        static void Main(string[] args)
        {
            //Variables to be used in the program
            byte @base, height;
            //Prompt the use for the base and height of the RightAngledTriangle
            Console.WriteLine("Please enter the base of the right angled triangle in cm -> ");
            @base = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Please enter the height of the right angled triangle in cm -> ");
            height = Convert.ToByte(Console.ReadLine());

            //Declare and instanciate a RigthtAngledTriangle object with the above measurements
            RightAngledTriangle triangle = new RightAngledTriangle(height, @base);

            //Display the results
            Console.WriteLine($"Right Angled Triangle Details"
                    + $"\n------------------------------"
                    + $"\nHeight: {height}"
                    + $"\nBase: {@base}"
                    + $"\nHypotenuse: {triangle.GetHypotenuse()}"
                    + $"\nPerimeter: {triangle.CalcPerimeter()}"
                    + $"\nArea: {triangle.CalcArea()}"
                    + $"\n------------------------------\n");

        }
    }
}
