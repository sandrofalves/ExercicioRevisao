namespace ConsoleApp1
{
    public class Filme : ItemLocadora
    {
        private string diretor;
        private int duracao;

        public string Diretor
        {
            get { return diretor;}
            set { diretor = value;}
        }
        public int Duracao
        {
            get { return duracao;}
            set { duracao = value;}
        }

        public Filme(int codigo, string titulo, int ano, string diretor, int duracao) : base(codigo, titulo, ano)
        {
            Diretor = diretor;
            Duracao = duracao; 
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine("Exibir Filme");
        }

    }
}