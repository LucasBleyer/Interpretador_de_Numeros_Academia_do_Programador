using System;
using System.IO;

namespace InterpretadorDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entradas = @"
             __  __ __   __  __      __  __     
            |__ |__   | |__||__|   | __| __||__|
             __||__|  | |__| __|   ||__  __|   |

             __      __  __      __  __  __  __ 
             __||__|   ||__|   | __||__ |__ |__|
             __|   |   ||__|   ||__  __||__| __|

             __  __  __  __  __       __  __    
             __| __||__ |__ |__| |__|   ||__|  |
             __||__  __||__| __|    |   ||__|  |

             __  __  __  __  __  __      __     
            |  | __||__ |__    ||__|   ||__||__|
            |__||__  __||__|   ||__|   |   |   |
            ";

            StringReader linhas = new StringReader(entradas);
            linhas.ReadLine();

            Console.WriteLine("Entrada:");

            string linha1 = linhas.ReadLine();
            Console.WriteLine(linha1);
            string linha2 = linhas.ReadLine();
            Console.WriteLine(linha2);
            string linha3 = linhas.ReadLine();
            Console.WriteLine(linha3);
            linhas.ReadLine();

            string linha4 = linhas.ReadLine();
            Console.WriteLine(linha4);
            string linha5 = linhas.ReadLine();
            Console.WriteLine(linha5);
            string linha6 = linhas.ReadLine();
            Console.WriteLine(linha6);
            linhas.ReadLine();

            string linha7 = linhas.ReadLine();
            Console.WriteLine(linha7);
            string linha8 = linhas.ReadLine();
            Console.WriteLine(linha8);
            string linha9 = linhas.ReadLine();
            Console.WriteLine(linha9);
            linhas.ReadLine();

            string linha10 = linhas.ReadLine();
            Console.WriteLine(linha10);
            string linha11 = linhas.ReadLine();
            Console.WriteLine(linha11);
            string linha12 = linhas.ReadLine();
            Console.WriteLine(linha12);
            linhas.ReadLine();

            Console.WriteLine("\r\n------------------------------------------------------------");

            Console.WriteLine("\r\nSaída:");

        }
    }
}
