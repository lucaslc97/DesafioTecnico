using Teste_Tecnico.Pedido;
using Teste_Tecnico.Questão_2.Enum;
using Teste_Tecnico.Questao3;
using Teste_Tecnico.Questao4;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine($"Questão 2 -------------------------------------------------------");

        Pedido pedido = new Pedido
        {
            Valor = 100,
            TipoCliente = TipoClienteEnum.VIP
        };

        double valorComDesconto = pedido.CalcularDesconto();

        Console.WriteLine($"Valor original: {pedido.Valor}");
        Console.WriteLine($"Valor com desconto: {valorComDesconto}");


        Console.WriteLine($"Questão 3 -------------------------------------------------------");
        Cliente cliente = new Cliente
        {
            Nome = "João da Silva",
            Email = "joao@example.com"
        };

        List<Produto> produtos = new List<Produto>
        {
            new Produto { Nome = "Produto 1", Preco = 10, Quantidade = 2 },
            new Produto { Nome = "Produto 2", Preco = 22, Quantidade = 3 }
        };

        Pedido2 pedido2 = new Pedido2(cliente, produtos);

        Console.WriteLine($"Número do pedido: {pedido2.Numero}");
        Console.WriteLine($"Cliente: {pedido2.Cliente.Nome}");
        Console.WriteLine("Produtos:");
        foreach (var produto in pedido2.Produtos)
        {
            Console.WriteLine($"- {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco:C}");
        }
        Console.WriteLine($"Valor Total: {pedido2.ValorTotal:C}");


        Console.WriteLine($"Questão 4 -------------------------------------------------------");

        SortedSet<Item> FilaPrioridades = new SortedSet<Item>(new Comparator());

        // Insere 5 elementos na coleção
        Item item1 = new Item { Id = 1, Nome = "Item 1", Valor = 100 };
        Item item2 = new Item { Id = 2, Nome = "Item 2", Valor = 200 };
        Item item3 = new Item { Id = 3, Nome = "Item 3", Valor = 300 };
        Item item4 = new Item { Id = 4, Nome = "Item 4", Valor = 400 };
        Item item5 = new Item { Id = 5, Nome = "Item 5", Valor = 500 };

        FilaPrioridades.Add(item1);
        FilaPrioridades.Add(item2);
        FilaPrioridades.Add(item3);
        FilaPrioridades.Add(item4);
        FilaPrioridades.Add(item5);

        // Imprime os elementos da coleção
        foreach (Item item in FilaPrioridades)
        {
            Console.WriteLine("{0} - {1} - {2}", item.Id, item.Nome, item.Valor);
        }
    }
}