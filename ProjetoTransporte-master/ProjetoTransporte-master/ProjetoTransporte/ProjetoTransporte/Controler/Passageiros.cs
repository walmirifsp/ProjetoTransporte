using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTransporte
{
    class Passageiros
    {
        #region Atributos
        private Queue<Passageiro> lsPassageiros;
        private int id;
        #endregion


        #region propriedades
        internal Queue<Passageiro> LsPassageiros
        {
            get
            {
                return lsPassageiros;
            }

            set
            {
                lsPassageiros = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        #endregion

     
        #region construtor
        public Passageiros()
        {
            LsPassageiros = new Queue<Passageiro>();
            id = 0;
        }
        #endregion

        #region metodos
        public void addPassageiro()
        {
            int inscricao = id + 1;
            id++;
            LsPassageiros.Enqueue(new Passageiro(inscricao));
        }
        #endregion

    }
}
