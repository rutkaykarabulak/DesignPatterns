using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns.Adapter
{
    public abstract class Shape
    {
        public enum Type
        {
            Rounded,
            Circle,
            Square
        };

        public Type type;
    }
}
