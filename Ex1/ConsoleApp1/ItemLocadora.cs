using System.IO.Pipes;

namespace ConsoleApp1
{
    public abstract class ItemLocadora
    {
        private int codigo;
        private string titulo;
        private int ano;

        public int Codigo
        { 
            get {return codigo;}
            set {codigo = value;}
        }
            
        public string Titulo
        {
            get {return titulo;}
            set {titulo = value;}
        }
        public int Ano
        {
            get {return ano;}
            set {ano = value;}
        }
        public ItemLocadora(int codigo, string titulo, int ano)
        {
            Codigo = codigo;
            Titulo = titulo;
            Ano    = ano;
        }

        public abstract void ExibirDetalhes();

    }
}