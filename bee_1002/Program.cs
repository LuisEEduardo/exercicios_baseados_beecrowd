using System;

namespace bee_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Insira o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());
            var area = CalculoDeAreaCirculo(raio);
            Console.WriteLine(string.Format("Valor da área => {0:F2}", area));
            Console.ReadKey();
            Console.Clear();
        }

        public static double CalculoDeAreaCirculo(double raio)
        {
            double pi = 3.14159;
            return pi * Math.Pow(raio, 2);
        }

    }
}
