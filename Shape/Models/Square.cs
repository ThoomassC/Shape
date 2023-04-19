using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Models
{
    public class Square: Shape
    {
        public double Cote { get; set; }

        public override double Area()
        {
            return Cote * Cote;
        }
    }
}
