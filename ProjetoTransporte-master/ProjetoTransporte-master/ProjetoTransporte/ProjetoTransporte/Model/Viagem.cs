using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTransporte
{
    class Viagem
    {
        private string placa;
        private DateTime data;
        private Queue<Passageiro> passageiros;

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

        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        internal Queue<Passageiro> Passageiros
        {
            get
            {
                return passageiros;
            }

            set
            {
                passageiros = value;
            }
        }

        public Viagem(string placa, Queue<Passageiro> passageiros)
        {
            Placa = placa;
            Data = DateTime.Now;
            Passageiros = passageiros;
        }
    }
}
