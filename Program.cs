using System;
using produtos;

namespace DadosProdutos {
    internal class Program {
        public static void Main(string[] args) {
            
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            var name = Console.ReadLine();
            Console.Write("Digite o valor: ");
            double value = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            int quantity = int.Parse(Console.ReadLine());

            Produtos item = new Produtos(name, value, quantity);

            Console.WriteLine("");
            Console.WriteLine("Dados do produto: " + item);

            Console.WriteLine("");
            Console.Write("Digite o numero de produtos a ser adicionado: ");
            int amount = int.Parse(Console.ReadLine());
            item.AddProduct(amount);

            Console.WriteLine("Dados Atualizados: " + item);

            Console.Write("Digite a quantidade de produtos a serem deletados: ");
            int delete = int.Parse(Console.ReadLine());
            item.DeleteProduct(delete);

            Console.WriteLine("Dados Atualizados: " + item);
            
        }
    }
}