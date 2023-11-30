using System.Globalization;

namespace produtos {
    class Produtos {
        public string Name;
        public float Value;
        public int Quantity;

        public double ValorTotalEmEstoque() {
            return Value * Quantity;
        }

        public override string ToString() {
            return Name + ", $"
                        + Value.ToString("F2") + ", "
                        + Quantity + " unidades, Total: $" +
                        ValorTotalEmEstoque().ToString("F2");
        }

        public void AddProduct(int amount) {
            Quantity += amount;
        }
        public void DeleteProduct(int delete) {
            Quantity -= delete;
        }
    }
}