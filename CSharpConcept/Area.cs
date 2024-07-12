using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silverlakes.CSharpConcept
{
    public class Area
    {
        public double AreaOfCircle(int r)
        {
            return 3.14 * r * r;
        }
        //create a AreaOfRectangle
        public static double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }

        public static double AreaOfTriangle(double baseValue, double height)
        {
            double res = (baseValue * height) / 2;
            return res;
        }

        public void Quit()
        {

        }
    }
}
