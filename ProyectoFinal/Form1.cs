using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace ProyectoFinal
{
    public partial class Hospital : Form
    {
        private IconButton CurrentBtn;
        private Panel LeftBorderBtn;
        private Form CurrentchildForm;

        public IconButton CurrentBtn1 { get => CurrentBtn; set => CurrentBtn = value; }
        public Panel LeftBorderBtn1 { get => LeftBorderBtn; set => LeftBorderBtn = value; }
        public Form CurrentchildForm1 { get => CurrentchildForm; set => CurrentchildForm = value; }

        public Hospital()
        {
            InitializeComponent();
            LeftBorderBtn1 = new Panel();
            LeftBorderBtn1.Size = new Size(7, 60);
            panelMenu.Controls.Add(LeftBorderBtn1);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        #region colores y activar Botones

        private struct RGBColors
        {

            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(243, 138, 114);





        }



        private void ActivateButtom(object senderBtn, Color color)
        {


            if (senderBtn != null)
            {
                DisableButton();
                CurrentBtn1 = (IconButton)senderBtn;
                CurrentBtn1.BackColor = Color.FromArgb(37, 36, 81);
                CurrentBtn1.ForeColor = color;
                CurrentBtn1.TextAlign = ContentAlignment.MiddleCenter;
                CurrentBtn1.IconColor = color;
                CurrentBtn1.TextImageRelation = TextImageRelation.TextBeforeImage;
                CurrentBtn1.ImageAlign = ContentAlignment.MiddleRight;

                //left border

                LeftBorderBtn1.BackColor = color;
                LeftBorderBtn1.Location = new Point(0, CurrentBtn1.Location.Y);
                LeftBorderBtn1.Visible = true;
                LeftBorderBtn1.BringToFront();

                //ico home
                IcoCharCurrentChild.IconChar = CurrentBtn1.IconChar;
                IcoCharCurrentChild.IconColor = color;


            }


        }

        private void DisableButton()
        {

            if (CurrentBtn1 != null)
            {

                CurrentBtn1.BackColor = Color.FromArgb(31, 30, 68);
                CurrentBtn1.ForeColor = Color.LightGoldenrodYellow;
                CurrentBtn1.TextAlign = ContentAlignment.MiddleLeft;
                CurrentBtn1.IconColor = Color.LightGoldenrodYellow;
                CurrentBtn1.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentBtn1.ImageAlign = ContentAlignment.MiddleLeft;




            }




        }
        #endregion

        #region abrir form 
        private void OpenChildForm(Form childFrom)
        {

            if (CurrentchildForm1 != null)
            {

                //Open Form
                CurrentchildForm1.Close();
            }
            CurrentchildForm1 = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            panelDescktop.Controls.Add(childFrom);
            panelDescktop.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
            TLFCHILD.Text = childFrom.Text;


        }
        #endregion

        #region Botones
        private void BtnManteni_Click(object sender, EventArgs e)
        {

            ShowSubMenu(panelManteni);
            ActivateButtom(sender, RGBColors.color1);
            TLFCHILD.Text = BtnManteni.Text;

        }

        private void BtnProces_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PanelProceso);
            ActivateButtom(sender, RGBColors.color2);
            TLFCHILD.Text = BtnProces.Text;

        }

        private void BtnConsul_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelConsulta);
            ActivateButtom(sender, RGBColors.color3);
            TLFCHILD.Text = BtnConsul.Text;

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HidMenu();

         
            
            Reset();
            


        }
        #endregion

        #region MetodoReset, horas, fecha,hide y show menu
        private void Reset()
        {

            DisableButton();
            LeftBorderBtn1.Visible = false;
            IcoCharCurrentChild.IconChar = IconChar.Home;
            IcoCharCurrentChild.IconColor = Color.MediumVioletRed;
            TLFCHILD.Text = "Home";


            
         






        }

      
     



        private void TimerHora_Tick(object sender, EventArgs e)
        {

            LBHORA.Text = DateTime.Now.ToLongTimeString();
            LBFECHA.Text = DateTime.Now.ToLongDateString();



        }


        private void HidMenu()
        {
            if (panelManteni.Visible == true)
                panelManteni.Visible = false;

            if (panelConsulta.Visible == true)
                panelConsulta.Visible = false;

            if (PanelProceso.Visible == true)
                PanelProceso.Visible = false;



        }

        private void ShowSubMenu(Panel ShowSubMe)
        {

            if (ShowSubMe.Visible == false)
            {
                HidMenu();
                ShowSubMe.Visible = true;
            }
            else
            {
                ShowSubMe.Visible = false;
            }
        }

        #endregion

        #region Submenu Mantenimiento
        private void btnPaciente_Click(object sender, EventArgs e)
        {
         

          OpenChildForm(new Form3());

            HidMenu();


        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
           

            OpenChildForm(new Form2());
           
            HidMenu();
        }

        private void BtnHabi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form4());
            HidMenu();
        }
        #endregion

        #region Submenu Consulta
        private void BtnConPacie_Click(object sender, EventArgs e)
        {
            HidMenu();
           

            OpenChildForm(new Form5());
        }

        private void BtnConMedic_Click(object sender, EventArgs e)
        {
            HidMenu();
            OpenChildForm(new Form6());
           
            
        }

        private void btnConHabi_Click(object sender, EventArgs e)
        {
            HidMenu();

            OpenChildForm(new Form7());
        }

        private void btnConCita_Click(object sender, EventArgs e)
        {
            HidMenu();
            OpenChildForm(new Form8());
        }

        private void btnConIngreso_Click(object sender, EventArgs e)
        {
            HidMenu();
            OpenChildForm(new Form9());
        }

        private void BtnConAlt_Click(object sender, EventArgs e)
        {
            HidMenu();
            OpenChildForm(new Form10());
        }
        #endregion

        #region Submenu Proceso
        private void BtnCitaPro_Click(object sender, EventArgs e)
        {
            HidMenu();
            OpenChildForm(new Form11());
        }

        private void BtnInterpro_Click(object sender, EventArgs e)
        {
            HidMenu();
            OpenChildForm(new Form12());
        }

        private void BtnAltaPro_Click(object sender, EventArgs e)
        {
            HidMenu();
            OpenChildForm(new Form13());
        }
        #endregion

        private void iconButton1_Click(object sender, EventArgs e)
        {
      
            Application.Exit();
        
        }

        private void BtnReproducir_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=VSu6Tf1sGG8");
        }
    }
}

