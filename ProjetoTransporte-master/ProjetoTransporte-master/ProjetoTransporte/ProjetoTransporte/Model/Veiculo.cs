using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTransporte
{
    class Veiculo
    {
        #region atributos
        private string placa;
        private string nome;
        private int lotacao;

        #endregion

        #region propriedades
        public string Placa
        {
            get
            {
                return placa;
            }

            set
            {
                placa = value;
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

        public int Lotacao
        {
            get
            {
                return lotacao;
            }

            set
            {
                lotacao = value;
            }
        }
        #endregion

        #region construtor
        public Veiculo(string placa, string nome, int lotacao)
        {
            Placa = placa;
            Nome = nome;
            Lotacao = lotacao;
        }
        #endregion

        #region metodo
       
        #endregion
    }
}
