using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baze;
            int altura;
            int area;

            Console.Write("Informe o valor da base do retângulo: ");
            baze = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor do retângulo:");
            altura = int.Parse(Console.ReadLine());

            area = baze * altura;

            Console.WriteLine("O valor da área e um retângulo que tem base de {0} e altura de {1} é {2}", baze, altura, area);

        }
    }
}
