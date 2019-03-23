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
        static int ponter_X = 15;
        static int ponter_Y = 50;
        public Menu()
        {
            InitializeComponent();
            if (Autorization.ActiveUser < 2) tsmEdit.Visible = false;
            if (Autorization.ActiveUser < 2) tsmRestore.Visible = false;
            /*Подключение к базе: */
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"DESKTOP-G50ABLH\SQLEXPRESS1";
            builder.IntegratedSecurity = true;
            builder.InitialCatalog = "newind";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            /**************/
        }


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
            
            ViewUchenik v = new ViewUchenik();
            this.Controls.Add(v);
            v.Location = new Point(ponter_X, ponter_Y);
            v.Visible = true;
            ponter_X += 300;
            if(ponter_X>400)
            {
                ponter_X = 0;
                ponter_Y += 250;
            }
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
    }
    
}
