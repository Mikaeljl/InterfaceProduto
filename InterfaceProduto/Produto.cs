using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProduto
{
    public class PagamentoCartao : IProduto

    {

        public void RealizarPagamento()

        {

            Console.WriteLine("Pagamento realizado via cartão.");

        }
    }
}
