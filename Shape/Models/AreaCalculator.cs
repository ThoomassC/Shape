using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape.Models;

namespace Shape.Models
{
    public class AreaCalculator
    {
        public AreaCalculator() { }
        public double TotalArea(Shape[] arrShapes)
        {
            double area = 0;

           foreach(var objShape in arrShapes) 
            {
                area += objShape.Area();
            }

            Console.WriteLine(area);
            return area;
        }
    }
}
