using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {

        public delegate void Operacao(int x, int y);


        static void Main(string[] args)
        {

            Matematica m = new Matematica(10, 10);
            m.Somar();











            //Operacao op = Calculadora.Somar;
            // Operacao op = new Operacao(Calculadora.Somar);
            //Adicionando mais um metodo sem perder a referencia anterior
            //op += Calculadora.Subtrair;
            //op.Invoke(10, 10);
            //op(10, 10);
            

            















            // Data d = new Data();
            //d.SetMes(2);

            // d.Mes = 12;
            // System.Console.WriteLine(d.Mes);

            // d.ApresentarMes();
            // Aluno p1 = new Aluno("Bob", "Fost", "Matematica");
            // p1.Apresentar();















            // Log log = Log.GetInstance();
            // log.PropiedadeLog = "Teste de instancia";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropiedadeLog);









        }
    }
}
