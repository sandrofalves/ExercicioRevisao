namespace ConsoleApp1
{
    abstract public class Tarefa
    {
        public string Descricao;
        public bool Concluida;

        public abstract void Concluir();
        public abstract void Descrever();
    }
}