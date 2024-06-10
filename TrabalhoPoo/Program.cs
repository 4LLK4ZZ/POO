using TrabalhoPoo;

public class Program
{
    static List<Produto> produtos = new List<Produto>();
    static Venda vendaAtual = new Venda();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Cadastrar produto");
            Console.WriteLine("2. Adicionar item à venda");
            Console.WriteLine("3. Realizar pagamento");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarProduto();
                    break;
                case "2":
                    AdicionarItemVenda();
                    break;
                case "3":
                    RealizarPagamento();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    static void CadastrarProduto()
    {
        Console.Write("Código do produto: ");
        long codigo = long.Parse(Console.ReadLine());
        Console.Write("Nome do produto: ");
        string nome = Console.ReadLine();
        Console.Write("Preço do produto: ");
        double preco = double.Parse(Console.ReadLine());
        Console.Write("Estoque do produto: ");
        int estoque = int.Parse(Console.ReadLine());

        Produto produto = new Produto { Codigo = codigo, Nome = nome, Preco = preco, Estoque = estoque };
        produtos.Add(produto);

        Console.WriteLine("Produto cadastrado!");
    }

    static void AdicionarItemVenda()
    {
        Console.Write("Código do produto: ");
        long codigo = long.Parse(Console.ReadLine());
        Console.Write("Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine());

        Produto produto = produtos.Find(p => p.Codigo == codigo);
        if (produto != null && produto.Estoque >= quantidade)
        {
            ItemVenda item = new ItemVenda(produto, quantidade);
            vendaAtual.AdicionarItem(item);
            produto.Estoque -= quantidade;

            Console.WriteLine("Item adicionado à venda!");
        }
        else
        {
            Console.WriteLine("Produto não encontrado ou estoque insuficiente.");
        }
    }

    static void RealizarPagamento()
    {
        Console.WriteLine($"Total da venda: {vendaAtual.Total}");
        Console.Write("Método de pagamento (especie/cheque/cartao): ");
        string metodo = Console.ReadLine().ToLower();

        switch (metodo)
        {
            case "especie":
                Console.Write("Quantia recebida: ");
                double quantia = double.Parse(Console.ReadLine());
                Especie pagamentoEspecie = new Especie(vendaAtual, quantia);
                Console.WriteLine($"Troco: {pagamentoEspecie.Troco}");
                break;
            case "cheque":
                Console.Write("Número do cheque: ");
                long numero = long.Parse(Console.ReadLine());
                Console.Write("Data de depósito (YYYY-MM-DD): ");
                DateTime dataDeposito = DateTime.Parse(Console.ReadLine());
                Console.Write("Situação do cheque: ");
                int situacao = int.Parse(Console.ReadLine());
                Cheque pagamentoCheque = new Cheque(vendaAtual, numero, dataDeposito, situacao);
                Console.WriteLine("Pagamento realizado por cheque.");
                break;
            case "cartao":
                Console.Write("Dados da transação: ");
                string dadosTransacao = Console.ReadLine();
                Console.Write("Resultado da transação: ");
                int resultadoTransacao = int.Parse(Console.ReadLine());
                Cartao pagamentoCartao = new Cartao(vendaAtual, dadosTransacao, resultadoTransacao);
                Console.WriteLine("Pagamento realizado por cartão.");
                break;
            default:
                Console.WriteLine("Método de pagamento inválido.");
                break;
        }
    }
}