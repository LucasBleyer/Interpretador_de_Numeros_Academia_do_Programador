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
            ";

            StringReader linhas = new StringReader(entradas);
            linhas.ReadLine();

            Console.WriteLine("Entrada:");
            string linha1, linha2, linha3, linha4;

            LeitorDeTodasAsLinhas(linhas, out linha1, out linha2, out linha3, out linha4);

            ConverteTodasAsLinhasArrayChar(linha1, linha2, linha3, linha4);

            Console.WriteLine("\r\n------------------------------------------------------------");
            Console.WriteLine("\r\nSaída:");

            String conj_caracteres1 = " ", conj_caracteres2 = " ", conj_caracteres3 = " ";

            for (int i = 0; i < linha1.Length; i++)
            {
                conj_caracteres1 += linha1[i];
                conj_caracteres2 += linha2[i];
                conj_caracteres3 += linha2[i];

                
            }

        }
        #region Métodos

        private static void LeitorDeTodasAsLinhas(StringReader linhas, out string linha1, out string linha2, out string linha3, out string linha4)
        {
            linha1 = linhas.ReadLine();
            Console.WriteLine(linha1);
            linha2 = linhas.ReadLine();
            Console.WriteLine(linha2);
            linha3 = linhas.ReadLine();
            Console.WriteLine(linha3);
            linhas.ReadLine();

            linha4 = linhas.ReadLine();
            Console.WriteLine(linha4);
            linha5 = linhas.ReadLine();
            Console.WriteLine(linha5);
            linha6 = linhas.ReadLine();
            Console.WriteLine(linha6);
            linhas.ReadLine();

            linha7 = linhas.ReadLine();
            Console.WriteLine(linha7);
            linha8 = linhas.ReadLine();
            Console.WriteLine(linha8);
            linha9 = linhas.ReadLine();
            Console.WriteLine(linha9);
            linhas.ReadLine();

            linha10 = linhas.ReadLine();
            Console.WriteLine(linha10);
            linha11 = linhas.ReadLine();
            Console.WriteLine(linha11);
            string linha12 = linhas.ReadLine();
            Console.WriteLine(linha12);
            linhas.ReadLine();
        }
        private static void ConverteTodasAsLinhasArrayChar(string linha1, string linha2, string linha3, string linha4)
        {
            char[] l1 = linha1.ToCharArray();
            char[] l2 = linha2.ToCharArray();
            char[] l3 = linha3.ToCharArray();
            char[] l4 = linha4.ToCharArray();
            char[] l5 = linha5.ToCharArray();
            char[] l6 = linha6.ToCharArray();
            char[] l7 = linha7.ToCharArray();
            char[] l8 = linha8.ToCharArray();
            char[] l9 = linha9.ToCharArray();
            char[] l10 = linha10.ToCharArray();
            char[] l11 = linha11.ToCharArray();
            char[] l12 = linha11.ToCharArray();
        }
       

        #endregion
    }
}