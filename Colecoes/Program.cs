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
            
            Console.WriteLine("Array de inteiros");
            op.ImprimirArray(array);

            string[] arrayStr = op.ConverterParaArrayString(array);

            Console.WriteLine("Array convertido para string");
            op.ImprimirArray(arrayStr);


            
            // Console.WriteLine($"Capacidade do array atualmete {array.Length}");

            // op.RedimensionarArray(ref array, array.Length * 2);
            
            // Console.WriteLine($"Capacidade do array apos redimensionar {array.Length}");
            
            
            // int[] arrayCopy = new int[10];

            // int ValorProcurado = 78;

            // var Indice = op.ObterIndice(array, ValorProcurado);

            // if(Indice != -1)
            // {
            //     Console.WriteLine($"Valor {ValorProcurado} encontrado na posição {Indice}");
            // }
            // else
            // {
            //     Console.WriteLine($"Valor {ValorProcurado} não existe no Array");
            // }


            // Console.WriteLine("Informe o valor a ser procurado");
            // var ValorProcurado = Console.ReadLine();

            // int ValorObtido = op.ObterValor(array, int.Parse(ValorProcurado));

            // if (ValorObtido > 0)
            // {
            //     Console.WriteLine("Encontrei o valor");
            // }
            // else
            // {
            //     Console.WriteLine("Não encontrei o valor");
            // }

            // Console.WriteLine("Informe o valor para verificar");
            // var valorVerifica = Console.ReadLine();

            // bool verdadeiro = op.TodosMaiorQue(array, int.Parse(valorVerifica));

            // if (verdadeiro)
            // {
            //     System.Console.WriteLine("Condição verdadeira");
            // }
            // else
            // {
            //     System.Console.WriteLine("Condição falsa");
            // }



            // Console.WriteLine("Informe o valor a ser buscado");
            // var valorBuscado = Console.ReadLine();

            // bool existe = op.Existe(array, int.Parse(valorBuscado));

            // if (existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor");
            // }


            // System.Console.WriteLine("Array antes da copia");
            // op.ImprimirArray(arrayCopy);

            // op.Copiar(ref array, ref arrayCopy);

            // System.Console.WriteLine("Array apos a copia");
            // op.ImprimirArray(arrayCopy);


            // System.Console.WriteLine("Array original");
            // op.ImprimirArray(array);

            // op.OrdenarBubbleSort(ref array);
            // op.Ordenar(ref array);

            // System.Console.WriteLine("Array ordenado");
            // op.ImprimirArray(array);




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
