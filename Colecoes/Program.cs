using System;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[7] { 6, 3, 9, 2, 5, 49, 78 };

            System.Console.WriteLine("Array original");
            op.ImprimirArray(array);

            op.OrdenarBubbleSort(ref array);

            System.Console.WriteLine("Array ordenado");
            op.ImprimirArray(array);




            // int[,] matriz = new int[4, 2] 
            // {
            //     { 8, 8 },
            //     { 10, 20 },
            //     { 50, 100 },
            //     { 90, 200 }
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int n = 0; n < matriz.GetLength(1); n++)
            //     {
            //         Console.WriteLine($"Coluna {n}, Linha {i} : {matriz[i,n]}");
            //     }
            // }

            // matriz[0, 0] = 10;
            // Console.WriteLine(matriz[0,0]);



            // int[] arrayInteiros = new int[3];
            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = int.Parse("30");



            // for (int i=0; i < arrayInteiros.Length; i++)
            // {
            //    Console.WriteLine($"{arrayInteiros[i]}");
            // }

            // foreach (int item in arrayInteiros)
            // {
            //     Console.WriteLine($"{item}");
            // }

            // for (int i = arrayInteiros.Length - 1; i >= 0 ; i--)
            // {
            //     Console.WriteLine($"{arrayInteiros[i]}");
            // }
        }
    }
}
