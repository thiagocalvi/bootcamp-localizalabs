//Herança de Construtor
//bootcamp Localiza
//-----26/01/2022-----
namespace ExemploConstrutores.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string Nome, string SobreNome, string Disciplina) : base(Nome, SobreNome)
        {
            System.Console.WriteLine("Contrutor classe aluno");
        }
    }
}