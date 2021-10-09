using System;
namespace SpinningDiscs
{
    public class Frisbee : Disc, IDisc
    {
        public Frisbee(string name, string type, double diameter) : base(name, type, diameter)
        {
        }

        public void Spin()
        {
            Console.WriteLine("Throw the Frisbee!");
        }
    }
}
