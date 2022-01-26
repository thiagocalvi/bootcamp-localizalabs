//Construtores, Readonly
//bootcamp Localiza
//-----26/01/2022-----
namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private readonly string Nome = "leo";
        private readonly string SobreNome;

        public Pessoa()
        {
            Nome = string.Empty;
            SobreNome = string.Empty;
        }
        public Pessoa(string Nome, string SobreNome)
        {
            this.Nome = Nome;
            this.SobreNome = SobreNome;
            System.Console.WriteLine("Construtor classe pessoa");
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome} {SobreNome}");
        }
    }
}