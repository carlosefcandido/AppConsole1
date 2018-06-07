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
            var palio = new Carro();
            palio.Chassi = "123123123123123123123123123";
            palio.Fabricante = "Fiat";

            Console.WriteLine(palio.Fabricante);
            Console.Read();

        }
    }
}
