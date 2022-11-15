using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaLogistica
{
    public partial class InventarioIngreso : Form
    {
        public InventarioIngreso()
        {
            InitializeComponent();
        }

        private void dtgProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "6003";
            TextBox[] Grupotextbox = { txtBuscar, TxtCodigoRef, TxtDesc };
            TextBox[] Idtextbox = { txtBuscar, TxtCodigoRef, TxtDesc };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dtgProducto;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dtgProducto, Grupotextbox, "ExamenFinal");
        }
    }
}
