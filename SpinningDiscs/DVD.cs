﻿using System;
namespace SpinningDiscs
{
    public class DVD : StorageDisk, IDisc, IDigitalStorage
    {
        public DVD(string name, string type, double diameter, int capacity) : base(name, type, diameter, capacity)
        {
        }

        public void ReadData()
        {
            if (Contents.Count == 0)
            {
                Console.WriteLine("DVD is empty");
                return;
            }

            Console.WriteLine("DVD contains:");
            foreach (string el in Contents)
            {
                Console.WriteLine(el);
            }
        }

        public void Spin()
        {
            Console.WriteLine("A DVD spins at a rate of 570 - 1600 rpm.");
        }
    }
}
