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
    public partial class Form7 : Form
    {
        Habitaciones habi = new Habitaciones();
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            BuscarHabi();

        }

        public void BuscarHabi()
        {
            

            string combo = comboBox1.Text;

            dataGridView1.DataSource = habi.BuscarHabi(combo);




        }
    }
}
