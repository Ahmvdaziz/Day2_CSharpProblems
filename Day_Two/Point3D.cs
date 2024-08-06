using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_Two
{
    internal class Point3D
    {
        public int x, y, z;

        public Point3D() : this(10, 20, 30)
        {

        }

        public Point3D(int _x, int _y, int _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        public void displayAll()
        {
            Console.WriteLine($"value of x =  {x} \t , value of y =  {y} \t , value of z = {z}");
        }

        public int CalcDistance(Point3D p1)
        {
            int distance;
            double partx = (int)Math.Pow((x - p1.x), 2);
            distance = (int)Math.Sqrt(partx);
            return distance;
        }
    }
}
