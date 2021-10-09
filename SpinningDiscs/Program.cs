using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD("CD example", "CD-R", 4.5, 5);
            DVD dvd = new DVD("DVD example", "DVD-R", 6.6, 1450);

            cd.Spin();
            dvd.Spin();

            cd.ReadData();
            dvd.ReadData();

            cd.WriteData("Sims 4.exe");
            dvd.WriteData("Stargate");

            cd.ReadData();
            dvd.ReadData();

            Console.WriteLine(cd.Info());
            Console.WriteLine(dvd.Info());

        }
    }
}
