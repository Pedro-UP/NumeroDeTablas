using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablasdeMultiplicar
{
    class Program
    {
        static int tabla, n;
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el Numero de Tablas");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine("Tabla del :" + i);

                

                for (int x = 1; x <= 10; x++)
                {

                    tabla = x * i;

                    Console.WriteLine("{0} * {1} es :{2}", i, x, tabla);
                }
            }
            Console.ReadLine();
        }
    }
}
