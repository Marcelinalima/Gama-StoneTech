using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2

{      // na interface usamos os metodos

    public interface IFabrica
    {
        
        Veiculo CriarVeiculo (string tipo);

        //Temos as definicoes e paramentros para os metodos ,cabecalhos mas nao temos os corpos mas nao temos o corpo
    }   //Os corpos precisam se definidos pelos tipos que implementam eles
}
