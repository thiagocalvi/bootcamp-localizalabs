//Herança e Polimorfismo
//bootcamp Localiza 
//---26/01/2022---
namespace ExemploPOO.Models
{
    public class Aluno : Pessoa 
    {
        public int Nota { get; set; }

        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá meu nome é {Nome} sou um aluno nota {Nota} e tenho {Idade} anos");
        }
    }
}