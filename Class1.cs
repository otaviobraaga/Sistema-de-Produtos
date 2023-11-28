using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosProdutoSharp {
    internal class Produto {
        public string Nome;
        public float Preco;
        public int Quantidade;

        public double TotalEstoque() {
            return Preco * Quantidade;
        }

        public override string ToString() {
            string formatoPreco = Preco.ToString("F2");
            string formatoTotalEstoque = TotalEstoque().ToString("F2");

            string descricaoProduto = $"{Nome}, ${formatoPreco}";
            string informacoesEstoque = $"{Quantidade} unidades, Total: $ {formatoTotalEstoque}";

            return $"{descricaoProduto}, {informacoesEstoque}"; 
        }

        public int AddProduct(int quantity) {
            Quantidade += quantity;
            return Quantidade;
        }
        public int DeleteProduct(int quantity) {

        }
    }

}
