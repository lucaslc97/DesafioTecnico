using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Tecnico.Questao3
{
    public class Pedido2
    {
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }
        public int Numero { get; set; }
        public Cliente Cliente { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }
        public double ValorTotal { get; set; }

        public Pedido2(Cliente cliente, ICollection<Produto> produtos)
        {
            this.Cliente = cliente;
            this.Produtos = produtos;
            this.ValorTotal = CalcularValorTotal();
        }

        private double CalcularValorTotal()
        {
            double valorTotal = 0;
            foreach (Produto produto in this.Produtos)
            {
                valorTotal += produto.Preco * produto.Quantidade;
            }
            return valorTotal;
        }
    }
}
