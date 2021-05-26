using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form9 : Form
    {
        Ingresos ingreso = new Ingresos();
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateFecha_ValueChanged(object sender, EventArgs e)
        {
            
             


            DateTime Fecha = dateFecha.Value.Date;

            dataGridView1.DataSource = ingreso.BuscarIngresos(Fecha);

     




        }

       

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

            try
            {

                int valor = int.Parse(txtTipo.Text);


                dataGridView1.DataSource = ingreso.BuscarIngresos1(valor);

            }
            catch(Exception)
            {
                MessageBox.Show("Datos incorrectos");
            }


        }
    }
}
