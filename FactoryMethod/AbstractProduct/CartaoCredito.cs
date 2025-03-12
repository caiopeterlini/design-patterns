using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.AbstractProduct
{
    public abstract class CartaoCredito
    {

        public abstract string TipoCartao { get; }
        public abstract int LimiteCredito { get; set; }
        public abstract int CobrancaAnual { get; set; }

    }
}
