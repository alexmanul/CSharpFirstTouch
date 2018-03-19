using System;

namespace CSharpFirstTouch
{
    internal static class MainClass
   {
        public static void Main(string[] args)
        {
//            HelloWorld.Hello();
//            FirstClass.FirstMethod();
//            MathFunctions.Math();
//            Converting.ConvertingMethod();

            var audi = new Car {Speed = 280};
            Console.WriteLine(Car.Wheels);
            Console.WriteLine(audi.Speed);
            Console.WriteLine(audi.IsWorking);
            
            audi.GetValues();

            audi.SetValues(250.5f, isWorking: false);
            Console.WriteLine(audi.Speed);
            Console.WriteLine(audi.IsWorking);
            
            audi.GetValues();
            
            Console.WriteLine("============");
            
            var volvo = new Car {Speed = 240};
            Console.WriteLine(Car.Wheels);
            Console.WriteLine(volvo.Speed);
            Console.WriteLine(volvo.IsWorking);
            
            volvo.GetValues();
            
        } 
     }
}