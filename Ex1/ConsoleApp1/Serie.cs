namespace ConsoleApp1
{
    public class Serie : ItemLocadora
    {
        private int temporadas;
        private int episodios;

        public int Temporadas
        {
            get { return temporadas; }
            set { temporadas = value; }
        }
        public int Episodios
        {
            get { return episodios;}
            set { episodios = value;}
        }

        public Serie(int codigo, string titulo, int ano, int temporadas, int episodios) : base(codigo, titulo, ano)
        {
            Temporadas = temporadas;
            Episodios  = episodios;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine("Exibir Serie");
        }
    }
}