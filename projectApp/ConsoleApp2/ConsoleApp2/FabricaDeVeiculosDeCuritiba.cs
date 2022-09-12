using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
      public class FabricaDeVeiculosDeCuritiba : IFabrica
      {
        
      public Veiculo CriarVeiculo(string tipo)
      {  
            if (tipo =="carro")
                return new Carro() { modelo="Civic"};

             if (tipo == "moto")
                return new Moto();
              

            return new Veiculo();
      }
      } 
}
