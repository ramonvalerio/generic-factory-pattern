using System;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Model
{
    public class Weiss : Beer, IWeiss
    {
        public override void Classificacao()
        {
            base.Classificacao();
            Console.WriteLine("Forte");
        }
    }
}
