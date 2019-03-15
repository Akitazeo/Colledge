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
        private int vuchenik = 0;
        private int vjurnal = 0;
        private int vuchitel = 0;
        private int vgroup = 0;
        private int vpred = 0;
        private int vspecfac = 0;

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



        private void grUcenicBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.grUcenicBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student);

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.uchitelTableAdapter.Fill(this.student.Uchitel);
            this.uchenikTableAdapter.Fill(this.student.Uchenik);
            this.specFacTableAdapter.Fill(this.student.SpecFac);
            this.grUcenicTableAdapter.Fill(this.student.GrUcenic);
            this.uchitelTableAdapter.Fill(this.student.Uchitel);
            this.jurnalTableAdapter.Fill(this.student.Jurnal);

        }

        private void факультетToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (vgroup % 2 != 0)
                grUcenicDataGridView.Visible = false;
            else grUcenicDataGridView.Visible = true;
            vgroup++;
        }

        private void журналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vjurnal % 2 != 0)
                jurnalDataGridView.Visible = false;
            else jurnalDataGridView.Visible = true;
            vjurnal++;
        }

        private void tsmПредмет_Click(object sender, EventArgs e)
        {
            if (vpred % 2 != 0)
                predmetDataGridView.Visible = false;
            else predmetDataGridView.Visible = true;
            vpred++;
        }

        private void ученикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vuchenik % 2 != 0)
                uchenikDataGridView.Visible = false;
           else uchenikDataGridView.Visible = true;
            vuchenik++;
        }

        private void учительToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vuchitel % 2 != 0)
                uchitelDataGridView.Visible = false;
           else uchitelDataGridView.Visible = true;
            vuchitel++;
        }

        private void спецФакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(vspecfac%2!=0)
                specFacDataGridView.Visible = false;
            else specFacDataGridView.Visible = true;
            vspecfac++;
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
    }
}
