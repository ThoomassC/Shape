﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Models
{
    public class Triangle: Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public override double Area()
        {
            return Length * Width / 2;
        }
    }
}
