using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns.Adapter
{
    internal class RoundPeg:Shape
    {
        public RoundPeg()
        {

        }
        public RoundPeg(double radius)
        {
            type = Type.Rounded;
            this.Radius = radius;   
        }

        private readonly double Radius;

        public virtual double GetRadius()
        {
            return Radius;
        }
    }
}
