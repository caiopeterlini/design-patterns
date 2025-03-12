using FactoryMethod.AbstractProduct;
using FactoryMethod.ConcreteProduct;
using FactoryMethod.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.ConcreteFactory
{
    public class InfinityFactory : CartaoFactory
    {

        private int _limiteCredito;
        private int _cobrancaAnual;

        public InfinityFactory(int limiteCredito, int cobrancaAnual)
        {
            this._limiteCredito = limiteCredito;
            this._cobrancaAnual = cobrancaAnual;
        }

        public override CartaoCredito BuscarCartaoCredito()
        {
            return new CartaoInfinity(_limiteCredito, _cobrancaAnual);
        }
    }
}
