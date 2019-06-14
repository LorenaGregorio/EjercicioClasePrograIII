using System;

namespace TiendaCoffee
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.combtipocliente = new System.Windows.Forms.ComboBox();
            this.combtipocafe = new System.Windows.Forms.ComboBox();
            this.combtipoazucar = new System.Windows.Forms.ComboBox();
            this.combtipoleche = new System.Windows.Forms.ComboBox();
            this.combtemperatura = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoCafeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoAzucarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Cafe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Azucar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de Leche";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Temperatura";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(153, 41);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(182, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // combtipocliente
            // 
            this.combtipocliente.FormattingEnabled = true;
            this.combtipocliente.Items.AddRange(new object[] {
            "Frecuente",
            "No frecuente"});
            this.combtipocliente.Location = new System.Drawing.Point(153, 87);
            this.combtipocliente.Name = "combtipocliente";
            this.combtipocliente.Size = new System.Drawing.Size(182, 21);
            this.combtipocliente.TabIndex = 7;
            // 
            // combtipocafe
            // 
            this.combtipocafe.FormattingEnabled = true;
            this.combtipocafe.Location = new System.Drawing.Point(153, 142);
            this.combtipocafe.Name = "combtipocafe";
            this.combtipocafe.Size = new System.Drawing.Size(182, 21);
            this.combtipocafe.TabIndex = 8;
            this.combtipocafe.SelectedIndexChanged += new System.EventHandler(this.combtipocafe_SelectedIndexChanged);
            // 
            // combtipoazucar
            // 
            this.combtipoazucar.FormattingEnabled = true;
            this.combtipoazucar.Location = new System.Drawing.Point(153, 194);
            this.combtipoazucar.Name = "combtipoazucar";
            this.combtipoazucar.Size = new System.Drawing.Size(182, 21);
            this.combtipoazucar.TabIndex = 9;
            this.combtipoazucar.SelectedIndexChanged += new System.EventHandler(this.combtipoazucar_SelectedIndexChanged);
            // 
            // combtipoleche
            // 
            this.combtipoleche.FormattingEnabled = true;
            this.combtipoleche.Location = new System.Drawing.Point(153, 247);
            this.combtipoleche.Name = "combtipoleche";
            this.combtipoleche.Size = new System.Drawing.Size(182, 21);
            this.combtipoleche.TabIndex = 10;
            this.combtipoleche.SelectedIndexChanged += new System.EventHandler(this.combtipoleche_SelectedIndexChanged);
            // 
            // combtemperatura
            // 
            this.combtemperatura.FormattingEnabled = true;
            this.combtemperatura.Items.AddRange(new object[] {
            "Frío",
            "Caliente"});
            this.combtemperatura.Location = new System.Drawing.Point(153, 296);
            this.combtemperatura.Name = "combtemperatura";
            this.combtemperatura.Size = new System.Drawing.Size(182, 21);
            this.combtemperatura.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 131);
            this.dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "GUARDAR PEDIDO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(632, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "BUSQUEDA POR TIPO DE CAFE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(535, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 46);
            this.label8.TabIndex = 16;
            this.label8.Text = "TIENDA COFFEE";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoCafeToolStripMenuItem,
            this.tipoAzucarToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tipoCafeToolStripMenuItem
            // 
            this.tipoCafeToolStripMenuItem.Name = "tipoCafeToolStripMenuItem";
            this.tipoCafeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.tipoCafeToolStripMenuItem.Text = "Tipo Cafe";
            this.tipoCafeToolStripMenuItem.Click += new System.EventHandler(this.tipoCafeToolStripMenuItem_Click);
            // 
            // tipoAzucarToolStripMenuItem
            // 
            this.tipoAzucarToolStripMenuItem.Name = "tipoAzucarToolStripMenuItem";
            this.tipoAzucarToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.tipoAzucarToolStripMenuItem.Text = "Tipo Azucar";
            this.tipoAzucarToolStripMenuItem.Click += new System.EventHandler(this.tipoAzucarToolStripMenuItem_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(635, 208);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(166, 20);
            this.txtbuscar.TabIndex = 19;
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(674, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "BUSCAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(341, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(38, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(341, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(38, 20);
            this.textBox2.TabIndex = 23;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(341, 248);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(38, 20);
            this.textBox3.TabIndex = 24;
            this.textBox3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 515);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.combtemperatura);
            this.Controls.Add(this.combtipoleche);
            this.Controls.Add(this.combtipoazucar);
            this.Controls.Add(this.combtipocafe);
            this.Controls.Add(this.combtipocliente);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TiendaCoffee";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Combtipodecafe2_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ComboBox combtipocliente;
        private System.Windows.Forms.ComboBox combtipocafe;
        private System.Windows.Forms.ComboBox combtipoazucar;
        private System.Windows.Forms.ComboBox combtipoleche;
        private System.Windows.Forms.ComboBox combtemperatura;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoCafeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoAzucarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

