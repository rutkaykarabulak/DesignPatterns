using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns.Adapter
{
    internal class SquarePeg: Shape
    {
        public SquarePeg(double width)
        {
            type = Type.Square;
            this.Width = width;
        }

        private readonly double Width;

        public virtual double GetWidth()
        {
            return this.Width;
        }
    }
}
