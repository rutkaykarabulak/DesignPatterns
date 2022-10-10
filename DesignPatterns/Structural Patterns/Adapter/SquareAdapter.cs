using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns.Adapter
{
    internal class SquareAdapter : RoundPeg
    {
        private SquarePeg squarePeg;

        public SquareAdapter(SquarePeg peg)
        {
            this.squarePeg = peg;
        }

        public override double GetRadius()
        {
            return squarePeg.GetWidth() * Math.Sqrt(2) / 2;
        }

    }
}
