using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace ProyectoFinal
{
    class Pacientes
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KGS2S7L;Initial Catalog=ProyectoFinal;Integrated Security=True");

        SqlCommand comando;

        #region Guadar borrar actualizar pacientes
        public void GuardarPaciente(int pIdPac, string pcedula, string pNombre, string pAsegura)
        {
            try
            {
                con.Open();

                string lineaComando2 = $"insert into Pacientes values({pIdPac},'{pcedula}','{pNombre}', '{pAsegura}')";

                comando = new SqlCommand(lineaComando2, con);

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
       
        //actualizar
        public void ActualizarPaciente(int pIdPac, string pcedula, string pNombre, string pAsegura)
        {

            try
            {
                con.Open();

                string lineaComando2 = $"update Pacientes set Id= {pIdPac}, Cedula={pcedula},Nombre= '{pNombre}', Asegurado= '{pAsegura}' where Id={pIdPac}";

                comando = new SqlCommand(lineaComando2, con);

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

             //borrar
        public void BorrarDatosSqlPaciente(int pIdPac)
        {


            try
            {
                con.Open();

                string lineaComando2 = $"delete from Pacientes where Id={pIdPac}";

                comando = new SqlCommand(lineaComando2, con);

                comando.ExecuteNonQuery();
            }
            catch (Exception error)
            {

                MessageBox.Show("Verifique el ID ingresados", error.Message);


            }
            finally
            {
                con.Close();
            }

        }
      



       
        public DataTable Buscar(string Pnom)
        {


            con.Open();

            String lineComandoGrid = $"select *from Pacientes where Nombre='{Pnom}'";
            comando = new SqlCommand(lineComandoGrid, con);

            comando.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable table = new DataTable();

            data.Fill(table);

            con.Close();

            return table;
        }
        public DataTable Buscar2(string Pced)
        {


            con.Open();

            String lineComandoGrid = $"select *from Pacientes where Cedula='{Pced}'";

            comando = new SqlCommand(lineComandoGrid, con);

            comando.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable table = new DataTable();

            data.Fill(table);

            con.Close();

            return table;
        }

        public DataTable Buscar3(string pAsegura)
        {


            con.Open();

            String lineComandoGrid = $"select *from Pacientes where Asegurado='{pAsegura}'";

            comando = new SqlCommand(lineComandoGrid, con);

            comando.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable table = new DataTable();

            data.Fill(table);

            con.Close();

            return table;
        }


        //llenar grid view

        public DataTable LlenarGridPacientes()
        {

            con.Open();

            String lineComandoGrid = $"select *from Pacientes";
            comando = new SqlCommand(lineComandoGrid, con);

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
