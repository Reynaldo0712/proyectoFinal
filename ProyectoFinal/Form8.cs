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
    public partial class Form8 : Form
    {
        Citas medicas = new Citas();
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPacien.Visible = true;
            txtDoctor.Visible = false;
            dateTimePicker1.Visible = false;
            LBFecha.Visible = false;
            txtDoctor.Clear();


        }

        private void txtPacien_TextChanged(object sender, EventArgs e)
        {


          
            
            string nom = txtPacien.Text;


            dataGridView1.DataSource = medicas.BuscarCita(nom);
        }

        private void txtDoctor_TextChanged(object sender, EventArgs e)
        {

            

            string pDoc = txtDoctor.Text;


            dataGridView1.DataSource = medicas.BuscarCita1(pDoc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDoctor.Visible = true;
            txtPacien.Visible = false;
          
            dateTimePicker1.Visible = false;
            LBFecha.Visible = false;
            txtPacien.Clear();
            
             
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            

            DateTime fecha = dateTimePicker1.Value.Date;


            dataGridView1.DataSource = medicas.BuscarCita2(fecha);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            txtDoctor.Visible = false;
            txtPacien.Visible = false;
            dateTimePicker1.Visible = true;
            LBFecha.Visible = true;
            txtPacien.Clear();
            txtDoctor.Clear();



        }
    }
}
