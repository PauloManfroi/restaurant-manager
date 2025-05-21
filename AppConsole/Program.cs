using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AppConsole.Models;

// fluxo da aplicação 
class Program
{
    static List<MenuItem> pedidos = new List<MenuItem>();
    static void Main()
    {
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("\n========================");
            Console.WriteLine("\n======MENU PRINCIPAL======");
            Console.WriteLine("1. Ver Cardápio");
            Console.WriteLine("2. Ver Pedidos");
            Console.WriteLine("0. Sair");
            Console.WriteLine("ESCOLHA UMA OPÇÃO: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    ExibirCardapio();
                    break;
                case "2":
                    VerPedidos();
                    break;
                case "0":
                    Console.WriteLine("Sistema encerrado..");
                    return;
                default:
                    Console.WriteLine("Opcao Inválida, tente novamente.");
                    break;
            }
        }
    }
    //instancia mostrar se o item está disponível ou não, precificar os itens e mostrar a descrição e seleção de pedidos
    static void ExibirCardapio()
    {
        while (true)
        {
            CultureInfo culturaBR = new CultureInfo("pt-BR");
            Console.WriteLine("\nCARDÁPIO DO RESTAURANTE: \n");

            for (int i = 0; i < MenuItem.cardapio.Count; i++)
            {
                var item = MenuItem.cardapio[i];
                string status = item.Disponivel ? "Disponível" : "Indisponível";
                Console.WriteLine($"{i + 1}. {item.Name} - R$ {item.Price} ({status})");
                Console.WriteLine($"  {item.Descricao}\n");
            }

            Console.WriteLine("Digite 0 para encerrar o pedido");
            Console.WriteLine("\nOU");
            Console.WriteLine("\nSelecione uma ou mais opções: ");
            string Opcao = Console.ReadLine();

            if (int.TryParse(Opcao, out int numero))
            {
                if (numero == 0)
                {
                    break; //volta para o menu principal
                }
                if (numero >= 1 && numero <= MenuItem.cardapio.Count)
                {
                    var selecionado = MenuItem.cardapio[numero - 1];
                    if (selecionado.Disponivel)
                    {
                        pedidos.Add(selecionado);
                        Console.WriteLine($"✅ {selecionado.Name} adicionado ao pedido.");
                    }
                }
                else
                {
                    Console.WriteLine("❌ Opção fora do cardápio.");
                }
            }
            else
            {
                Console.WriteLine("❌ Entrada inválida. Digite outro número.");
            }
        }
    }
    // instancia para ver pedidos.
    static void VerPedidos()
    {
        // verifica se a lista esta vazia
        if (pedidos.Count == 0)
        {
            Console.WriteLine("Nenhum pedido foi feito ainda.");
        }
        else
        {
            CultureInfo culturaBR = new CultureInfo("pt-BR");
            decimal total = 0;
            Console.WriteLine("\n=== ITENS PEDIDOS ===");
            //percorre cada item que está na lista de pedidos e mostra seu nome, seu preço e o total dos seus pedidos
            foreach (var item in pedidos)
            {
                Console.WriteLine($"- {item.Name} - {item.Price.ToString("C", culturaBR)}");
                total += item.Price;
            }
            Console.WriteLine($"\n💰 Total: {total.ToString("C", culturaBR)}");
        }
    }
}