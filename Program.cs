using System;
using produtos;

namespace DadosProdutos {
    internal class Program {
        public static void Main(string[] args) {
            Produtos item = new Produtos();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            item.Name = Console.ReadLine();
            Console.Write("Digite o valor: ");
            item.Value = float.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            item.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + item);
        }
    }
}