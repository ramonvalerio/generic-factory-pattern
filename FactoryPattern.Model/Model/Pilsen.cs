using FactoryPattern.Interfaces;
using System;

namespace FactoryPattern.Model
{
    public class Pilsen : Beer, IPilsen
    {
        public override void Classificacao()
        {
            base.Classificacao();
            Console.WriteLine("Leve");
        }
    }
}
