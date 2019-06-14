using System;
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
    public partial class Form1 : Form
    {
         // Se crea el objeto conexion para que se obtegan los datos
        Conexion con = new Conexion();

        int Id;
        bool editar;
        string  cadena, car,numero;
      
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        // Metodo para actualizar datagridview
        public void ActualizarGrid()
        {
            // Aca se hace una funcion (select) para mostrar los datos
            con.ActualizarGrid(this.dataGridView1,
            "select IdCliente, NombreCliente, TipoCliente,TipodeCafe, TipodeAzucar, TipodeLeche  ,Temperatura from  DatosCoffeeTBL, TipoCafeTBL, TipoAzucarTBL, TipoLecheTBL where (( dbo.DatosCoffeeTBL.TipoCafe = dbo.TipoCafeTBL.IdTipoCafe and  dbo.DatosCoffeeTBL.TipoAzucar = dbo.TipoAzucarTBL.IdAzucar) and  dbo.DatosCoffeeTBL.TipoLeche = dbo.TipoLecheTBL.IdLeche)");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // se llama al metodo actulizargrid
            this.ActualizarGrid();
            //llamo al metodo para actulizar el combobox
            con.ComboTipoCafe(combtipocafe);
            con.ComboTipoAzucar(combtipoazucar);
            con.ComboTipoLeche(combtipoleche);
        }

        // metodo para limpiar los textbox
        public void limpiarTextbox()
        {
            txtnombre.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            //// se  crea un if para ver si el usuario seleciono la opcion de guardar o editar
            //if (editar)
            //{
            //    //Se realiza un update
            //    con.Conectar();
            //    string consulta = "update DatosCoffeeTBL set NombreCliente = '" + txtnombre.Text + "', TipoCliente = " + combtipocliente.SelectedItem.ToString() + ", TipoCafe = '" + Convert.ToInt16( textBox1.Text) + ", TipoAzucar =' " + Convert.ToInt16(textBox2.Text) + ", TipoLeche = '" + Convert.ToInt16(textBox3.Text) + ", Temperatura = '" + combtemperatura.Text + "' where Id = " + Id + " ;";
            //    con.EjecutarSql(consulta);
            //    this.ActualizarGrid();
            //    con.Desconectar();
            //    this.limpiarTextbox();
            //    editar = false;
            //}
            //else
            //{
                con.Conectar();

                //Se crea una consulta para insertar los datos (Guardar)
                string consulta = "insert into DatosCoffeeTBL (NombreCliente, TipoCliente, TipoCafe, TipoAzucar, TipoLeche, Temperatura ) values ('" + txtnombre.Text + "', '" + combtipocliente.SelectedItem.ToString() + "','" + Convert.ToInt16(textBox1.Text) + "','" + Convert.ToInt16(textBox2.Text) + "', " + Convert.ToInt16(textBox3.Text) + ",'" + combtemperatura.SelectedItem.ToString() + "' );";
                //con esta funcion ejecuto la consulta de arriba en codigo sql
                con.EjecutarSql(consulta);
                this.ActualizarGrid();
                con.Desconectar();
                this.limpiarTextbox();
            //}
        }

        private void Combtipodecafe2(object sender, EventArgs e)
        {
          

        }

        private void tipoCafeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codigo para cambiar de formulario
            FormTipodeCafe nuevos = new FormTipodeCafe();

            nuevos.Show();
        }

        private void tipoAzucarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codigo para cambiar de formulario
            FormTipodeAzucar nuevos = new FormTipodeAzucar();
            nuevos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtbuscar.Text =="")
            {
                MessageBox.Show("Ingrese un Tipo de Cafè");
            }
            else
            {
                con.ActualizarGrid(this.dataGridView1, "select IdCliente, NombreCliente, TipoCliente,TipodeCafe, TipodeAzucar, TipodeLeche  ,Temperatura from  DatosCoffeeTBL, TipoCafeTBL, TipoAzucarTBL, TipoLecheTBL where (( dbo.DatosCoffeeTBL.TipoCafe = dbo.TipoCafeTBL.IdTipoCafe and  dbo.DatosCoffeeTBL.TipoAzucar = dbo.TipoAzucarTBL.IdAzucar) and  dbo.DatosCoffeeTBL.TipoLeche = dbo.TipoLecheTBL.IdLeche)  and TipodeCafe like '" + txtbuscar.Text + "%'; ");
            }
           
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            con.ActualizarGrid(this.dataGridView1, "select IdCliente, NombreCliente, TipoCliente,TipodeCafe, TipodeAzucar, TipodeLeche  ,Temperatura from  DatosCoffeeTBL, TipoCafeTBL, TipoAzucarTBL, TipoLecheTBL where (( dbo.DatosCoffeeTBL.TipoCafe = dbo.TipoCafeTBL.IdTipoCafe and  dbo.DatosCoffeeTBL.TipoAzucar = dbo.TipoAzucarTBL.IdAzucar) and  dbo.DatosCoffeeTBL.TipoLeche = dbo.TipoLecheTBL.IdLeche)  and TipodeCafe like '" + txtbuscar.Text + "%'; ");
        }

        private void combtipocafe_SelectedIndexChanged(object sender, EventArgs e)
        {
            cadena = combtipocafe.SelectedItem.ToString().Trim();
            for (int i = 0; i < cadena.Length; i++)
            {
                car = cadena.Substring(i, 1);
                switch (car)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        numero = numero + car;
                        break;
                    default:
                        break;
                }

            }
            textBox1.Clear();
            textBox1.Text = numero;
            numero = "";
        }

        private void combtipoleche_SelectedIndexChanged(object sender, EventArgs e)
        {
            cadena = combtipoleche.SelectedItem.ToString().Trim();
            for (int i = 0; i < cadena.Length; i++)
            {
                car = cadena.Substring(i, 1);
                switch (car)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        numero = numero + car;
                        break;
                    default:
                        break;
                }

            }
            textBox3.Clear();
            textBox3.Text = numero;
            numero = "";
        }

        private void combtipoazucar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cadena = combtipoazucar .SelectedItem.ToString().Trim();
            for (int i = 0; i < cadena.Length; i++)
            {
                car = cadena.Substring(i, 1);
                switch (car)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        numero = numero + car;
                        break;
                    default:
                        break;
                }

            }
            textBox2.Clear();
            textBox2.Text = numero;
            numero = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
       
           
        }
    }
    

}
