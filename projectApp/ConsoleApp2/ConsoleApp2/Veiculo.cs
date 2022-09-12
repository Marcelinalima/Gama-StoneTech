using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public class Veiculo
    {
        public int numeroDeRodas;
        public string modelo;
        public int numeroDePortas;
        public int velocidade = 0;
        public bool ligado = false;

        public void Acelerar(int velocidadeAMais)
        {
            velocidade += velocidadeAMais;
            Console.WriteLine("velocidade:" + velocidade + "km/h");
        }
        public void Freiar()
        {
            velocidade -= 10;
            if (velocidade < 0)
            {
                velocidade = 0;
            }
            Console.WriteLine("velocidade:" + velocidade + "km/h");
        }
        public void Ligar()
        {
            ligado = true;
        }

        public void Desligar()
        {
            ligado = false;
        }



    }
}
    

