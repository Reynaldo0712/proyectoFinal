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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BuscarDoc()
        {
            DatosDoctorsql doctor = new DatosDoctorsql();

         
            string nom = txtNombre.Text;
         


            dataGridMedicos.DataSource = doctor.BuscarDoctor(nom);


        }

        private void BuscarDoc1()
        {

            DatosDoctorsql doctor = new DatosDoctorsql();

            string pEspecia = txtEspecia.Text;

            dataGridMedicos.DataSource = doctor.BuscarDoctor2(pEspecia);

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            BuscarDoc();
        }

        private void txtEspecia_TextChanged(object sender, EventArgs e)
        {
            BuscarDoc1();
        }

        private void BtnNom_Click(object sender, EventArgs e)
        {
            txtNombre.Visible = true;
            txtEspecia.Visible = false;
            txtEspecia.Clear();


        }

        private void BtnEspecia_Click(object sender, EventArgs e)
        {
            txtEspecia.Visible = true;
            txtNombre.Visible = false;
            txtNombre.Clear();
        }

        private void BTnbuscar_Click(object sender, EventArgs e)
        {


            









           
        }

       
    }
}
