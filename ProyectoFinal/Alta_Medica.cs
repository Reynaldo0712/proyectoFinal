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
    class Alta_Medica
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KGS2S7L;Initial Catalog=ProyectoFinal;Integrated Security=True");
        SqlCommand comando;


        public void seleccionar(ComboBox combo)
        {
            combo.Items.Clear();

            con.Open();

            SqlCommand comando = new SqlCommand("Select *from Ingresos", con);


            SqlDataReader dat = comando.ExecuteReader();
            while (dat.Read())
            {



                combo.Items.Add(dat[3].ToString());



            }
            con.Close();
            combo.Items.Insert(0, "-selecionar Id del paciente-");
            combo.SelectedIndex = 0;


        }

        public string[] captar_datos(int ID)
        {
            con.Open();

            comando = new SqlCommand($"select *from Ingresos where Id_Ingreso={ID}", con);
            SqlDataReader dat = comando.ExecuteReader();

            string[] resultado = null;
            while (dat.Read())
            {


                string[] valores =
                {

                    dat[0].ToString(),
                    dat[2].ToString(),
                    dat[1].ToString(),
                   
                   
                  


                };

                resultado = valores;

            }

            con.Close();

            return resultado;

        }




        public void GuardarAlta(int pId, string Fecha, int habita, string nom, string fecha_Salida, int total)
        {



            con.Open();

            string lineaComando = $"Insert into AltaMedica1 values({pId}, '{Fecha}','{nom}','{habita}','{fecha_Salida}',{total})";

            comando = new SqlCommand(lineaComando, con);

            comando.ExecuteNonQuery();


            con.Close();




        }


        public DataTable llenargrid()
        {






            con.Open();

            string lineaComando = $"select *from AltaMedica1";
            comando = new SqlCommand(lineaComando, con);

            comando.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable table = new DataTable();

            data.Fill(table);

            con.Close();

            return table;




        }

        
        public void Actualizar(string Fecha, int total ,int pId)
        {

            con.Open();

            string lineaComando = $"update AltaMedica1 set fecha_Salida='{Fecha}',total={total} where Id={pId}";
            comando = new SqlCommand(lineaComando, con);

            comando.ExecuteNonQuery();

            con.Close();





        }

        public void Borrar(int pId)
        {

            con.Open();

            string lineaComando = $"delete from AltaMedica1 where Id={pId}";
            comando = new SqlCommand(lineaComando, con);

            comando.ExecuteNonQuery();

            con.Close();





        }


        //Busqueda



        public DataTable BUscarDatos(DateTime fecha)
        {

            con.Open();

            string lineaComando = $"select *from AltaMedica1 where fecha_Salida='{fecha}'";
            comando = new SqlCommand(lineaComando, con);

            comando.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable table = new DataTable();

            data.Fill(table);

            con.Close();

            return table;









        }


        public DataTable BuscarDatos2(string Nom)
        {

            con.Open();

            string lineaComando = $"select *from AltaMedica1 where Nombre='{Nom}'";
            comando = new SqlCommand(lineaComando, con);

            comando.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable table = new DataTable();

            data.Fill(table);

            con.Close();

            return table;









        }



        //precio


        public void seleccionarPrecio(ComboBox combo)
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
            combo.Items.Insert(0, "-selecionar numero de habitacion-");
            combo.SelectedIndex = 0;


        }

        public string[] captar_datosPrecio(int precio)
        {
            con.Open();

            comando = new SqlCommand($"select *from habitaciones where Numero={precio}", con);
            SqlDataReader dat = comando.ExecuteReader();

            string[] resultado = null;
            while (dat.Read())
            {


                string[] valores =
                {

                    dat[3].ToString(),
                   
                  



                };

                resultado = valores;

            }

            con.Close();

            return resultado;

        }

















    }
}
