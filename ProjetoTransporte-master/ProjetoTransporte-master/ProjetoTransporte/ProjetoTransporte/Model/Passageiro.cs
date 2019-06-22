using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTransporte
{
    class Passageiro
    {

        #region atribultos
        private int inscricao;
        #endregion

        #region construtor
        public Passageiro(int inscricao)
        {
            Inscricao = inscricao;
        }
        #endregion

        #region propriedades
        public int Inscricao
        {
            get
            {
                return inscricao;
            }

            set
            {
                inscricao = value;
            }
        }
        #endregion

        #region metodos
        public String dadosCompletos()
        {
            return "Inscrição : " + inscricao;
        }
        #endregion

    }
}
