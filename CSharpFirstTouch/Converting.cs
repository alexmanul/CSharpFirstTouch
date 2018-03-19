using System;

namespace CSharpFirstTouch
{
    public static class Converting
    {
        public static void ConvertingMethod()
        {
            double a = Convert.ToDouble((Console.ReadLine()));
            bool isTrue = true;

            if (a > 10f && isTrue)
            {
                Console.Write("A is bigger than 10");
            }
            else if (a < 5f)
            {
                Console.Write("A is less than 5");
            }
            else if (a == 6.0f)
            {
                Console.Write("A is equal to 6.0");
            }
        }
    }
}