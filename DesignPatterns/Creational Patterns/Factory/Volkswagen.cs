﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Factory
{
    internal class Volkswagen: ICar
    {
        public void Drive()
        {
            Console.WriteLine("You're driving a volkswagen");
        }
    }
}
