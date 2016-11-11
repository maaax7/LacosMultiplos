using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosMultiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            for(int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine("Soma dos numeros de 1 a 100 não multiplos de 3: " + soma);

            Console.ReadKey();
        }
    }
}
