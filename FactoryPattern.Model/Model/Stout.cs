using FactoryPattern.Interfaces;
using System;

namespace FactoryPattern.Model
{
    public class Stout : Beer, IStout
    {
        public override void Classificacao()
        {
            base.Classificacao();
            Console.WriteLine("Escura");
        }
    }
}
