using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gimnasio.Entidad
{
    class Cliente
    {
        //    private string dni;
        //    private string nombres;
        //    private string estado;

        //    public string Dni { get => dni; set => dni = value; }
        //    public string Nombres { get => nombres; set => nombres = value; }
        //    public string Estado { get => estado; set => estado = value; }

        public int codigoCliente { get; private set; }
        public string dni { get; private set; }

        public string nombres { get; private set; }

        public int estado { get; private set; }

        public static Cliente Agregar(string _dni, string _nombres, int _estado)
        {
            return new Cliente() {dni = _dni , nombres = _nombres , estado = _estado};
        }

        public void changeName(string _nombres)
        {
            nombres = _nombres;
        }

        public void DisabledClient()
        {
            estado = 0;       
        }

        public void ActivedClient()
        {
            estado = 1;
        }
    }
}
