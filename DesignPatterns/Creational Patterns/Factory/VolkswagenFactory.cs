using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Factory
{
    internal class VolkswagenFactory:CarFactory
    {
        public override ICar ProduceCar()
        {
            return new Volkswagen();
        }
    }
}
