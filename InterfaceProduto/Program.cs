using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProduto pagamento = new PagamentoCartao();

            pagamento.RealizarPagamento();  // Chama o método implementado pela classe concreta
        }
    }
}
