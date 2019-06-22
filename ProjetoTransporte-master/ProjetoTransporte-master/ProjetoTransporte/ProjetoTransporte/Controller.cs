using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTransporte
{
    class Controller
    {
        private Passageiros passageiros;
        private Veiculos veiculos;
        private Viagens viagens;
        private Veiculo veiculo;

        internal Passageiros Passageiros
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

        internal Veiculos Veiculos
        {
            get
            {
                return veiculos;
            }

            set
            {
                veiculos = value;
            }
        }

        internal Viagens Viagens
        {
            get
            {
                return viagens;
            }

            set
            {
                viagens = value;
            }
        }

        internal Veiculo Veiculo
        {
            get
            {
                return veiculo;
            }

            set
            {
                veiculo = value;
            }
        }

        public Controller()
        {
            Passageiros = new Passageiros();
            Veiculos = new Veiculos();
            Viagens = new Viagens();
        }

        public void addPassageiro()
        {
            Passageiros.addPassageiro();
        }
        public void addVeiculo(string placa, string nome, int lotacao)
        {
            Veiculos.addVeiculo(placa, nome, lotacao);
            if ((veiculos.Lveiculos.Count() == 1) && (veiculo == null))
            {
                veiculo = veiculos.Lveiculos.Dequeue();
            }
        }
        public void viagem(bool viagem)
        {
            if (Passageiros.LsPassageiros.Count() >= Veiculo.Lotacao || viagem == true)
            {
                int qtdPassageiros = Veiculo.Lotacao;
                Queue<Passageiro> passageirosViagem = new Queue<Passageiro>();
                while (qtdPassageiros != 0)
                {
                    Console.WriteLine("Removeu o passageiro " + Passageiros.LsPassageiros.Peek().Inscricao.ToString());
                    passageirosViagem.Enqueue(Passageiros.LsPassageiros.Dequeue());
                    qtdPassageiros--;
                }
                Viagens.LViagens.Add(new Viagem(Veiculo.Placa, passageirosViagem));
                veiculos.Lveiculos.Enqueue(veiculo);
                veiculo = veiculos.Lveiculos.Dequeue();
            }
        }

        public string returnNome(string placa)
        {
            foreach (var v in veiculos.Lveiculos)
            {
                if (v.Placa == placa)
                {
                    return v.Nome;
                }
            }
            if (Veiculo.Placa == placa)
            {
                return Veiculo.Nome;
            }
            return "";
        }
        public string returnLucro(string placa)
        {
            double lucro = 0;
            if (viagens.LViagens.Count() != 0)
            {
                foreach (var v in viagens.LViagens)
                {
                    if (v.Placa == placa)
                    {
                        lucro += v.Passageiros.Count() * 5;
                    }
                }
            }
            return "R$ " + lucro;
        }
        public string returnNumViagens(string placa)
        {
            foreach (var v in viagens.LViagens)
            {
                if (v.Placa == placa)
                {
                    return viagens.LViagens.Count().ToString();
                }
            }
            return "0";
        }
    }
}
