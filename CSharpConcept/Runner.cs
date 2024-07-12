using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silverlakes.CSharpConcept
{
    public class Runner
    {
        public static void Main1(string[] args)
        {
            Console.WriteLine("Balaji");
            sbyte a = 127;
            float b=10.2f;
            double c = 10.2;
            decimal d = 10.2m;

            string name = "Balaji";

            //10,20,30,40,50
            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            Console.WriteLine(numbers[1]);

            double [] numbers2 = new double[2];
            numbers2[0] = 90.2;
            numbers2[1] = 34.9;

            //create an array to store red, green, yellow
            string[] colors=new string[3];
            colors[0] = "red";
            colors[1] = "green";
            colors[2] = "yellow";

            Console.WriteLine(colors[2]);

            string[] colors1 = { "red", "green", "yellow" };

        }
    }
}
