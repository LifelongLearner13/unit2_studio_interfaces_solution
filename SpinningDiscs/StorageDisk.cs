using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class StorageDisk : Disc
    {
        public int Capacity { get; set; }
        public List<string> Contents { get; set; }
        private int Used { get; set; }

        public StorageDisk(string name, string type, double diameter, int capacity) : base(name, type, diameter) 
        {
            Capacity = capacity;
            Contents = new List<string>();
        }

        public void WriteData(string data)
        {
            if(Used >= Capacity)
            {
                Console.WriteLine("Not Enough disk space!");
                return;
            }

            Used += 1;
            Contents.Add(data);
        }
    }
}
