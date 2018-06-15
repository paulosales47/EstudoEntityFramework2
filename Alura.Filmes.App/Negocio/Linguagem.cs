namespace Alura.Filmes.App.Negocio
{
    public class Linguagem
    {
        public byte Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}";
        }
    }
}
