using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correcao.Prova.Segundo.Bimestre
{
    public interface ITelefone
    {
        void Tocar();
        void Discar();
    }

    public interface ISmartphone : ITelefone
    {
        void TirarFoto();
    }

    public class Telefone : ITelefone
    {
        public void Discar()
        {
            #region FAZ ALGUMA COISA
            #endregion
        }

        public void Tocar()
        {
            #region FAZ ALGUMA COISA
            #endregion
        }
    }

    public class Smartphone : ISmartphone
    {
        public void Discar()
        {
            #region FAZ ALGUMA COISA
            #endregion
        }

        public void TirarFoto()
        {
            #region FAZ ALGUMA COISA
            #endregion
        }

        public void Tocar()
        {
            #region FAZ ALGUMA COISA
            #endregion
        }
    }
}
