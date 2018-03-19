using System;

namespace CSharpFirstTouch
{
    public static class MathFunctions
    {
        public static void Math() {
            Console.WriteLine();
            Console.WriteLine("---Math---");
            int a = 34;
            int b = 15;
            int res1, res2;
    
            res1 = a + b;
            res2 = a % b;
            Console.WriteLine(res1);
            Console.WriteLine(res2);

            res1 += 100;
            Console.WriteLine(res1);
        }
    }
}