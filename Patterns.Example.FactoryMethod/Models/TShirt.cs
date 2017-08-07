﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Example.FactoryMethod.Models
{
    public class Shirt : IClothes
    {
        public void PrintClothes()
        {
            Console.WriteLine("Shirt");
        }
    }
}
