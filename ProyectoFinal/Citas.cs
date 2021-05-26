using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinal
{
    class Citas
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KGS2S7L;Initial Catalog=ProyectoFinal;Integrated Security=True");

        SqlCommand comando;


        #region citas sql guardar borrar actualizar

        public void GuardarCitas(DateTime pFecha, string nom, string pDoctor, string pHora, int id)
        {

            try
            {
                con.Open();

                string lineaComando = $"insert into Citas values('{pFecha}', '{nom}', '{pDoctor}','{pHora}',{id})";

                comando = new SqlCommand(lineaComando, con);

                comando.ExecuteNonQuery();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);

            }
            finally
            {

                con.Close();

            }

        }


        public DataTable LlenarGriCitas()
        {

            con.Open();

            String lineComandoGrid = $"select *from Citas";
            comando = new SqlCommand(lineComandoGrid, con);

            comando.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable table = new DataTable();

            data.Fill(table);


            con.Close();

            return table;




        }


        public void ActualizarCitas(DateTime pFecha, string nom, string pDoctor, string pHora, int id)
        {

            try
            {
                con.Open();

                string lineaComando = $"update Citas set Fecha='{pFecha}', Nombre='{nom}', Doctor='{pDoctor}', Hora='{pHora}' where ID={id}";

                comando = new SqlCommand(lineaComando, con);

                comando.ExecuteNonQuery();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);

            }
            finally
            {

                con.Close();

            }





        }


        public void BorrarCitas(int nom)
        {


            try
            {
                con.Open();

                string lineaComando = $"delete from Citas where ID='{nom}'";

                comando = new SqlCommand(lineaComando, con);

                comando.ExecuteNonQuery();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);

            }
            finally
            {

                con.Close();

            }




        }

         


        //buscar citas medicas

        public DataTable BuscarCita(string pNom)
        {
            con.Open();

            string lineaComando = $"select *from Citas where Nombre='{pNom}'";
            comando = new SqlCommand(lineaComando, con);

            comando.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable table = new DataTable();

            data.Fill(table);

            con.Close();

            return table;




        }

        public DataTable BuscarCita1(string PnomDoc)
        {

            con.Open();

            string lineaComando = $"select *from Citas where Doctor='{PnomDoc}'";
            comando = new SqlCommand(lineaComando, con);

            comando.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable table = new DataTable();

            data.Fill(table);

            con.Close();

            return table;




        }

        public DataTable BuscarCita2(DateTime pFecha)
        {

            con.Open();

            string lineaComando = $"select *from Citas where Fecha='{pFecha}'";
            comando = new SqlCommand(lineaComando, con);

            comando.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable table = new DataTable();

            data.Fill(table);

            con.Close();

            return table;




        }

#endregion
    }
}
