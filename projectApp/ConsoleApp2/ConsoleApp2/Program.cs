using System;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string [] args)
        {
            IFabrica fabrica = new FabricaDeVeiculosDeSaoPaulo);

            var veiculo = fabrica.CriarVeiculo("carro");

            Console.WriteLine(veiculo.modelo);  

            Console.ReadLine();
        }
        
        public static Veiculo GetCarro(IFabrica fabrica)
        {
            return fabrica.CriarVeiculo("carro");
        }

    }
}

