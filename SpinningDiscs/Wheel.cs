using System;
namespace SpinningDiscs
{
    public class Wheel : Disc, IDisc
    {
        public Wheel(string name, string type, double diameter) : base(name, type, diameter)
        {
        }

        public void Spin()
        {
            Console.WriteLine("Start the wheel rolling!");
        }
    }
}
