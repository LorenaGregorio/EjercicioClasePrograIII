﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaCoffee.Clases;

namespace TiendaCoffee
{
    public partial class FormTipodeCafe : Form
    {
        Conexion con = new Conexion();

        //se declara una variable de tipo boleana que sirve para indicar si el usuario presiono el boton editar
        bool editar;
        int IdTipoCafe;

        public FormTipodeCafe()
        {
            InitializeComponent();
        }
        public void ActualizarGrid()
        {
            // Aca se hace una funcion (select) para mostrar los datos
            con.ActualizarGrid(this.dataGridView1, "Select * from TipoCafeTBL");
        }

        private void FormTipodeCafe_Load(object sender, EventArgs e)
        {
            // se llama al metodo actulizargrid
            this.ActualizarGrid();
            editar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (editar)
            {
                //Se realiza un update
                con.Conectar();
                string consulta = "update TipoCafeTBL set TipodeCafe = '" + textBox1.Text + "'  where IdTipoCafe = " + IdTipoCafe + " ;";
                con.EjecutarSql(consulta);
                this.ActualizarGrid();
                con.Desconectar();
                
                editar = false;

            }
            else
            {
                con.Conectar();

                //Se crea una consulta para insertar los datos (Guardar)
                string consulta = "insert into TipoCafeTBL (TipodeCafe) values ('" + textBox1.Text + "' );";
                //con esta funcion ejecuto la consulta de arriba en codigo sql
                con.EjecutarSql(consulta);
                this.ActualizarGrid();
                con.Desconectar();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //La variable editar se agrega para que sea true
            editar = true;

            // se agregan las campos de los datos por columna como un vector
            IdTipoCafe = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // se agregan las campos de los datos por columna como un vector 
            IdTipoCafe = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var resultado = MessageBox.Show("¿Desea eliminar el dato", "Confirme si desea borrar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                con.Conectar();
                string consulta = "delete from TipoCafeTBL where IdTipoCafe = '" + IdTipoCafe + "' ; ";
                con.EjecutarSql(consulta);
                this.ActualizarGrid();
                con.Desconectar();
            }
            else
            {
                return;
            }
        }
    }
}
