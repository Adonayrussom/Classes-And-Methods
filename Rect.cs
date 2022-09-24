using System;

namespace sess06_ClassesAndMethods
{
    public class Rect
    {
        private int length;
        private int width;

        /**
         *
         */
        public Rect()
        {
        }

        /**
         * @param length
         * @param width
         */
        public Rect(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int getLength()
        {
            return length;
        }

        /**
         * @param length the length to set
         */
        public void setLength(int length)
        {
            this.length = length;
        }

        /**
         * @return the width
         */
        public int getWidth()
        {
            return width;
        }

        /**
         * @param width the width to set
         */
        public void setWidth(int width)
        {
            this.width = width;
        }

        public float calcArea()
        {
            return (this.length * this.width);
        }

        public float calcPerimeter()
        {
            return (2 * (this.length + this.width));
        }

        public void displayDimensions()
        {
            Console.WriteLine("Rectangle\'s Dimensions" + "\n----------------------------" + "\nLength: " + this.length
                    + "\nWidth: " + this.width + "\nPerimeter: " + this.calcPerimeter() + "\nArea: " + this.calcArea()
                    + "\n----------------------------\n");
        }

        public override string ToString()
        {
            return ("Rectangle\'s Dimensions" + "\n----------------------------" + "\nLength: " + this.length
                    + "\nWidth: " + this.width + "\nPerimeter: " + this.calcPerimeter() + "\nArea: " + this.calcArea()
                    + "\n----------------------------\n");
        }
    }
}

