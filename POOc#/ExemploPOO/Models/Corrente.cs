//Herda da classe abstrata Conta
//bootcamp Localiza 
//---26/01/2022---
namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            base.saldo = valor;
        }
    }
}