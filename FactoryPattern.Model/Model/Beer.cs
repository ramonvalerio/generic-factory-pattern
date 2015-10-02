using System;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Model
{
    public abstract class Beer : IBeer
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public virtual void Classificacao()
        {
            Console.WriteLine("Classificação:");
        }
    }
}