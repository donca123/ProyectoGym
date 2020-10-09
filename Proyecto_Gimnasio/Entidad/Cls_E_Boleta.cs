using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gimnasio.Entidad
{
    class Cls_E_Boleta
    {
        private string serie;
        private string numero;
        private string empleado;
        private DateTime fecha;
        private string cliente;
        private double subtotal;
        private double igv;
        private double total;
        private string estado;
        private string tipopago;

        public string Serie { get => serie; set => serie = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Empleado { get => empleado; set => empleado = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
        public double Igv { get => igv; set => igv = value; }
        public double Total { get => total; set => total = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Tipopago { get => tipopago; set => tipopago = value; }
    }
}
