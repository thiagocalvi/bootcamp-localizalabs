using System;
using System.Collections.Generic;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            var caminho = "C:\\TrabalhandoComArquivos";
            var pathcombine = Path.Combine(caminho, "pastateste2");
            var caminhoarquivo = Path.Combine(caminho, "arquivo-teste-straem.txt");
            var caminhoarquivoteste = Path.Combine(caminho, "arquivo-teste.txt");
            var novocaminhoarquivo = Path.Combine(caminho, "pastateste2", "arquivo-teste-straem.txt");

            var listaString = new List<string> {"Linha 1", "Linha 2", "Lista 3"};
            var listaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Lista 6"};

            FileHelper Helper = new FileHelper();
            // Helper.ListarDiretorios(caminho);
            // Helper.ListarArquivosDiretorios(caminho);
            // System.Console.WriteLine("Criando diretorio" + pathcombine);
            // Helper.CriarDiretorio(pathcombine);
            // Helper.ApagarDiretorio(pathcombine, true);
            // Helper.CriarArquivoTexto(caminhoarquivo, "teste de escrita de arquivo");
            // Helper.CriarArquivoTextoStraem(caminho, listaString);
            // Helper.AdicionarTextoStraem(caminhoarquivo, listaStringContinuacao);
            // Helper.LerArquivoStraem(caminhoarquivo);
            // Helper.MoverArquivo(caminho, novocaminhoarquivo);
            // Helper.MoverArquivo(caminho, novocaminhoarquivo, false);
            Helper.DeletarArquivo(caminhoarquivoteste);


// ****************************************************************************************************


            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(1,3));


// ****************************************************************************************************


            // Computador c = new Computador();
            // c.ToString();


// ****************************************************************************************************

            // Corrente cr = new Corrente();
            // cr.Creditar(100);
            // cr.ExibirSaldo();


// ****************************************************************************************************


            //Calculadora calc = new Calculadora();
            //Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10,3));
            //Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10,3,10));


// ****************************************************************************************************


            // Aluno p1 = new Aluno();
            // p1.Nome = "Bob";
            // p1.Idade = 16;
            // p1.Nota = 10;
            // p1.Documento = "123456";
            // p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome = "Bob";
            // p2.Idade = 16;
            // p2.Salario = 1.087;
            // p1.Documento = "123456";
            // p1.Apresentar();


// ****************************************************************************************************


            // //valores valido
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30,30);
            // Console.WriteLine($"A área é de {r.ObterArea()}");

            // //valores invalido
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0,0);
            // Console.WriteLine($"A área é de {r2.ObterArea()}");


// ****************************************************************************************************


            // //cria a classe Pessoa e a chama de p1
            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // //executa o metodo Apresentar
            // p1.Apresentar();
        }
    }
}
