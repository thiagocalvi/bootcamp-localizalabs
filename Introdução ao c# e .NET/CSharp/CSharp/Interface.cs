namespace Interface
{
    interface IAnimal
    {
        void Name(string nome);
        void Dono(string nomeDono);
        void Especie(string especie);
    }

    class Animal : IAnimal
    {
        public string Nome { get; set; }
        public string Dono { get; set; }
        public string Especie { get; set; }

        void IAnimal.Name(string nome)
        {
            this.Nome = nome;
        }
        void IAnimal.Dono(string nomeDono)
        {
            this.Dono = nomeDono;
        }
        void IAnimal.Especie(string especie)
        {
            this.Especie = especie;
        }
    }
}
