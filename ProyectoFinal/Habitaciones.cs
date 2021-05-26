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
    class Habitaciones
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KGS2S7L;Initial Catalog=ProyectoFinal;Integrated Security=True");

        SqlCommand comando;


        #region Guardar borrar actualizar habitaciones
        public void GuardarHabi(int pId, int pNumero, string pTipo, int pPrecio)
        {
            try
            {
                con.Open();

                string lineaComando3 = $"insert into Habitaciones values ({pId},{pNumero},'{pTipo}',{pPrecio})";

                comando = new SqlCommand(lineaComando3, con);
                comando.ExecuteNonQuery();
            }
            catch (Exception erro4)
            {
                MessageBox.Show(erro4.Message);
            }
            finally
            {
                con.Close();
            }
        }


        public void ActualizarHabi(int pId, int pNumero, string pTipo, int pPrecio)
        {
            try
            {
                con.Open();

                string lineaComando3 = $"update Habitaciones set Id= {pId}, Numero={pNumero},Tipo= '{pTipo}', Precio= {pPrecio} where Id={pId}";

                comando = new SqlCommand(lineaComando3, con);
                comando.ExecuteNonQuery();
            }
            catch (Exception erro4)
            {
                MessageBox.Show(erro4.Message);
            }
            finally
            {
                con.Close();
            }


        }

        public void BorrarHabiSql(int pId)
        {

            try
            {
                con.Open();

                string lineaComando3 = $"delete from Habitaciones where Id={pId}";

                comando = new SqlCommand(lineaComando3, con);
                comando.ExecuteNonQuery();
            }
            catch (Exception erro4)
            {
                MessageBox.Show(erro4.Message);
            }
            finally
            {
                con.Close();
            }

           

        }
      




       
        public DataTable BuscarHabi(string phabita)
        {

            con.Open();

            String lineComandoGrid = $"select Id, Numero, Tipo, Precio from Habitaciones where Tipo='{phabita}'";
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
