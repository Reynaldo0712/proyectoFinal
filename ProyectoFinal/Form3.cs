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
    public partial class Form3 : Form
    {
        Pacientes doc2 = new Pacientes();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void BtnGuardarPacie_Click(object sender, EventArgs e)
        {
            


            try
            {
                int pidpac = int.Parse(txtId.Text);
                string pcedu = txtCedu.Text;
                string pNom = txtNom.Text;
                string valor = string.Empty;


                if (radioNo.Checked == true)
                {

                    valor = "No";

                }
                else if (radioSi.Checked == true)
                {
                    valor = "Si";
                }

                doc2.GuardarPaciente(pidpac, pcedu, pNom, valor);
                //limpiar campos
                BorrarCampos2();
                MessageBox.Show("Datos Guardados con Exito");

            }
            catch (Exception error3)
            {
                MessageBox.Show("Verifique los datos ingresados", error3.Message);

            }
            llenarGrid();

        }

        public void llenarGrid()
        {
            Form5 objetofrom = new Form5();
           

            objetofrom.dataGridPacientes.DataSource = doc2.LlenarGridPacientes();


        }



    
       

        private void BorrarCampos2()
        {

            txtCedu.Clear();
            txtId.Clear();
            txtNom.Clear();
            radioNo.Checked = false;
            radioSi.Checked = false;

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

          

            try
            {
                int pidpac = int.Parse(txtId.Text);
                string pcedu = txtCedu.Text;
                string pNom = txtNom.Text;
                string valor = string.Empty;


                if (radioNo.Checked == true)
                {

                    valor = "No";

                }
                else if (radioSi.Checked == true)
                {
                    valor = "Si";
                }

                doc2.ActualizarPaciente(pidpac, pcedu, pNom, valor);
                //limpiar campos
                BorrarCampos2();
                MessageBox.Show("Datos Actualizados con Exito");

            }
            catch (Exception error3)
            {
                MessageBox.Show("Verifique los datos ingresados",error3.Message);

            }


        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {


           


            try
            {
                int pidpac = int.Parse(txtId.Text);
                

              

                doc2.BorrarDatosSqlPaciente(pidpac);
                //limpiar campos
                BorrarCampos2();
                MessageBox.Show("Datos Eliminados con Exito");

            }
            catch (Exception error3)
            {
                MessageBox.Show("Verifique el ID ingresado",error3.Message);

            }






        }
    }
}
