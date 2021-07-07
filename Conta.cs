using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correcao.Prova.Segundo.Bimestre
{
    public interface IConta
    {
        void Creditar(decimal valor);
        void Debitar(decimal valor);
        string ObterExtrato();
    }

    public class ContaCorrente : IConta
    {
        public void Creditar(decimal valor)
        {
            #region FAZ ALGUMA COISA
            #endregion
        }

        public void Debitar(decimal valor)
        {
            #region FAZ ALGUMA COISA
            #endregion
        }

        public string ObterExtrato()
        {
            #region FAZ ALGUMA COISA
            return string.Empty;
            #endregion
        }
    }

    public class ContaPoupanca : IConta
    {
        public void Creditar(decimal valor)
        {
            #region FAZ ALGUMA COISA
            #endregion
        }

        public void Debitar(decimal valor)
        {
            #region FAZ ALGUMA COISA
            #endregion
        }

        public string ObterExtrato()
        {
            #region FAZ ALGUMA COISA
            return string.Empty;
            #endregion
        }
    }
}