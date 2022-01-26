//Herda de Pessoa, Polimorfismo e classe Selada 
//bootcamp Localiza 
//---26/01/2022---
namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

         public override void Apresentar()
        {
            System.Console.WriteLine($"Olá meu nome é {Nome} sou professor e recebo {Salario}");
        }
    }
}