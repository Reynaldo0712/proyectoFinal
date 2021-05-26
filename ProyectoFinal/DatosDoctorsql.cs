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
    class DatosDoctorsql
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KGS2S7L;Initial Catalog=ProyectoFinal;Integrated Security=True");

        SqlCommand comando;

        //metodo medicos sql
      #region  Guadar actualizar borrar doctores buscar

        public void GuardarDoctor(int pId, string nom, string pExecua, string pEspecialidad)
        {

            try
            {
                con.Open();

                string lineaComando = $"Insert into Doctores values({pId}, '{nom}','{pExecua}','{pEspecialidad}')";

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
        //actualizar datos
        public void Actualizar(int pId, string nom, string pExecua, string pEspecialidad)
        {

            try
            {
                con.Open();

                string lineaComando = $"update Doctores set id = {pId}, Nombre='{nom}',Exequatur= '{pExecua}', Especialidad= '{pEspecialidad}' where Id={pId}";

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
        //borrar Datos 

        public void BorrarDatosSql(int pId)
        {

            try
            {
                con.Open();

                string lineaComando = $"delete from Doctores where Id = {pId}";

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
       
  
       
            
        
            
     
        public DataTable BuscarDoctor(string pNom)
        {


            con.Open();

            String lineComandoGrid = $"select Id, Nombre, Exequatur, Especialidad from Doctores where Nombre = '{pNom}'";

            comando = new SqlCommand(lineComandoGrid, con);

            comando.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable table = new DataTable();

            data.Fill(table);

            con.Close();

            return table;
        }

        public DataTable BuscarDoctor2(string pEspecial)
        {


            con.Open();

            String lineComandoGrid = $"select Id, Nombre, Exequatur, Especialidad from Doctores where Especialidad = '{pEspecial}'";

            comando = new SqlCommand(lineComandoGrid, con);

            comando.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable table = new DataTable();

            data.Fill(table);

            con.Close();

            return table;
        }
       



        public DataTable LlennarGrid()
        {


            con.Open();

            String lineComandoGrid = $"select *from Doctores";

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
