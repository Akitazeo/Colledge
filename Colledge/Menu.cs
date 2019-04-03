using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Colledge
{
    public partial class Menu : Form
    {
        
        //public string builder = @"Data Source=DESKTOP-G50ABLH\SQLEXPRESS1;Initial Catalog=newind;Integrated Security=True";
        //public SqlConnection connection = null;
        //public static SqlCommand command = new SqlCommand();
        public static int buttonCounter = 0;
        public static int ponter_X = 220;
        public static int ponter_Y = 115;
        public Menu()
        {
            InitializeComponent();

            /*Подключение к базе: */
            //connection = new SqlConnection(builder);
            /**************/
        }

        public int Ponter_X { get { return ponter_X; } set { ponter_X = value; } }
        public int Ponter_Y { get { return ponter_Y; } set { ponter_Y = value; } }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tsmJurnalAdd tsmJAdd = new tsmJurnalAdd();
            tsmJAdd.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsmUchenikAdd tsmUchAdd = new tsmUchenikAdd();
            tsmUchAdd.Show();
            
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tsmAddUchitel tsmAddUch = new tsmAddUchitel();
            tsmAddUch.Show();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            tsmAddGrUch tsmAddSpec = new tsmAddGrUch();
            tsmAddSpec.Show();
        }



        private void addToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            tsmAddPredmet tsmPred = new tsmAddPredmet();
            tsmPred.Show();
        }

        private void addToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            tsmAddSpecFaq tsmSpecFaq = new tsmAddSpecFaq();
            tsmSpecFaq.Show();
        }


        private void addToolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            tsmAddSpecFaq tsmsf = new tsmAddSpecFaq();
            tsmsf.ShowDialog();
        }

        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            GrUchDelete GUD = new GrUchDelete();
            GUD.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UchenikEdit UE = new UchenikEdit();
            UE.ShowDialog();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UchitelDelete UD = new UchitelDelete();
            UD.ShowDialog();
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UchitelEdit UCED = new UchitelEdit();
            UCED.ShowDialog();
        }

        private void deleteToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            PredmetDelete PredDel = new PredmetDelete();
            PredDel.ShowDialog();
        }

        private void deleteToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SpetFacDelete SFD = new SpetFacDelete();
            SFD.ShowDialog();
        }

        private void ученикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void средняяОценкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ViewUchOcenka v = new ViewUchOcenka();
            this.Controls.Add(v);
            v.Location = new Point(ponter_X, ponter_Y);
            v.Visible = true;
            ponter_X += 300;
            if (ponter_X > 400)
            {
                ponter_X = 0;
                ponter_Y += 250;
            }
        }

        private void информацияПоУченикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUchenik v = new ViewUchenik();
            this.Controls.Add(v);
            v.Location = new Point(ponter_X, ponter_Y);
            v.Visible = true;
            ponter_X += 300;
            if (ponter_X > 1200)
            {
                ponter_X = 220;
                ponter_Y += 250;
            }
        }




        private void mainBtnUchenik_Click(object sender, EventArgs e)
        {
            mainBtnUchenik.BackgroundImage = new Bitmap(Properties.Resources.mainBtnUch);
            label1.Visible = false;
            buttonCounter = 1;
            if (Autorization.ActiveUser > 0)
                {
                    mainAdd.Visible = true;
                    mainBtnDelete.Visible = true;
                    mainBtnEdit.Visible = true;
                    mainBtnView.Visible = true;
                mainBtnBackUp.Visible = true;
                }
        }

        private void mainBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainBtnSwitch_Click(object sender, EventArgs e)
        {


        }



        private void mainBtnUchenik_MouseEnter(object sender, EventArgs e)
        {
            mainBtnUchenik.BackgroundImage = new Bitmap(Properties.Resources.mainBtnUch);
        }

        private void mainBtnUchenik_MouseLeave(object sender, EventArgs e)
        {
            if(buttonCounter!=1)
            mainBtnUchenik.BackgroundImage = new Bitmap(Properties.Resources.mainBtnUchBrightness);
        }

        private void mainBtnUchitel_Click(object sender, EventArgs e)
        {
            mainBtnUchitel.BackgroundImage = new Bitmap(Properties.Resources.MainBtnUchitel);
            buttonCounter = 2;
            if (Autorization.ActiveUser > 0)
            {
                mainAdd.Visible = true;
                mainBtnDelete.Visible = true;
                mainBtnEdit.Visible = true;
                mainBtnView.Visible = true;
                mainBtnBackUp.Visible = true;
            }
        }

        private void mainBtnUchitel_MouseEnter(object sender, EventArgs e)
        {
            mainBtnUchitel.BackgroundImage = new Bitmap(Properties.Resources.MainBtnUchitel);
        }

        private void mainBtnUchitel_MouseLeave(object sender, EventArgs e)
        {
            if (buttonCounter != 2)
                mainBtnUchitel.BackgroundImage = new Bitmap(Properties.Resources.MainBtnUchitelBrightness);
        }
    }
    
}
