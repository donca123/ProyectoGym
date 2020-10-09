using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Gimnasio.Presentacion
{
    public partial class Form_Servicios : Form
    {
        public Form_Servicios()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnAerobicos, "AEROBICOS");
            toolTip1.SetToolTip(btnClase, "CLASE FUNCIONAL");
            toolTip1.SetToolTip(btnMAquinas, "MAQUINAS");
            toolTip1.SetToolTip(btnPersonal, "PERSONAL TRAINER");
            toolTip1.SetToolTip(btnSUplementos, "SUPLEMENTOS");
            toolTip1.SetToolTip(btnSpining, "SPINNING");
        }

        private void Form_Servicios_Load(object sender, EventArgs e)
        {

        }
    }
}
