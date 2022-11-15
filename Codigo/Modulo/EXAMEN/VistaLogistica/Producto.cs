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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

      

        



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "6002";
            TextBox[] Grupotextbox = { txtBuscar, TxtCodigoRef, TxtDesc, TxtLinea};
            TextBox[] Idtextbox = { txtBuscar, TxtCodigoRef};
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dtgProducto;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dtgProducto, Grupotextbox, "ExamenFinal");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtact_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
