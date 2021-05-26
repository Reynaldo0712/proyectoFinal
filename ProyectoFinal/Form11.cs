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
    public partial class Form11 : Form
    {

        Citas MEDICAS = new Citas();
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

             


            try
            {
                DateTime fecha = fechaPicker.Value.Date;
                string nome = TxtNomPaci.Text;
                string doctor = TxtDoctor.Text;
                string hora = txtHora.Text;
                int id = int.Parse(txtId.Text);


                MEDICAS.GuardarCitas(fecha, nome, doctor, hora,id);
                MessageBox.Show("Datos guardados con exito");

                llenargridCitas();
                LimpiarCampos();
            }
            catch(Exception)
            {


                MessageBox.Show("Verifica los datos ingresados");

            }
           



        }
        private void llenargridCitas()
        {



            MEDICAS.LlenarGriCitas();

            dataGridCitas.DataSource = MEDICAS.LlenarGriCitas();





        }

        private void ActualizarCitas()
        {


            


            try
            {
                DateTime fecha = fechaPicker.Value.Date;
                string nome = TxtNomPaci.Text;
                string doctor = TxtDoctor.Text;
                string hora = txtHora.Text;
                int id = int.Parse(txtId.Text);


                MEDICAS.ActualizarCitas(fecha, nome, doctor, hora,id);
                MessageBox.Show("Datos Actualizados con exito");

                llenargridCitas();
                LimpiarCampos();
            }
            catch (Exception)
            {


                MessageBox.Show("Verifica los datos ingresados");

            }

            
       

        }

        private void BorrarCitasMedicas()
        {

            

            try
            {
                
                int Id = int.Parse(txtId.Text);


                MEDICAS.BorrarCitas(Id);
                MessageBox.Show("Datos eliminados con exito");

                llenargridCitas();
                LimpiarCampos();
            }
            catch (Exception)
            {


                MessageBox.Show("Verifica los datos ingresados");

            }


            
        }

        private void LimpiarCampos()
        {

            TxtDoctor.Clear();
            txtHora.Clear();
            TxtNomPaci.Clear();
            txtId.Clear();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarCitas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BorrarCitasMedicas();
        }
    }
    
}
