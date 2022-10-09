using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Factory
{
    /// <summary>
    /// Factory pattern is a creational pattern that allows you to create an interface for creating object in base class, simultaneously the subclasses can modify the type of object that will be created.
    /// </summary>
    public abstract class CarFactory
    {
        public abstract ICar ProduceCar();
    }
}
