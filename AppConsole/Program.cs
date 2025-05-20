using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AppConsole.Models;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n========================");
            Console.WriteLine("\n======MENU PRINCIPAL======");
            Console.WriteLine("1. Ver Cardápio");
            Console.WriteLine("0. Sair");
            Console.WriteLine("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                ExibirCardapio();
            }
            else if (opcao == "0")
            {
                Console.WriteLine("Sistema encerrado..");
                break;
            }
            else
            {
                Console.WriteLine("Opcao Inválida, tente novamente.");
            }
        }
    }
    static void ExibirCardapio()
    {
        CultureInfo culturaBR = new CultureInfo("pt-BR");

        Console.WriteLine("\nCARDÁPIO DO RESTAURANTE: \n");

        foreach (var item in MenuItem.cardapio)
        {
            string status = item.Disponivel ? "Disponível" : "Indisponível";
            Console.WriteLine($"- {item.Name} - R$ {item.Price} ({status})");
            Console.WriteLine($"  {item.Descricao}\n");
        }
    }
}