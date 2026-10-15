using System;

namespace LampApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var lamp = new Lamp("White");

            lamp.TurnOn();
            lamp.ChangeColor("Blue");
            lamp.TurnOff();

            lamp.TurnOn();
            lamp.ChangeColor("Red");
        }
    }
}
