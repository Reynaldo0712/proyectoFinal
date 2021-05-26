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
    public partial class Form4 : Form
    {
        Habitaciones habi = new Habitaciones();
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void BtnGuardarHabi_Click(object sender, EventArgs e)
        {
        
            

            try
            {
                int pIdd = int.Parse(txtIddd.Text);
                int pNumero = int.Parse(txtNumer.Text);
                int pPrecio = int.Parse(txtPrecio.Text);

                string valor1 = string.Empty;

                if (comboTipo.Text == "Doble")
                {

                    valor1 = "Doble";

                }
                else if (comboTipo.Text == "Privada")
                {

                    valor1 = "Privada";
                }
                else if (comboTipo.Text == "Suite")
                {
                    valor1 = "Suite";
                }

                habi.GuardarHabi(pIdd, pNumero, valor1, pPrecio);
                //limpiarCampos
                BorrarCampos();

                MessageBox.Show("Datos guardados con exito");
                
            }
            catch(Exception errror5)
            {

                MessageBox.Show("Verifique los datos a guardar",errror5.Message);

            }
        }
        private void BorrarCampos()
        {

            txtIddd.Clear();
            txtNumer.Clear();
            txtPrecio.Clear();
            comboTipo.SelectedIndex = -1;
            



        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

         


            try
            {
                int pIdd = int.Parse(txtIddd.Text);
                int pNumero = int.Parse(txtNumer.Text);
                int pPrecio = int.Parse(txtPrecio.Text);

                string valor1 = string.Empty;

                if (comboTipo.Text == "Doble")
                {

                    valor1 = "Doble";

                }
                else if (comboTipo.Text == "Privada")
                {

                    valor1 = "Privada";
                }
                else if (comboTipo.Text == "Suite")
                {
                    valor1 = "Suite";
                }

                habi.ActualizarHabi(pIdd, pNumero, valor1, pPrecio);
                //limpiarCampos
                BorrarCampos();

                MessageBox.Show("Datos Actualizados con exito");

            }
            catch (Exception errror5)
            {

                MessageBox.Show("Verifique los datos a actualizar",errror5.Message);

            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
         


            try
            {
                int pIdd = int.Parse(txtIddd.Text);

                habi.BorrarHabiSql(pIdd);
                //limpiarCampos
                BorrarCampos();

                MessageBox.Show("Datos eliminados con exito");

            }
            catch (Exception errror5)
            {

                MessageBox.Show("Verifique los datos a eliminar", errror5.Message);

            }

        }

        
    }
}
