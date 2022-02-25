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
            string linha1, linha2, linha3;

            LeitorDeTodasAsLinhas(linhas, out linha1, out linha2, out linha3);

            char[] l1 = ConverteLinhasEmArrayChar(linha1, linha2, linha3);

            Console.WriteLine("\r\n------------------------------------------------------");
            Console.WriteLine("\r\nSaída:");

            String conj_caracteres1 = "", conj_caracteres2 = "", conj_caracteres3 = "";

            for (int i = 0; i < l1.Length; i++)
            {
                conj_caracteres1 += linha1[i];
                conj_caracteres2 += linha2[i];
                conj_caracteres3 += linha3[i];

                if (conj_caracteres1 == " __ " && conj_caracteres2 == "|  |" && conj_caracteres3 == "|__|")
                {
                    Console.Write("0");
                    ResetarConjuntos(out conj_caracteres1, out conj_caracteres2, out conj_caracteres3);
                }

                if (conj_caracteres1 == "    " && conj_caracteres2 == "   |" && conj_caracteres3 == "   |")
                {
                    Console.Write("1");
                    ResetarConjuntos(out conj_caracteres1, out conj_caracteres2, out conj_caracteres3);
                }

                if (conj_caracteres1 == " __ " && conj_caracteres2 == " __|" && conj_caracteres3 == "|__ ")
                {
                    Console.Write("2");
                    ResetarConjuntos(out conj_caracteres1, out conj_caracteres2, out conj_caracteres3);
                }

                if (conj_caracteres1 == " __ " && conj_caracteres2 == " __|" && conj_caracteres3 == " __|")
                {
                    Console.Write("3");
                    ResetarConjuntos(out conj_caracteres1, out conj_caracteres2, out conj_caracteres3);
                }

                if (conj_caracteres1 == "    " && conj_caracteres2 == "|__|" && conj_caracteres3 == "   |")
                {
                    Console.Write("4");
                    ResetarConjuntos(out conj_caracteres1, out conj_caracteres2, out conj_caracteres3);
                }
                if (conj_caracteres1 == " __ " && conj_caracteres2 == "|__ " && conj_caracteres3 == " __|")
                {
                    Console.Write("5");
                    ResetarConjuntos(out conj_caracteres1, out conj_caracteres2, out conj_caracteres3);
                }
                if (conj_caracteres1 == " __ " && conj_caracteres2 == "|__ " && conj_caracteres3 == "|__|")
                {
                    Console.Write("6");
                    ResetarConjuntos(out conj_caracteres1, out conj_caracteres2, out conj_caracteres3);
                }
                if (conj_caracteres1 == "__  " && conj_caracteres2 == "  | " && conj_caracteres3 == "  | ")
                {
                    Console.Write("7");
                    ResetarConjuntos(out conj_caracteres1, out conj_caracteres2, out conj_caracteres3);
                }
                if (conj_caracteres1 == " __ " && conj_caracteres2 == "|__|" && conj_caracteres3 == "|__|")
                {
                    Console.Write("8");
                    ResetarConjuntos(out conj_caracteres1, out conj_caracteres2, out conj_caracteres3);
                }
                if (conj_caracteres1 == " __ " && conj_caracteres2 == "|__|" && conj_caracteres3 == " __|")
                {
                    Console.Write("9");
                    ResetarConjuntos(out conj_caracteres1, out conj_caracteres2, out conj_caracteres3);
                }
            }
            Console.ReadLine();
        }

        #region Métodos
        private static void LeitorDeTodasAsLinhas(StringReader linhas, out string linha1, out string linha2, out string linha3)
        {
            linha1 = linhas.ReadLine();
            Console.WriteLine(linha1);
            linha2 = linhas.ReadLine();
            Console.WriteLine(linha2);
            linha3 = linhas.ReadLine();
            Console.WriteLine(linha3);

        }
        private static void ResetarConjuntos(out string conj_caracteres1, out string conj_caracteres2, out string conj_caracteres3)
        {
            conj_caracteres1 = "";
            conj_caracteres2 = "";
            conj_caracteres3 = "";
        }
        private static char[] ConverteLinhasEmArrayChar(string linha1, string linha2, string linha3)
        {
            char[] l1 = linha1.ToCharArray();
            char[] l2 = linha2.ToCharArray();
            char[] l3 = linha3.ToCharArray();
            return l1;
        }

        #endregion
    }
}