using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGitGood
{
    class Rectangle : Polygon
    {
        public override int NumberOfSides
        {
            get { return 4; }
        }
        public double Length { get; set; }
        //public double Width { get { return Length; } set { Length = value; } }
        public double Height { get; set; }

        public override double Area
        {
            get { return Length * Height; }
        }
        public override double Perimeter
        {
            get { return 2 * (Length + Height); }
        }

    }
}
