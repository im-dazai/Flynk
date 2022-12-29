using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Flynk
{
    public partial class Flynk : Form
    {
        public Flynk()
        {
            InitializeComponent();
        }
        
        private void txtID_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            pictureBox2.BackgroundImage = Properties.Resources.user2;
            panel1.ForeColor = Color.FromArgb(255, 180, 41);
            txtID.ForeColor = Color.FromArgb(255, 180, 41);

            pictureBox3.BackgroundImage = Properties.Resources.pass1;
            panel2.ForeColor = Color.FromArgb(255, 255, 255);
            txtPass.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
            pictureBox3.BackgroundImage = Properties.Resources.pass2;
            panel2.ForeColor = Color.FromArgb(255, 180, 41);
            txtPass.ForeColor = Color.FromArgb(255, 180, 41);

            pictureBox2.BackgroundImage = Properties.Resources.user1;
            panel1.ForeColor = Color.FromArgb(255, 255, 255);
            txtID.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry. The Registration period has ended. ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Flynk frm1 = new Flynk();
            Form2 frm2 = new Form2();
            if (txtID.Text == "test" && txtPass.Text == "test2022")
            {
                this.Hide();
                frm2.Show();
            }
            else
                MessageBox.Show("Wrong Username or Password!");
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            
                
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Link Working! It redirect to a webpage.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
