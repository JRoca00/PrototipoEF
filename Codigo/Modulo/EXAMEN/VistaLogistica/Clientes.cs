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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "6001";
            TextBox[] Grupotextbox = { txtBuscar, TxtCodigoRef, TxtDesc, textBox2, textBox1 };
            TextBox[] Idtextbox = { txtBuscar, TxtCodigoRef };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dtgProducto;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dtgProducto, Grupotextbox, "ExamenFinal");
        }
    }
}
