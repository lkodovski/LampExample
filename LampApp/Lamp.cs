using System;

namespace LampApp
{
    public class Lamp
    {
        public bool IsOn;
        public string Color;

        public Lamp(string color)
        {
            this.Color = color;
            this.IsOn = false;
        }

        public void TurnOn()
        {
            this.IsOn = true;
            Console.WriteLine("The lamp is now ON with color " + this.Color);
        }

        public void TurnOff()
        {
            this.IsOn = false;
            Console.WriteLine("The lamp is now OFF.");
        }

        public void ChangeColor(string newColor)
        {
            this.Color = newColor;
            Console.WriteLine("The lamp color is now " + this.Color);
        }
    }
}
