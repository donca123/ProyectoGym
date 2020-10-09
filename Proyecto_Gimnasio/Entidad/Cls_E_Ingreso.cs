using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gimnasio.Entidad
{
    class Cls_E_Ingreso
    {
        private string dni;
        private string nombre;
        private string clave;
        private int cargo;
        private string estado;

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Clave { get => clave; set => clave = value; }
        public int Cargo { get => cargo; set => cargo = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
