
namespace VistaLogistica
{
    partial class Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navegador1 = new NavegadorVista.Navegador();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtLinea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.TxtCodigoRef = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(26, 14);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 187);
            this.navegador1.TabIndex = 70;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtLinea);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtDesc);
            this.groupBox2.Controls.Add(this.TxtCodigoRef);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(52, 223);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(713, 221);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(319, 37);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(306, 22);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Tag = "Nit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(23, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 47;
            this.label5.Text = "Apellido";
            // 
            // TxtLinea
            // 
            this.TxtLinea.Location = new System.Drawing.Point(319, 143);
            this.TxtLinea.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLinea.Name = "TxtLinea";
            this.TxtLinea.Size = new System.Drawing.Size(306, 22);
            this.TxtLinea.TabIndex = 46;
            this.TxtLinea.Tag = "Ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(23, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "Nombre";
            // 
            // TxtDesc
            // 
            this.TxtDesc.Location = new System.Drawing.Point(319, 111);
            this.TxtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(306, 22);
            this.TxtDesc.TabIndex = 42;
            this.TxtDesc.Tag = "Apellido";
            // 
            // TxtCodigoRef
            // 
            this.TxtCodigoRef.Location = new System.Drawing.Point(319, 70);
            this.TxtCodigoRef.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodigoRef.Name = "TxtCodigoRef";
            this.TxtCodigoRef.Size = new System.Drawing.Size(306, 22);
            this.TxtCodigoRef.TabIndex = 39;
            this.TxtCodigoRef.Tag = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ciudad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(319, 177);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 22);
            this.textBox1.TabIndex = 49;
            this.textBox1.Tag = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 48;
            this.label4.Text = "Telefono";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 466);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(770, 289);
            this.dataGridView1.TabIndex = 71;
            this.dataGridView1.Tag = "tbl_Clientes";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 767);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtLinea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.TextBox TxtCodigoRef;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}