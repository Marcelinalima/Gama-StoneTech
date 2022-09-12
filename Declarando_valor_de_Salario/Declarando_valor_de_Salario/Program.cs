using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declarando_valor_de_Salario
{
    internal class Program
    {      // exercicio anterior do 26/08
        
            // Salario 2500 
            // 22 dias de trabalho ao mês
            // 8 horas por dia = 176 horas de trabalho ao mês.
            // 12 meses ao ano.

            static void Main(string[] args)
            {
                string Pessoa;
                double Salario;
                Console.WriteLine("Favor digite nome do Funcionario:");
                Pessoa = Console.ReadLine();
                Console.WriteLine("Olá colaborador por favor digite seu salario mensal:");
                Salario = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Qual valor o funcionario ganha por hora- digite h");
                Console.WriteLine("Qual valor o funcionario ganha por dia - digite d");
                Console.WriteLine("Qual valor o funcionario ganha por semana - digite s");
                Console.WriteLine("Qual valor o funcionario ganha por ano - digite a");

                switch (Console.ReadLine())

                {
                    case "h":
                        Console.WriteLine($"seu salario por hora é de" + (Salario / 176));
                        break;

                    case "d":
                        Console.WriteLine($"seu salario por dia é de" + (Salario / 22));
                        break;

                    case "s":
                        Console.WriteLine($"seu salario por semana é de" + (Salario / 4));
                        break;

                    case "a":
                        Console.WriteLine($"seu salario por ano é de" + (Salario * 12));
                        break;

                }
                int h = 2500 / 176;
                int d = 2500 / 22;
                int s = 2500 / 4;
                int a = 2500 * 12;

                Console.WriteLine($"h = {h}, d = {d} , s ={s}, a = {a}");


                Console.Write("Precione qualquer tecla para fechar o aplicativo");
                Console.ReadKey();
            }

    }
}


  
