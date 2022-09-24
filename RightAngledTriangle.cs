using System;

namespace sess06_ClassesAndMethods
{
    /// <summary>
    /// Class that will be used to create RightAngled triangle objects.
    /// </summary>
    public class RightAngledTriangle
    {
        //Instance variables/fields
        private byte height;
        private byte @base;
        private byte hypotenuse;

        //Constructors
        public RightAngledTriangle(){ }

        public RightAngledTriangle(byte height, byte @base)
        {
            this.height = height;
            this.@base = @base;
            this.hypotenuse =(byte) (Math.Sqrt(Math.Pow(height,2)+Math.Pow(@base,2)));
        }

        public int CalcArea()
        { return (int)(.5 * this.@base * this.height); }

        public int CalcPerimeter()
        { return (this.height + this.hypotenuse + this.@base); }

        //Method to obtain the triangle's hypotenuse
        public byte GetHypotenuse() { return this.hypotenuse; }

        //Override the ToString method to display the RightAnlged triangle's dimensions
        public override String ToString()
        {
            return ($"Right Angled Triangle Details"
                    + $"\n------------------------------"
                    + $"\nHeight: {this.height}"
                    + $"\nBase: {this.@base}"
                    + $"\nHypotenuse: {this.hypotenuse}"
                    + $"\nPerimeter: {this.CalcPerimeter()}"
                    + $"\nArea: {this.CalcArea()}"
                    + $"\n------------------------------\n");
        }


    }
}
