using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns.Adapter
{
    /// <summary>
    /// Adapter pattern is a structural design pattern that allows objects with incompatible interfaces to colloborate.
    /// In this example round hole only accepts rounded shapes, adapter class will handle converting shapes to make them fit the hole
    /// </summary>
    internal class RoundHole
    {
        public RoundHole(int n)
        {
            this.Radius = n;
        }

        private readonly int Radius;

        public int GetRadius()
        {
            return Radius;
        }

        public bool Fits(RoundPeg shape)
        {
            return this.GetRadius() >= shape.GetRadius();
        }
    }
}
