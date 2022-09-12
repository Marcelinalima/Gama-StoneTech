using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_exercicios
{
    public class Carro
    {
        static void Main(string[] args)
        {
           
            List<Carro> carros = new List<Carro>();

            carros.Add(new Carro());
            carros.Add(new Carro());
            carros.Add(new Carro());

            List<Carro> carros2 = new List<Carro>();
          
            Console.WriteLine(carros.Count);
            Console.ReadLine();
        }
    }
}
