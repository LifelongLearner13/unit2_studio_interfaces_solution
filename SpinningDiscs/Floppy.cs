using System;
namespace SpinningDiscs
{
    public class Floppy : StorageDisk, IDisc, IDigitalStorage
    {
        public Floppy(string name, string type, double diameter, int capacity) : base(name, type, diameter, capacity)
        {
        }

        public void ReadData()
        {
            if (Contents.Count == 0)
            {
                Console.WriteLine("Floppy is empty");
                return;
            }

            Console.WriteLine("Floppy record contains:");
            foreach (string el in Contents)
            {
                Console.WriteLine(el);
            }
        }

        public void Spin()
        {
            Console.WriteLine("A Floppy disk record spins at 300 rpm.");
        }
    }
}
