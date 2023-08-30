using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Tecnico.Questao4
{
    public class Comparator : IComparer<Item>
    {
        public int Compare(Item i, Item j)
        {
            return j.Valor.CompareTo(i.Valor);
        }
    }
}
