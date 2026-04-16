using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parqueadero
{
    class Cliente
    {

        protected string dueño, placa, cedula,celular ;
        protected int targeta;


        public string Dueño { get => dueño; set => dueño = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Celular { get => celular; set => celular = value; }
        public int Targeta { get => targeta; set => targeta = value; }



    }
}
