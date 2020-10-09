using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gimnasio.Entidad
{
    class Empleado
    {

        public Persona persona { get; set; }
        public int dni { get; set; }

        public int clave { get; set; }
        public int cargo { get; set; }

        

        ////private string dni;
        ////private string nombre;
        ////private string clave;
        ////private int idcargo;
        ////private string estado;

        ////public string Dni { get => dni; set => dni = value; }
        ////public string Nombre { get => nombre; set => nombre = value; }

        ////public string Clave { get => clave; set => clave = value; }
        ////public int Idcargo { get => idcargo; set => idcargo = value; }
        ////public string Estado { get => estado; set => estado = value; }


    }
}
