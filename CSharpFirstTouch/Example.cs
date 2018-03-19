using System;

namespace CSharpFirstTouch
{
    internal static class Example
   {
        public static void Main(string[] args)
        {

            HelloWorld();
            FirstMethod();
            Math();
            
        }

       private static void HelloWorld()
       {
           Console.WriteLine();
           Console.WriteLine("---Hello---");
           Console.WriteLine("Hello World!");
       
       }

       private static void Math() {
           Console.WriteLine();
           Console.WriteLine("---Math---");
           int a = 34;
           int b = 15;
           int res;
    
           res = a + b;
           Console.WriteLine(res);
       }

       private static void FirstMethod()
       {
           Console.WriteLine();
           Console.WriteLine("---FirstMethod---");

           int num1 = 23;
           float num2 = 23.45f;
           char y = 'd';
           string str = "Hello";
           bool isHappy = true;

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