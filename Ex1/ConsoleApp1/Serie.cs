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

        public override void ExibirDetalhes()
        {
            Console.WriteLine("Exibir Serie");
        }
    }
}