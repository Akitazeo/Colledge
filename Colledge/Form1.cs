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
    
    public partial class Autorization : Form
    {
        public Autorization(int ActiveUser)
        {
            
            InitializeComponent();
            panel2.BackColor = Color.FromArgb(120, 253, 253, 196);
           


        }

        public static int ActiveUser=0;
        private int score=3;

        private void btnAutorization_Click(object sender, EventArgs e)
        {
            if ((tbPassword.Text=="Admin") && (tbLogin.Text=="Admin"))
            {
                ActiveUser = 2;
            

                this.Dispose();

            }
            else
            if ((tbPassword.Text == "User") && (tbLogin.Text == "User"))
            {
                ActiveUser = 1;

                this.Dispose();
            }
            else
            {
                tbPassword.Text = "";
                tbLogin.Text = "";
                score--;
                MessageBox.Show("Неверная комбинация Логин/Пароль. Попробуйте ещё раз.");
                if (score < 1) Application.Exit();
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnAutorization_Click(sender, e);
        }



        private void tbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnAutorization_Click(sender, e);

        }

        private void Autorization_Load(object sender, EventArgs e)
        {
            tbPassword.Focus();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

    }
}
