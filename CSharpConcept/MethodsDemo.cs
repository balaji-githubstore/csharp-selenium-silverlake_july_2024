
using Silverlakes.CSharpConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    public class MethodsDemo
    {
        
        public static void  Main(string[] args)
        {
            int a = 10;
            Area area = new Area();

            double res = area.AreaOfCircle(10);
            Console.WriteLine(res);

            Console.WriteLine(Area.AreaOfRectangle(10,10));

            Console.WriteLine(Area.AreaOfTriangle(10,10));
        }
    }
}
