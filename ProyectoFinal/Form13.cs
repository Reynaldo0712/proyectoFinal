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
    public partial class Form13 : Form
    {
        Alta_Medica alta = new Alta_Medica();

        int id;
        int precio;
        public Form13()
        {
            InitializeComponent();
            alta.seleccionar(comboBox1);
            alta.seleccionarPrecio(comboPrecio);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBox1.SelectedIndex > 0)
            {


                string[] valores = alta.captar_datos(id = int.Parse(comboBox1.Text));

                dateInicio.Text = valores[0];
                comboPrecio.Text = valores[1];
                TxtNombre.Text = valores[2];




            }




        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {

                int id = int.Parse(comboBox1.Text);
                string fecha = dateInicio.Text;
                int precio = int.Parse(comboPrecio.Text);
                string nom = TxtNombre.Text;
                string fechasali = dateFechasalida.Text;
                CalcularDias();
                calcularTotal();
                int total1 = Convert.ToInt32(txtDime.Text);
                alta.GuardarAlta(id, fecha, precio, nom, fechasali, total1);
                MessageBox.Show("Datos guardados con exito");
                lbtotal.Text = txtDime.Text;
                lbpesos.Visible = true;
                lbtotal.Visible = true;
                limpiar();
                dataGridView1.DataSource = alta.llenargrid();

            }
            catch(Exception)
            {


                MessageBox.Show("Vefique los datos ingresados");


            }



        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {


            try
            {

                string fechasali = dateFechasalida.Text;
                int id = int.Parse(comboBox1.Text);
                CalcularDias();
                calcularTotal();
                int total1 = Convert.ToInt32(txtDime.Text);
                alta.Actualizar(fechasali, total1, id);
                MessageBox.Show("Datos actualizado con exito");
                lbtotal.Text = txtDime.Text;
                lbpesos.Visible = true;
                lbtotal.Visible = true;
                dataGridView1.DataSource = alta.llenargrid();

            }
            catch(Exception error)
            {


                MessageBox.Show("Vefique los datos ingresados",error.Message);




            }





        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(comboBox1.Text);
                alta.Borrar(id);
                MessageBox.Show("Datos eliminados con exito");
                dataGridView1.DataSource = alta.llenargrid();


            }
            catch(Exception error)
            {


                MessageBox.Show("Verifique los datos");

            }



        }


        public void CalcularDias()
        {

            DateTime fecha2 = dateInicio.Value.Date;
            DateTime fecha = dateFechasalida.Value.Date;
            TimeSpan span = fecha - fecha2;
            int dias = span.Days;
            txtPrecioF.Text = dias.ToString();

        }

       
        private void clacular_Click(object sender, EventArgs e)
        {








        }

        private void comboPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {





            if (comboPrecio.SelectedIndex > 0)
            {


                string[] valores = alta.captar_datosPrecio(precio = int.Parse(comboPrecio.Text));
                txtTotal.Text = valores[0];



            }






        }


        public void calcularTotal()
        {

            try
            {
                int n1, n2, total1;
                n1 = Convert.ToInt32(txtTotal.Text);
                n2 = Convert.ToInt32(txtPrecioF.Text);
                total1 = n1 * n2;
                txtDime.Text = total1.ToString();
            }
            catch(Exception err)
            {


                MessageBox.Show("No fue posible hacer la operacion verifique los datos",err.Message);

            }

        }


        private void limpiar()
        {

            TxtNombre.Clear();
            comboBox1.SelectedIndex = 0;
            comboPrecio.SelectedIndex = 0;
            
         }
        private void dateFechasalida_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
