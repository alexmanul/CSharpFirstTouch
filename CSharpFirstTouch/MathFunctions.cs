using System;

namespace CSharpFirstTouch
{
    public static class MathFunctions
    {
        public static void Math() {
            Console.WriteLine();
            Console.WriteLine("---Math---");
            const int a = 34;
            const int b = 15;

            var res1 = a + b;
            const int res2 = a % b;
            
            Console.WriteLine(res1);
            Console.WriteLine(res2);

            res1 += 100;
            Console.WriteLine(res1);
        }
    }
}