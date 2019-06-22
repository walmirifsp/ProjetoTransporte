using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTransporte
{
    class Visitante
    {
        #region atributo
        private int id;
        private string nome;

        
        #endregion

        #region propriedades
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

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }
        #endregion

        #region construtor
        public Visitante(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
        #endregion


    }
}
