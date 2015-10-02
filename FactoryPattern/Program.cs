using System;
using System.Collections.Generic;
using FactoryPattern.Factory;
using FactoryPattern.Interfaces;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var pilsen = BeerFactory.CreateBeer<IPilsen>();
            var weiss = BeerFactory.CreateBeer<IWeiss>();
            var stout = BeerFactory.CreateBeer<IStout>();

            var beers = new List<IBeer>();
            beers.Add((IBeer)pilsen);
            beers.Add((IBeer)weiss);
            beers.Add((IBeer)stout);

            foreach (var beer in beers)
                beer.Classificacao();

            Console.ReadLine();
        }
    }
}
