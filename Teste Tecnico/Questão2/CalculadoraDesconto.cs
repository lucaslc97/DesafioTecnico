using Teste_Tecnico.Questão_2.Enum;

namespace Teste_Tecnico.Questão_2
{
    public class CalculadoraDesconto
    {
        public static double CalcularDesconto(double valor, TipoClienteEnum tipoCliente)
        {
            double valorFinal;
            if (tipoCliente == TipoClienteEnum.Especial)
            {
                valorFinal = valor - 50;
            }
            else if (tipoCliente == TipoClienteEnum.Associado)
            {
                valorFinal = valor - 20;
            }
            else if (tipoCliente == TipoClienteEnum.VIP)
            {
                valorFinal = valor - 70;
            }
            else
            {
                valorFinal = valor;
            }
            return valorFinal;
        }
    }
}
