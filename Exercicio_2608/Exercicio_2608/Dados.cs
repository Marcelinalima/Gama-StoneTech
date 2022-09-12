using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2608
{
    public class Dados
    {
        public string nome;
        public string documento;
        public string endereço;
    }
    public void alterarnome(string nome)
    {
        Console.WriteLine("\n Qual seu nome = " + nome);
    }
    public void alterardocumento(string documento)
    {
        Console.WriteLine("Por favor, digite os dados de seu documento = " + documento);
    }
    public void alterarendereço(string endereço)
    {
        Console.WriteLine("Qual é o endereço = " + endereço);

    }

}
