using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colledge
{
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
            if (Autorization.ActiveUser < 2) tsmEdit.Visible = false;
            if (Autorization.ActiveUser < 2) tsmRestore.Visible = false;
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
            tsmAddSpecialnost tsmAddSpec = new tsmAddSpecialnost();
            tsmAddSpec.Show();
        }

        private void addToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            tsmAddFaqultet tsmAddFaq = new tsmAddFaqultet();
            tsmAddFaq.Show();
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

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
