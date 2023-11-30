using System;
using produtos;

namespace DadosProdutos {
    internal class Program {
        public static void Main(string[] args) {
            Produtos item = new Produtos();
            //Comentario teste
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            item.Name = Console.ReadLine();
            Console.Write("Digite o valor: ");
            item.Value = float.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            item.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Dados do produto: " + item);

            Console.WriteLine("");
            Console.Write("Digite o numero de produtos a ser adicionado: ");
            int amount = int.Parse(Console.ReadLine());
            item.AddProduct(amount);

            Console.WriteLine("Dados Atualizados: " + item);

            Console.Write("Digite a quantidade de produtos a seres deletados: ");
            int delete = int.Parse(Console.ReadLine());
            item.DeleteProduct(delete);

            Console.WriteLine("Dados Atualizados: " + item);
        }
    }
}