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
    public partial class Form5 : Form
    {
        Pacientes pacien = new Pacientes();
        public Form5()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void Buscar()
        {


           
            string Pnom = TxtNom.Text;



            dataGridPacientes.DataSource = pacien.Buscar(Pnom);



        }


        private void buscar2()
        {
      


            string cedu = TxtCed.Text;
            dataGridPacientes.DataSource = pacien.Buscar2(cedu);


        }

        public void buscar3()
        {

            


            string radio = txtAseg.Text;
        
            dataGridPacientes.DataSource = pacien.Buscar3(radio);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LbNom.Visible = true;
            TxtCed.Visible = true;
           




            TxtNom.Visible = false;
            txtAseg.Visible = false;
            lbAse.Visible = false;
            txtAseg.Clear();
            TxtNom.Clear();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {



            TxtNom.Visible = true;
            LbNom.Visible = true;

            TxtCed.Visible = false;
            txtAseg.Visible = false;
            lbAse.Visible = false;

            TxtCed.Clear();
            txtAseg.Clear();

        }

        private void TxtCed_TextChanged(object sender, EventArgs e)
        {
            
            buscar2();
           

        }

        private void TxtNom_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            lbAse.Visible = true;
            LbNom.Visible = true;
            txtAseg.Visible = true;

            TxtNom.Visible = false;
            TxtCed.Visible = false;
            TxtNom.Clear();
            TxtCed.Clear();



        }
       
        private void txtAseg_TextChanged(object sender, EventArgs e)
        {
            buscar3();
        }
    }
}
