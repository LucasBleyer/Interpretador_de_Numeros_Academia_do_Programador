using System;
using System.IO;

namespace InterpretadorDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeros = @"
                     __  __        __   __  __   __   __   __ 
                  |  __| __| |__| |__  |__    | |__| |__| |  |
                  | |__  __|    |  __| |__|   | |__|  __| |__|
            ";

            string entradas = @"
                  __   __ __   __   __      __  __
                 |__  |__   | |__| |__|   | __| __||__|  
                  __| |__|  | |__|  __|   ||__  __|    |      
            ";

            StringReader linhas = new StringReader(entradas);
            linhas.ReadLine();
            string linha1 = linhas.ReadLine();
            Console.WriteLine("Linha 1: "+linha1);
            string linha2 = linhas.ReadLine();
            Console.WriteLine("Linha 2: " + linha2);
            string linha3 = linhas.ReadLine();
            Console.WriteLine("Linha 3: " + linha3);

        }
    }
}
