using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_Two
{
    
    internal class Program
    {

        static void Main(string[] args)
        {
            Point3D point3D = new Point3D();
            
            Console.WriteLine(point3D.x);

            Fraction f1 = new Fraction();

            Fraction result = f1.add(f1);

            Console.WriteLine($"the Sum = {result.Nom} / {result.Den} ");
        }
    }
   
}
