using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gimnasio.Entidad
{
    class Cls_E_Producto
    {
        private int idproducto;
        private string descripcion;
        private double precio_salida;
        private double precio_compra;
        private int cantidad;
        private int idtipo;
        private string estado;

        public int Idproducto { get => idproducto; set => idproducto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio_salida { get => precio_salida; set => precio_salida = value; }
        public double Precio_compra { get => precio_compra; set => precio_compra = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Idtipo { get => idtipo; set => idtipo = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
