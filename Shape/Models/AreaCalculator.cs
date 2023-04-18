using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Models
{
    public class AreaCalculator
    {
        public double TotalArea(Rectangle[] arrRectangles)
        {
            double area = 0;
            foreach (Rectangle objRectangle in arrRectangles) 
            {
                area += objRectangle.Height * objRectangle.Wight;
            }
            return area;
        }
    }
}
