using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppConsole.Models
{
    // declarar cada item
    public class MenuItem
    {
        public string Name { get; set; }
        public string Descricao { get; set; }
        public decimal Price { get; set; }
        public bool Disponivel { get; set; }


        //métodos para registrar separadamente cada item
        public static List<MenuItem> cardapio = new List<MenuItem>
            {
                new MenuItem
                {
                    Name = "1 - X-TUDO",
                    Descricao = "Pão, 2 hamburguers 120g, bacon, salsicha, ovo, alface, tomate, maionese, molho da casa.",
                    Price = 30.00m,
                    Disponivel = true
                },
                new MenuItem
                {
                    Name = "2 - Batata Frita",
                    Descricao = "Batatas Fritas 400g",
                    Price = 28.00m,
                    Disponivel = true
                },
                new MenuItem
                {
                    Name = "3 - Iscas de Tilápa",
                    Descricao = "Iscas de Tilápia fritas 500g, acompanhadas de limão e molho da casa.",
                    Price = 50.00m,
                    Disponivel = true
                },
                new MenuItem
                {
                    Name = "4 - Coca-Cola Lata",
                    Descricao = "Lata de Refrigerante Coca-Cola 350ml",
                    Price = 6.00m,
                    Disponivel = true
                },
                new MenuItem
                {
                    Name = "5 - Agua",
                    Descricao = "Garrafa de agua mineral sem gás 500ml",
                    Price = 4.00m,
                    Disponivel = true
                }
            };

    }

}