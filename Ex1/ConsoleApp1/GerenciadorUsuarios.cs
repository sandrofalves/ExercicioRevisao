namespace ConsoleApp1
{
    public class GerenciadorUsuarios
    {
        public List<Usuario> Usuarios;

        public GerenciadorUsuarios()
        {
           Usuarios = new(); 
        }
        public void AdicionarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        public void RemoverUsuario(int id)
        {
            Usuarios.RemoveAt(id);
        }

        public void ListarUsuarios()
        {
            foreach(var item in Usuarios)
            {
                Console.WriteLine($"ID: {item.ID},Nome: {item.Nome}");
            }
        }
    }
}