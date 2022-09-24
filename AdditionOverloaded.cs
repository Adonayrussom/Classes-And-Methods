using System;

namespace sess06_ClassesAndMethods
{
    /// <summary>
    /// Class that demonstrates method overloading using variations of an Addition() method.
    /// </summary>
    public class AdditionOverloaded
    {
        public long addNums(int num1, int num2)
        {
            return num1 + num2;
        }
        

        public float addNums(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        

        public float addNums(float num1, long num2)
        {
            return num1 + num2;
        }
        

        public float addNums(params int[] nums)//Takes a variable size array
        {
            float sum = 0.0f;
            foreach (float num in nums)
            {
                sum += num;
            }
            return sum;
        }
    }
}
