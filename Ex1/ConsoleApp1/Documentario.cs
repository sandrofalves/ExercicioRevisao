using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    public class Documentario : ItemLocadora
    {
        private string assunto;

        public String Assunto
        {
            get { return assunto;}
            set { assunto = value;}
        }

        public Documentario(int codigo, string titulo, int ano, string assunto) : base(codigo, titulo, ano)
        {
            Assunto = assunto;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine("Exibe Assunto.");
        }
    }
}