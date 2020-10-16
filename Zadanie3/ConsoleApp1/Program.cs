using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] tabPoszarpana = TablicaPoszarpana();
            var suma = TablicaSuma(tabPoszarpana);
            Print(tabPoszarpana);
            Console.WriteLine("Suma: {0}", suma);
            
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            var tekst1 = (ti.ToTitleCase(Console.ReadLine())).PadRight(6, '.');
            Console.WriteLine(tekst1);            
        }

        private static int TablicaSuma(int[][] tabPoszarpana)
        {
            var suma = 0;
            for (int i = 0; i < tabPoszarpana.Length; i++)
            {
                for (int j = 0; j < tabPoszarpana[i].Length; j++)
                {
                    suma += tabPoszarpana[i][j];
                }
            }

            return suma;
        }

        private static void Print(int[][] tabPoszarpana)
        {
            for (int i = 0; i < tabPoszarpana.Length; i++)
            {
                for (int j = 0; j < tabPoszarpana[i].Length; j++)
                {
                    Console.Write("{0,4}", tabPoszarpana[i][j]);
                }

                Console.WriteLine();
            }
        }

        private static int[][] TablicaPoszarpana()
        {
            int[][] tab = new int[3][];

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = new int[5];
                for (int j = 0; j < tab[i].Length; j++)
                {
                    tab[i][j] = i + j;
                }
            }

            return tab;
        }
    }
}