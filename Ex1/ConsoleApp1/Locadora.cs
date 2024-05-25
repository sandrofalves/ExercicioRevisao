namespace ConsoleApp1
{
    public class Locadora
    {
      public List<ItemLocadora> ItensLocadora;

      public Locadora()
      {
        ItensLocadora = new();
      }

      public void AdicionarItem(ItemLocadora item)
      {
        ItensLocadora.Add(item);
      }

      public void RemoverItem(int codigo)
      {
        ItensLocadora.RemoveAt(codigo);
      }

      public void ListarItens()
      {
        foreach (var item in ItensLocadora)
        {
            Console.WriteLine($"Codigo: {item.Codigo}, Titulo: {item.Titulo}");
        }
      }

    }
}