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

            char[] l1 = linha1.ToCharArray();
            char[] l2 = linha2.ToCharArray();
            char[] l3 = linha3.ToCharArray();
            char[] l4 = linha4.ToCharArray();
            char[] l5 = linha5.ToCharArray();
            char[] l6= linha6.ToCharArray();
            char[] l7 = linha7.ToCharArray();
            char[] l8 = linha8.ToCharArray();
            char[] l9 = linha9.ToCharArray();
            char[] l10 = linha10.ToCharArray();
            char[] l11 = linha11.ToCharArray();
            char[] l12 = linha11.ToCharArray();

            Console.WriteLine("\r\n------------------------------------------------------------");
            Console.WriteLine("\r\nSaída:");

            
        }
    }
}