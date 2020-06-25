using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGitGood
{
    abstract class Polygon
    {
        public abstract int NumberOfSides { get; }

        public abstract double Area { get; }
        public abstract double Perimeter { get; }
    }
}
