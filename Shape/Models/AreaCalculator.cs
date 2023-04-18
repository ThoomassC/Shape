using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Models
{
    public class AreaCalculator
    {
        public AreaCalculator() { }
        public double TotalArea(object[] arrObjects)
        {
            double area = 0;
            foreach (var obj in arrObjects) 
            {
                switch (obj)
                {
                    case Rectangle objRectangle:
                        area += objRectangle.Height * objRectangle.Widht;
                        break;
                    case Circle objCircle:
                        area += objCircle.Radius * objCircle.Radius * Math.PI;
                        break;
                    case Triangle objTriangle:
                        area += objTriangle.CoteLeft * objTriangle.CoteRight / objTriangle.CoteDown;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(area);
            return area;
        }
    }
}
