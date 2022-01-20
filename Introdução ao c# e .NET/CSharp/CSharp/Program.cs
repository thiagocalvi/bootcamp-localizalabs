using System;
using CSharp;
using Interface;
using Enum;
namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            var pessoa = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.João;
            Pessoas pessoa3 = (Pessoas)4;



            Pessoa person = new Pessoa();

            person.Nome = "Thiago";
            person.Estado = "Parana";
            person.Idade = 17;

            var person2 = new Pessoa();

            person2.Nome = "Givanna";
            person2.Estado = "São Paulo";
            person2.Idade = 18;


            Animal animal = new Animal();
            animal.Nome = "Rex";
            animal.Dono = "Pedro";
            animal.Especie = "Cachorro";
        }
    }
}
