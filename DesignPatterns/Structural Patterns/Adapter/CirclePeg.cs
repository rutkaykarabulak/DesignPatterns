using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns.Adapter
{
    internal class CirclePeg:Shape
    {
        public CirclePeg()
        {
            type = Type.Circle;
        }
    }
}
