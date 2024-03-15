using System;
using System.Collections.Generic;

namespace V1_ControlePagamentos
{
    class MainClass
    {
        static void Main(string[] args)
        {
            List<Pagamentos> listaPagamentos = new List<Pagamentos>();
            int index = 0; 

            Console.WriteLine("Bem-vindo(a) ao Sistema de Controle de Pagamentos!");

            while (true)
            {
                Console.WriteLine("\nInforme a opção desejada:");
                Console.WriteLine("[1] – Adicionar Pagamento");
                Console.WriteLine("[2] – Listar Pagamentos");
                Console.WriteLine("[3] – Sair");

                int opcao;
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        if (index < 10) 
                        {
                            AdicionarPagamento(listaPagamentos);
                            index++;
                        }
                        else
                        {
                            Console.WriteLine("Você atingiu o limite máximo de 10 pagamentos. Não é possível adicionar mais pagamentos.");
                        }
                        break;
                    case 2:
                        ListarPagamentos(listaPagamentos);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        break;
                }
            }
        }

        static void AdicionarPagamento(List<Pagamentos> listaPagamentos)
        {
            if (listaPagamentos.Count >= 10)
            {
                Console.WriteLine("Você atingiu o limite máximo de 10 pagamentos. Não é possível adicionar mais pagamentos.");
                return;
            }

            Console.WriteLine("\nInforme a opção desejada:");
            Console.WriteLine("[1.1] – Pagamento da Área de Saúde");
            Console.WriteLine("[1.2] – Pagamento da Área Alimentícia");

            int opcao;
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                return;
            }

            Pagamentos pagamento;

            switch (opcao)
            {
                case 1:
                    pagamento = new Saude();
                    ((Saude)pagamento).InserirDadosSaude();
                    break;
                case 2:
                    pagamento = new Alimentacao();
                    ((Alimentacao)pagamento).InserirDadosAlimentacao();
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    return;
            }

            pagamento.InserirDadosPagamentos();
            listaPagamentos.Add(pagamento);

            Console.WriteLine("Pagamento adicionado com sucesso!");
        }

        static void ListarPagamentos(List<Pagamentos> listaPagamentos)
        {
            if (listaPagamentos.Count == 0)
            {
                Console.WriteLine("Nenhum pagamento registrado.");
                return;
            }

            Console.WriteLine("\nLista de Pagamentos:");

            foreach (var pagamento in listaPagamentos)
            {
                Console.WriteLine($"\nCPF: {pagamento.Cpf}");
                Console.WriteLine($"Código: {pagamento.Codigo}");
                Console.WriteLine($"Valor: R${pagamento.Valor:F2}");

                if (pagamento is Saude saude)
                {
                    Console.WriteLine($"Tipo: Pagamento da Área de Saúde");
                    Console.WriteLine($"Estabelecimento: {saude.Estabelecimento}");
                    Console.WriteLine($"Valor do Faturamento: R${saude.Faturar():F2}");
                }
                else if (pagamento is Alimentacao alimentacao)
                {
                    Console.WriteLine($"Tipo: Pagamento da Área Alimentícia");
                    Console.WriteLine($"Produto: {alimentacao.Descricao}");
                    Console.WriteLine($"Valor do Faturamento: R${alimentacao.Faturar():F2}");
                }
            }
        }
    }
}
