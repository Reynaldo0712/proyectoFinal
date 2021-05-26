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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DatosDoctorsql doc = new DatosDoctorsql();


            try
            {  //sql datos
                int id = int.Parse(txtId.Text);
                string nomb = txtNombre.Text;
                string exec = txtExecu.Text;
                string especial = txtEspecial.Text;

                doc.GuardarDoctor(id, nomb, exec, especial);
                //Limpiar Campos
                BorrarCampos();



                MessageBox.Show("Datos guardados con exito");



            }
            catch (Exception erro2)
            {

                MessageBox.Show("Error verifica los datos ingresados", erro2.Message);


            }




        }

        private void BorrarCampos()
        {


            txtNombre.Clear();
            txtId.Clear();
            txtExecu.Clear();
            txtExecu.Clear();
            txtEspecial.Clear();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {


            DatosDoctorsql doc = new DatosDoctorsql();


            try
            {  //sql datos
                int id = int.Parse(txtId.Text);
                string nomb = txtNombre.Text;
                string exec = txtExecu.Text;
                string especial = txtEspecial.Text;

                doc.Actualizar(id, nomb, exec, especial);
                //Limpiar Campos
                BorrarCampos();



                MessageBox.Show("Datos actualizados con exito");



            }
            catch (Exception erro2)
            {

                MessageBox.Show("Error Verifica los datos ingresados", erro2.Message);


            }




        }

        private void button2_Click(object sender, EventArgs e)
        {


            DatosDoctorsql doc = new DatosDoctorsql();


            try
            {  //sql datos
                int id = int.Parse(txtId.Text);


                doc.BorrarDatosSql(id);
                //Limpiar Campos
                BorrarCampos();



                MessageBox.Show("Datos Eliminados con exito");



            }
            catch (Exception erro2)
            {

                MessageBox.Show("Error verifica el id ingresado", erro2.Message);


            }
        }

    }
}
