using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.Triangles
{
    internal class TriangleBuilder
    {
        public TriangleBuilder() { }

        public Triangle CreateTriangle(double firstSide, double secondSide, double thirdSide)
        {
            if ((firstSide == secondSide) && (firstSide == thirdSide))
            {
                return new EquiletarlTriangle(firstSide, secondSide, thirdSide);
            }

            return new Triangle(firstSide, secondSide, thirdSide);
        }
    }
}
