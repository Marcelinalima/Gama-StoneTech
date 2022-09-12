using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2608
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pessoa_fisica pessoa_fisica = new pessoa_fisica();
            pessoa_fisica.nome =("") ;
            Console.Write("Olá diga seu nome");
            pessoa_fisica.endereço = "Rua das Gaivotas, 350 - CEP: 785 -056-750";
            Console.Write("Meu endereço é:" + pessoa_fisica.endereço);
            pessoa_fisica.Documento = " Indentidade,CPF,Carteira de trabalho";

            Console.ReadLine();

        }

    }
}
