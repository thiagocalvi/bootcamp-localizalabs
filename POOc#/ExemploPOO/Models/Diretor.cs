//bootcamp Localiza 
//---26/01/2022---
namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá eu sou o diretor {Nome}");
        }
    }
}