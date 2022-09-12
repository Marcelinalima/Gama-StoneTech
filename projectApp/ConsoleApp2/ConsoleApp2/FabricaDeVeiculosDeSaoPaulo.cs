using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{  
    
     public class FabricaDeVeiculosDeSaoPaulo : IFabrica 
     {

        public  Carro CriaCarro()
        {
            return new Carro();
            { 
                modelo = "320i"
            };
        }   

        public Veiculo CriarVeiculo(string tipo)
        {
            return new Carro();
            { 
                modelo = "320i"
            };
        }
     }
}
