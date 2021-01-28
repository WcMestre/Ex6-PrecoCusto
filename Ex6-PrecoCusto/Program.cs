using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_PrecoCusto
{
    class Program
    {
        static void Main(string[] args)
        {
            int custo, percentual, valorfinal;

            Console.WriteLine("Digite o custo: ");
            custo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o percentual: ");
            percentual = int.Parse(Console.ReadLine());

            valorfinal = (custo * percentual)/100;
            valorfinal = valorfinal + custo;

            Console.WriteLine("O valor final é: " + valorfinal);
            Console.ReadKey();
        }
    }
}
