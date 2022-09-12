using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario_Salario
{
    internal class Program
    {
        
        
            static void Main(string[] args)

            {// Variaveis para entrar com os numeros
                int hora, dia, mes, ano;

                //Solicitar os numeros
                Console.WriteLine("Insira um número");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira outro número");
                num2 = Convert.ToInt32(Console.ReadLine());
                // Mostrar menu de opcoes
                Console.WriteLine(("Escolha uma opção da lista"));
                Console.WriteLine("a - Adição");
                Console.WriteLine("s - Subtração");
                Console.WriteLine("m - multiplicação");
                Console.WriteLine("d - divisao");

                //Realizar a ação de acordo com a opção escolhida
                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine($"O resulado de {num1} + {num2} = " + (num1 + num2));
                        break;
                    case "s":
                        Console.WriteLine($"O resuldo de {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "m":
                        Console.WriteLine($"O resuldo de {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "d":
                        Console.WriteLine($"O resuldo de {num1} / {num2} = " + (num1 / num2));
                        break;

                }
                Console.Write("Pressione qq tecla para fechar o aplicativo");
                Console.ReadKey();
            }
        }
    }
}
