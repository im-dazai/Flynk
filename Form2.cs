using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flynk
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            result.Hide();
            error.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtRoll.Clear();
            txtRoll.ForeColor = Color.FromArgb(255, 180, 41);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRoll.Text == "1")
            {
                error.Hide();
                result.Show();
                lblName.Text = "Peter Griffin";
                lblGrade.Text = "A+";
                lblMarks.Text = "96";
                lblRemarks.Text = "Good Job!";

            }
            else if (txtRoll.Text == "2")
            {
                error.Hide();
                result.Show();
                lblName.Text = "Louis Griffin";
                lblGrade.Text = "A";
                lblMarks.Text = "84";
                lblRemarks.Text = "Awesome Work!";
            }
            else if (txtRoll.Text == "3")
            {
                error.Hide();
                result.Show();
                lblName.Text = "Stewie Griffin";
                lblGrade.Text = "A+";
                lblMarks.Text = "98";
                lblRemarks.Text = "Fabulous!";
            }
            else if (txtRoll.Text == "4")
            {
                error.Hide();
                result.Show();
                lblName.Text = "Bryan Griffin";
                lblGrade.Text = "A";
                lblMarks.Text = "88";
                lblRemarks.Text = "Amazing Work!";
            }
            else if (txtRoll.Text == "5")
            {
                error.Hide();
                result.Show();
                lblName.Text = "Meg Griffin";
                lblGrade.Text = "D";
                lblMarks.Text = "47";
                lblRemarks.Text = "Not bad!";
            }
            else if (txtRoll.Text == "6")
            {
                error.Hide();
                result.Show();
                lblName.Text = "Chris Griffin";
                lblGrade.Text = "C";
                lblMarks.Text = "68";
                lblRemarks.Text = "Great job!";
            }
            else if (txtRoll.Text == "7")
            {
                error.Hide();
                result.Show();
                lblName.Text = "Glenn Quagmire";
                lblGrade.Text = "B+";
                lblMarks.Text = "75";
                lblRemarks.Text = "Suberb!";
            }
            else if (txtRoll.Text == "8")
            {
                error.Hide();
                result.Show();
                lblName.Text = "Joe Swanson";
                lblGrade.Text = "C+";
                lblMarks.Text = "69";
                lblRemarks.Text = "Awesome!";
            }
            else if (txtRoll.Text == "9")
            {
                error.Hide();
                result.Show();
                lblName.Text = "Cleveland Brown";
                lblGrade.Text = "B";
                lblMarks.Text = "79";
                lblRemarks.Text = "Good Job!";
            }
            else if (txtRoll.Text == "10")
            {
                error.Hide();
                result.Show();
                lblName.Text = "Herbert";
                lblGrade.Text = "C";
                lblMarks.Text = "58";
                lblRemarks.Text = "Not bad!";
            }
            else if (txtRoll.Text == "11")
            {
                error.Hide();
                result.Show();
                lblName.Text = "Elmer Hartman";
                lblGrade.Text = "B+";
                lblMarks.Text = "86";
                lblRemarks.Text = "Great job!";
            }
            else if (txtRoll.Text == "12")
            {
                error.Hide();
                result.Show();
                lblName.Text = "Jimmy O. Yang";
                lblGrade.Text = "C";
                lblMarks.Text = "53";
                lblRemarks.Text = "Excellent!";
            }
            else
                error.Show();

        }

        private void txtRoll_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.Show();
            
        }
    }
}
