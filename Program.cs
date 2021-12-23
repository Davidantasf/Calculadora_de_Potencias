using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFor
{
    class Program
    {
        static void Main(string[] args)
        { 
            int potencia = 2;
            int numero = 5;
            int r = 1;
            for (int i = 1; i <= potencia; i++ )
            {
                r *= numero;
            }
            Console.WriteLine(r);

            Console.ReadLine();
        }
    }
}
