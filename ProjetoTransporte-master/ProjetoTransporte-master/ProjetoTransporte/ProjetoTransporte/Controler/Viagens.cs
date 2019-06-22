using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTransporte
{
    class Viagens
    {
        private List<Viagem> lViagens;
        public Viagens()
        {
            LViagens = new List<Viagem>();
        }

        internal List<Viagem> LViagens
        {
            get
            {
                return lViagens;
            }

            set
            {
                lViagens = value;
            }
        }
    }
}
