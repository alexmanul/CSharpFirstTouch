using System;

namespace CSharpFirstTouch
{
    public static class FirstClass
    {
        public static void FirstMethod()
        {
            Console.WriteLine();
            Console.WriteLine("---FirstMethod---");

            var num1 = 23;
            const float num2 = 23.45f;
            const char y = 'd';
            const string str = "Hello";
            const bool isHappy = true;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(y);
            Console.WriteLine(str);

            Console.WriteLine(isHappy);

            num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Your number is " + num1);
        }
    }
}