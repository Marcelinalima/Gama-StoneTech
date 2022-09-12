using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario_calculos2608
{
    internal class Program
    { //Jornada de trabalho de 48 horas semanais. (48 horas ÷ 6 dias da semana) x 30 dias no mês = 240 horas.
        static void Main(string[] args)
        {
            string Pessoa;
            double Salario;
            double Horas;
            Console.WriteLine("Favor digite nome do Funcionario:");
            Pessoa = Console.ReadLine();
            Console.WriteLine("Olá colaborador por favor digite seu salario mensal:");
            Salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Olá, digite quantas horas voce trabalha por dia:");
            Horas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Horas trabalhadas por semana - digite h");
            Console.WriteLine("Qual valor o funcionario ganha por dia - digite d");
            Console.WriteLine("Qual valor o funcionario ganha por semana - digite s");
            Console.WriteLine("Qual valor o funcionario ganha por ano - digite a");

            switch (Console.ReadLine())

            {
                case "h":
                    Console.WriteLine($"Horas trabalhadas semana é " + (Horas * 6));
                    break;

                case "d":
                    Console.WriteLine($"seu salario por dia é de" + (Salario / 30));
                    break;

                case "s":
                    Console.WriteLine($"seu salario por semana é de" + (Salario / 4));
                    break;

                case "a":
                    Console.WriteLine($"seu salario por ano é de" + (Salario * 12));
                    break;

            }
            int h = 240  / 4 ;
            int d = 2500 / 30;
            int s = 2500 / 4;
            int a = 2500 * 12;

            Console.WriteLine($"h = {h}, d = {d} , s ={s}, a = {a}");

            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Precione qualquer tecla para fechar o aplicativo");
            Console.ReadKey();

            

        }

    }
}

