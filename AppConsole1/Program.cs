using AppConsole1.MinhasClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro palio = new Carro();
            palio.Chassi = "123123123123123123123123123";
            palio.Fabricante = "Fiat";
            palio.QuatidadePortas = 4;
            palio.CorPredominante = "Vermelha";

            Caminhao volvo = new Caminhao();
            volvo.TipoBoleia = "sim";

            Motocicleta susuki = new Motocicleta();
            susuki.ContemSideCar = false;
            susuki.CorPredominante = "Amarela";

            CarroAnfibio sapinho = new CarroAnfibio();
            sapinho.Fabricante = "Tesla";
            sapinho.Chassi = "11111111111111";
            sapinho.CorPredominante = "Verde";
            sapinho.QuatidadePortas = 2;
            sapinho.QuantidadeRemos = 4;

            Console.WriteLine("Fabricante: {0} - Portas: {1}", palio.Fabricante, palio.QuatidadePortas);
            Console.Read();

        }
    }
}
