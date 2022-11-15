using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControladorLogistica;

namespace VistaLogistica
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        
        Controlador cn = new Controlador();


        private void button5_Click(object sender, EventArgs e)

        {
            
            cn.llenartablaa(dataGridView4.Tag.ToString(), dataGridView4);


        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            cn.llenartablaa(dataGridView5.Tag.ToString(), dataGridView5);
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "6004";
            TextBox[] Grupotextbox = { txtBuscar, TxtCodigoRef, TxtDesc, textBox2 };
            TextBox[] Idtextbox = { txtBuscar, TxtCodigoRef };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dtgProducto;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dtgProducto, Grupotextbox, "ExamenFinal");
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCodigoRef.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtDesc.Text = dataGridView5.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
