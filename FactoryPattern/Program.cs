using System;
﻿using System.Linq;
using System.Collections.Generic;
using FactoryPattern.Factory;
using FactoryPattern.Interfaces;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var beers = new List<IBeer>();
            beers.Add((IBeer)BeerFactory.CreateBeer<IPilsen>());
            beers.Add((IBeer)BeerFactory.CreateBeer<IWeiss>());
            beers.Add((IBeer)BeerFactory.CreateBeer<IStout>());

            beers.Foreach(x => x.Classificacao());

            Console.ReadLine();
        }
    }
}
