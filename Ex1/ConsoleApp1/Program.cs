
using ConsoleApp1;

ItemLocadora itemLocadora; 

itemLocadora = new Filme(1,"Partiu América",2024,"Matheus",120);

itemLocadora.ExibirDetalhes();


Locadora loc = new();

loc.AdicionarItem(itemLocadora);
loc.AdicionarItem(new Serie(2,"Lost",2024,3,30));

loc.ListarItens();

loc.RemoverItem(1);

loc.ListarItens();

