using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTransporte
{
    class Veiculos
    {
        Queue<Veiculo> lveiculos;

        internal Queue<Veiculo> Lveiculos
        {
            get
            {
                return lveiculos;
            }

            set
            {
                lveiculos = value;
            }
        }

        public Veiculos()
        {
            Lveiculos = new Queue<Veiculo>();
        }
        public Veiculo retornaVeiculo()
        {
            if (Lveiculos.Count() != 0)
            {
                return Lveiculos.Dequeue();
            }
            return null;
        }

        public void addVeiculo(string placa, string nome, int lotacao)
        {
            Lveiculos.Enqueue(new Veiculo(placa, nome, lotacao));
        }
    }
}
