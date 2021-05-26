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
    public partial class Form10 : Form
    {
        Alta_Medica alta = new Alta_Medica();
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            DateTime fecha = dateTimePicker1.Value.Date;

            dataGridView1.DataSource = alta.BUscarDatos(fecha);










        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


            string nom = txtNom.Text;

            dataGridView1.DataSource = alta.BuscarDatos2(nom);






        }

        private void brnNombre_Click(object sender, EventArgs e)
        {
            txtNom.Visible = true;
            Lab3.Visible = true;
            dateTimePicker1.Visible = false;
            Labelfecha.Visible = false;
        }

        private void fecha_Click(object sender, EventArgs e)
        {

            txtNom.Visible = false;
            Lab3.Visible = false;

            dateTimePicker1.Visible = true;
            Labelfecha.Visible = true;
            txtNom.Clear();


        }

    }
}
