using System;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo R = new Retangulo();
            Console.WriteLine("Entre com a Largura, Altura do retângulo: ");

            Console.WriteLine("--------------------------");
            Console.Write("Largura: ");
            double Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("--------------------------");
            Console.Write("Altura: ");
            double Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            R.CalcularRetangulo(Largura, Altura);

            Console.WriteLine("--------------------------");
            Console.WriteLine(R);
        }
    }
}
