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
    public partial class Form12 : Form
    {
        Ingresos ingreso = new Ingresos();
       
  
        public Form12()
        {
            InitializeComponent();
            ingreso.seleccionar(comboHabi);
            ingreso.seleccionarPaciente(comboNombre);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
    


                GuardarIngresos();
        }


        private void GuardarIngresos()
        {

             
            try
            {


                DateTime fecha = dateFecha.Value.Date;
                string nom = comboNombre.Text;
                int pid = int.Parse(txtId.Text);
                int valor1 = int.Parse(comboHabi.Text);                           
                ingreso.GuardarIngresos(fecha, nom, valor1, pid);
                MessageBox.Show("Datos guardados con exito");
                limpiarCampos();
                llenarGrid();
            }
            catch(Exception error)
            {


                MessageBox.Show("Verifique los datos ingresados", error.Message);

            }


        }

        private void llenarGrid()
        {

             


            dataGridHabi.DataSource = ingreso.llenarGridIngreso();



        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

             
            try
            {
               DateTime fecha = dateFecha.Value.Date;
                string nom = comboNombre.Text;
                int pid = int.Parse(txtId.Text);
                int valor1 = int.Parse(comboHabi.Text);
            

               

                ingreso.ActualizarIngreso(fecha, nom, valor1,pid);
                MessageBox.Show("Datos actualizados con exito");
               
                limpiarCampos();
                llenarGrid();
                
            }
            catch (Exception error)
            {


                MessageBox.Show("Verifique los datos ingresados", error.Message);

            

       
            
            
            }  
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

             
            try
            {

                int id = int.Parse(txtId.Text);



                ingreso.BorrarIngresos(id);
                MessageBox.Show("Datos Eliminados con exito");
                limpiarCampos();
                llenarGrid();

            }
            catch (Exception error)
            {


                MessageBox.Show("Verifique los datos ingresados", error.Message);


            }
        }



        private void limpiarCampos()
        {
        
            txtId.Clear();
            comboNombre.SelectedIndex = 0;
            comboHabi.SelectedIndex = 0;
           




        }

        private void comboHabi_SelectedIndexChanged(object sender, EventArgs e)
        {
           


                

            

        }

        private void comboNombre_SelectedIndexChanged(object sender, EventArgs e)
        {

           






            
        }
    }     
    
}
