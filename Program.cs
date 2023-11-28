using DadosProdutoSharp;
using System;

namespace ProductSharp {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto(); 

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = float.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);
        }
    }
}