using System;
namespace SpinningDiscs
{
    public class Disc
    {
        public string Name {get; set;}
        public string Type { get; set; }
        public double Diameter { get; set; }

        public Disc(string name, string type, double diameter)
        {
            Name = name;
            Type = type;
            Diameter = diameter;
        }

        public string Info()
        {
            return $"Name: {Name}, Type: {Type}, Diameter: {Diameter}";
        }
    }
}
