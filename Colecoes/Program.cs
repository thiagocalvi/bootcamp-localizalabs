using System;
using System.Collections;
using System.Collections.Generic;
using Colecoes.Helper;
using System.Linq;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ
            //Language-Integrate Query é uma maneira de vc utilizar uma sintaxe de consulta padronizada
            //para coleção de Objetos

            int[] arrayNumeros = new int[10] {5, 100, 21, 11, 8, 100, 0, 5, 21, 10};

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var media = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var destintos = arrayNumeros.Distinct().ToArray();

            System.Console.WriteLine($"Minimo {minimo}");
            System.Console.WriteLine($"Maximo {maximo}");
            System.Console.WriteLine($"Media {media}");
            System.Console.WriteLine($"Soma {soma}");
            System.Console.WriteLine($"Destintos {string.Join(", ", destintos)}");

            // var numerosParesQuery = 
            //     from num in arrayNumeros
            //     where num % 2 == 0
            //     orderby num
            //     select num;

            // var numerosParesMetodos = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            // System.Console.WriteLine($"Numeros parares Query : {string.Join(", ", numerosParesQuery)}");    
            // System.Console.WriteLine($"Numeros parares Metodo : {string.Join(", ",  numerosParesMetodos)}");

            //DIcionarios é uma coleção de chave e valor, permite que vc recupere rapidamente seus itens 
            //Baseado em sua chave - armazena sua chave em hash
            //Declaração Dictionary<string, string> estado = new Dictionary<string, string>();
            // Dictionary<string, string> estado = new Dictionary<string, string>();
            // estado.Add("SP", "São Paulo");
            // estado.Add("MG", "Minas Gerais");
            // estado.Add("BA", "Bahia");

            // foreach (KeyValuePair<string, string> item in estado)
            // {
            //     System.Console.WriteLine($"Chave : {item.Key}, Valor : {item.Value}");
            // }

            // string valorProcurado = "BA";

            // if (estado.TryGetValue(valorProcurado, out string estadoEncomtrado))
            // {
            //     System.Console.WriteLine(estadoEncomtrado);
            // }
            // System.Console.WriteLine($"{valorProcurado} não existe no dicionario");
        
            
            // System.Console.WriteLine($"Removendo a valor {valorProcurado}");
            // estado.Remove(valorProcurado);

            // foreach (KeyValuePair<string, string> item in estado)
            // {
            //     System.Console.WriteLine($"Chave : {item.Key}, Valor : {item.Value}");
            // }


            // System.Console.WriteLine("Valor Original:");
            // System.Console.WriteLine($"Estados {estado[valorProcurado]}");

            // estado[valorProcurado] = "BA - Teste atualização";

            // System.Console.WriteLine("Valor atualizado:");
            // System.Console.WriteLine($"Estados {estado[valorProcurado]}");



            // Stack<string> pilha = new Stack<string>();
            // pilha.Push(".NET");
            // pilha.Push("DDD");
            // pilha.Push("Código limpo");
            
            // System.Console.WriteLine($"Total de livros : {pilha.Count}");

            // while (pilha.Count > 0)
            // {
            //     System.Console.WriteLine($"Proximo livro : {pilha.Peek()}");
            //     System.Console.WriteLine($"{pilha.Pop()} lido");
            // }
            // System.Console.WriteLine($"Total de livros : {pilha.Count}");

            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("Leonardo");
            // fila.Enqueue("Eduardo");
            // fila.Enqueue("Andre");

            // System.Console.WriteLine($"Pessoas na fila {fila.Count}");

            // while (fila.Count > 0)
            // {
            //     System.Console.WriteLine($"Vesde {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()} atendido");
            // }
            // System.Console.WriteLine($"Pessoas na fila {fila.Count}");

            // OperacoesLista opLista = new OperacoesLista();

            // List<string> estados = new List<string>{"SP", "MG", "BA"};
            // string[] estadosArray = new string[2] {"SC", "MT"};
            

            //Console.WriteLine($"Quantidade de elementos na lista {estados.Count}");

            // opLista.ImprimirListaString(estados);
            // estados.Remove("MG");

            // estados.AddRange(estadosArray);
            // estados.Insert(1, "RJ");
            // System.Console.WriteLine();
            // opLista.ImprimirListaString(estados);

            // OperacoesArray op = new OperacoesArray();
            
            // int[] array = new int[7] { 6, 3, 9, 2, 5, 49, 78 };
            
            // Console.WriteLine("Array de inteiros");
            // op.ImprimirArray(array);

            // string[] arrayStr = op.ConverterParaArrayString(array);

            // Console.WriteLine("Array convertido para string");
            // op.ImprimirArray(arrayStr);


            
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
