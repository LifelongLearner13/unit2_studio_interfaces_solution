using System;
namespace SpinningDiscs
{
    public class CD : StorageDisk, IDisc, IDigitalStorage
    {
        public CD(string name, string type, double diameter, int capacity) : base(name, type, diameter, capacity)
        {
        }

        public void ReadData()
        {
            if(Contents.Count == 0)
            {
                Console.WriteLine("CD is empty");
                return;
            }

            Console.WriteLine("CD contains:");
            foreach (string el in Contents)
            {
                Console.WriteLine(el);
            }
        }

        public void Spin()
        {
            Console.WriteLine("A CD spins at a rate of 200 - 500 rpm.");
        }

    }
}
