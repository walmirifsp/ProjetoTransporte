using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTransporte
{
    class Visitantes
    {
        #region atributos
        private int proximoVisitante;
        private Queue<Visitante> filaVisitante;
        #endregion
        #region proteção
        public Queue<Visitante> FilaVisitante
        {
            get
            {
                return filaVisitante;
            }
        }
        #endregion

        #region propriedades

        #endregion

        #region construtor
        public Visitantes()
        {
            filaVisitante = new Queue<Visitante>();
            this.proximoVisitante++;
        }
        #endregion

        #region metodos
        #endregion

    }
}
