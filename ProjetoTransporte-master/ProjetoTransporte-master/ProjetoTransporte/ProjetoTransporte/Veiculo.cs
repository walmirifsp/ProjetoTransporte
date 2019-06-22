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
        private string nomeMotorista;
        private int capacidade;

        
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

        public string NomeMotorista
        {
            get
            {
                return nomeMotorista;
            }

            set
            {
                nomeMotorista = value;
            }
        }

        public int Capacidade
        {
            get
            {
                return capacidade;
            }

            set
            {
                capacidade = value;
            }
        }
        #endregion

        #region construtor
        public Veiculo(string placa, string nomeMotorista, int capacidade)
        {
            this.placa = placa;
            this.nomeMotorista = nomeMotorista;
            this.capacidade = capacidade;
        }
        #endregion

        #region metodo


        #endregion
    }
}
