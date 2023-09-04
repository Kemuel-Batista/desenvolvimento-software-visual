using Aula01_07_08_23;

static void TesteCliente()
{
    Cliente c;

    for (int i = 0; i < 3; i++)
    {
        c = new();
        Console.Write("CPF: ");
        c.Cpf = Console.ReadLine();
        Console.Write("Nome: ");
        c.Nome = Console.ReadLine();
        Cliente.clientes.Add(c);
    }

    Console.WriteLine("Os itens inseridos foram: ");

    foreach (Cliente cli in Cliente.clientes)
    {
        Console.WriteLine("CPF: " + cli.Cpf);
        Console.WriteLine("Nome: " + cli.Nome);
    }

    Pizza pizza = new();
    pizza.Tamanho = 12;
    pizza.Sabor = "Calabresa";
    pizza.Categoria = "Teste";

    Complemento complemento1 = new();
    complemento1.Valor = 10;
    complemento1.Descricao = "Cheddar";
    complemento1.Id = 1;

    Complemento[] complementosPizza = { complemento1 };

    pizza.Complementos = complementosPizza;
}

TestePedidoIdentificado();

static void TestePedidoIdentificado()
{
    Cliente.clientes.Add(new("123", "Kemuel"));
    Cliente.clientes.Add(new("456", "Allan"));

    Complemento complemento1 = new();
    complemento1.Valor = 10;
    complemento1.Descricao = "Cheddar";
    complemento1.Id = 1;

    Complemento[] complementosPizza = { complemento1 };

    Pizza.pizzas.Add(new("Teste", "Mussarela", 10, complementosPizza));

    PedidoIdentificado p = new();
    Console.WriteLine("Pedido numero: ");
    p.Id = int.Parse(Console.ReadLine());
    Console.WriteLine("CPF do Cliente: ");
    string cpf = Console.ReadLine();
    // Preciso localizar o cpf do cliente pois ele é um objeto
    p.Cliente = new(cpf);
    Console.WriteLine("Nome: " + p.Cliente.Nome);

    /*
        Um pedido tem um array de itens de pedido
        O cliente vai pedir o nome da pizza, vou ter que verificar se a pizza existe 
        no array de pizzas e montar a pizza
        e adicionar a pizza no array de Item pedido já que a assinatura do array é ItemPedido e Pizza
        é um array de itempedido.
     */

    
    
    string sabor = Console.ReadLine();
    Pedido ped = new();
    ped.Itens.Add(new Pizza(sabor));


}