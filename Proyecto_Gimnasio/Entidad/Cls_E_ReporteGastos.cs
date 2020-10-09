using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gimnasio.Entidad
{
    class Cls_E_ReporteGastos
    {
        private double total;
        private string mes;

        public double Total { get => total; set => total = value; }
        public string Mes { get => mes; set => mes = value; }
    }
}
