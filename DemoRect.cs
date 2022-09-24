using System;

namespace sess06_ClassesAndMethods
{
    /// <summary>
    /// Program demonstrating working with the Rectangle class.
    /// </summary>
    public class DemoRect
    {
        static void Main(string[] args)
        {
            //Declare and instantiate a Rect obect
            Rect rect = new Rect();
            //Prompt the user for the dimensions of the rectangle
            Console.WriteLine(@"Please enter the rectangle's length in cm-> ");
            byte len = byte.Parse(Console.ReadLine());
            Console.WriteLine(@"Please enter the rectangle's width in cm-> ");
            byte wid = byte.Parse(Console.ReadLine());
            //Set the rectangles dimensions
            rect.setLength(len);
            rect.setWidth(wid);

            //Get the dimensionns of a second rectangle
            Console.WriteLine(@"Please enter the second rectangle's length in cm-> ");
            len = byte.Parse(Console.ReadLine());
            Console.WriteLine(@"Please enter the second rectangle's width in cm-> ");
            wid = byte.Parse(Console.ReadLine());
            Rect r2 = new Rect(len, wid);

            //Display the dimensions of the wo rectangles
            rect.displayDimensions();
            Console.WriteLine(r2.ToString());
        }
    }
}
