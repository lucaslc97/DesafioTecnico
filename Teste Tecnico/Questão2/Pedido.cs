using Teste_Tecnico.Questão_2;
using Teste_Tecnico.Questão_2.Enum;

namespace Teste_Tecnico.Pedido
{
    public class Pedido
    {
        public double Valor { get; set; }
        public TipoClienteEnum TipoCliente { get; set; }

        public double CalcularDesconto()
        {
            return CalculadoraDesconto.CalcularDesconto(this.Valor, this.TipoCliente);
        }
    }
}
