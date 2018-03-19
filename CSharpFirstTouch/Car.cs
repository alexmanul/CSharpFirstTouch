using System;

namespace CSharpFirstTouch
{
    public class Car
    {
        public const int Wheels = 4;
        public float Speed;
        public bool IsWorking = true;

        public void SetValues(float speed, bool isWorking)
        {
            this.Speed = speed;
            this.IsWorking = isWorking;
        }

        public void GetValues()
        {
            Console.WriteLine("Car speed is: " + this.Speed + " km/h, car is working now: " + this.IsWorking);
        }
        
    }
}