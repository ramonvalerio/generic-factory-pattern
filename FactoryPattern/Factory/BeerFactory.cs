using System;
using System.Linq;
using System.Reflection;

namespace FactoryPattern.Factory
{
    public static class BeerFactory
    {
        public static T CreateBeer<T>()
        {
            string caminho = string.Format("{0}{1}FactoryPattern.Model.dll", Environment.CurrentDirectory, @"\..\..\..\FactoryPattern.Model\bin\Debug\");
            Assembly assembly = Assembly.LoadFile(caminho);

            return (T)Activator.CreateInstance(assembly.GetTypes().Where(x => typeof(T).IsAssignableFrom(x) && !x.IsAbstract).SingleOrDefault(x => !x.IsInterface));
        }
    }
}
