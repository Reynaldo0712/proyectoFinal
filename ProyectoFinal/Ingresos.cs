using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinal
{
    class Ingresos
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KGS2S7L;Initial Catalog=ProyectoFinal;Integrated Security=True");

        SqlCommand comando;

        #region ingreos 
        public void GuardarIngresos(DateTime pfecha, string pNom, int pHabi, int id)
        {

            try
            {

                con.Open();

                string lineaComando = $"insert into Ingresos values('{pfecha}','{pNom}','{pHabi}', {id})";

                comando = new SqlCommand(lineaComando, con);

                comando.ExecuteNonQuery();
            }
            catch (Exception error)
            {

                MessageBox.Show("verifique los datos", error.Message);
            }
            finally
            {

                con.Close();
            }


        }

        public DataTable llenarGridIngreso()
        {
            con.Open();

            string lineaComandogrid = $"select fecha, Nombre, Numero, Id_Ingreso from Ingresos";
            comando = new SqlCommand(lineaComandogrid, con);

            comando.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable table = new DataTable();

            data.Fill(table);

            con.Close();

            return table;








        }


        public void ActualizarIngreso(DateTime pfecha, string pNom, int pHabi, int id)
        {

            try
            {

                con.Open();

                string lineaComando = $"update Ingresos set Fecha='{pfecha}',Nombre='{pNom}',Numero='{pHabi}' where Id_Ingreso={id}";

                comando = new SqlCommand(lineaComando, con);

                comando.ExecuteNonQuery();
            }
            catch (Exception error)
            {

                MessageBox.Show("verifique los datos", error.Message);
            }
            finally
            {

                con.Close();
            }


        }

        public void BorrarIngresos(int id)
        {
            try
            {
                con.Open();

                string lineaComando = $"delete from Ingresos where Id_Ingreso={id}";

                comando = new SqlCommand(lineaComando, con);

                comando.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show("Verifique los datos", error.Message);

            }
            finally
            {
                con.Close();
            }



        }
        public DataTable BuscarIngresos(DateTime pFecha)
        {

            con.Open();

            string lineaComando = $"select *from Ingresos where Fecha='{pFecha}'";
            comando = new SqlCommand(lineaComando, con);

            comando.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable table = new DataTable();

            data.Fill(table);

            con.Close();

            return table;




        }


        public DataTable BuscarIngresos1(int pHabi)
        {






            con.Open();

            string lineaComando = $"select *from Ingresos where Numero='{pHabi}'";
            comando = new SqlCommand(lineaComando, con);

            comando.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable table = new DataTable();

            data.Fill(table);

            con.Close();

            return table;




        }

        #endregion








        public void seleccionar(ComboBox combo)
        {
            combo.Items.Clear();

            con.Open();

            SqlCommand comando = new SqlCommand("Select *from Habitaciones", con);


            SqlDataReader dat = comando.ExecuteReader();
            while (dat.Read())
            {



                combo.Items.Add(dat[1].ToString());



            }
            con.Close();
            combo.Items.Insert(0, "---selecionar numero de habitaciones---");
            combo.SelectedIndex = 0;


        }

       






        //nombre del paciente


        public void seleccionarPaciente(ComboBox combo)
        {
            combo.Items.Clear();

            con.Open();

            SqlCommand comando = new SqlCommand("Select *from Pacientes", con);


            SqlDataReader dat = comando.ExecuteReader();
            while (dat.Read())
            {



                combo.Items.Add(dat[2].ToString());



            }
            con.Close();
            combo.Items.Insert(0, "---selecionar Nombre del paciente---");
            combo.SelectedIndex = 0;


        }

       
        




























    }
}
