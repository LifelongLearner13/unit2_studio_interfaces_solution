using System;
namespace SpinningDiscs
{
    public class LP : StorageDisk, IDisc, IDigitalStorage
    {
        public LP(string name, string type, double diameter, int capacity) : base(name, type, diameter, capacity)
        {
        }

        public void ReadData()
        {
            if (Contents.Count == 0)
            {
                Console.WriteLine("Vinyl record is empty");
                return;
            }

            Console.WriteLine("Vinyl record contains:");
            foreach (string el in Contents)
            {
                Console.WriteLine(el);
            }
        }

        public void Spin()
        {
            Console.WriteLine("A standard Vinyl record spins at 78 rpm.");
        }
    }
}
