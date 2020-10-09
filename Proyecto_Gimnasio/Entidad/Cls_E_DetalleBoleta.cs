using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gimnasio.Entidad
{
    class Cls_E_DetalleBoleta
    {
        private string serie;
        private string numero;
        private int codigo;
        private int cantidad;
        private double precio_unitario;
        private double importe;

        public string Serie { get => serie; set => serie = value; }
        public string Numero { get => numero; set => numero = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio_unitario { get => precio_unitario; set => precio_unitario = value; }
        public double Importe { get => importe; set => importe = value; }
    }
}
