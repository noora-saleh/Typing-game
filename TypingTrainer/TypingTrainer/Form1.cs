using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingTrainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 205, 193);
            //Easy button
            button1.BackColor = Color.FromArgb(125, 153, 163);
           
            //Hard button
            button2.BackColor = Color.FromArgb(125, 153, 163);
            

            label1.ForeColor = Color.FromArgb(125, 153, 163);

            //ألوان زر الخروج
            btnExit.BackColor = Color.FromArgb(125, 153, 163);
            btnExit.ForeColor = Color.White; 


            //ألوان زر About
            btnAbout.BackColor = Color.FromArgb(125, 153, 163);
            btnAbout.ForeColor = Color.White;

            lblInstruction.ForeColor = Color.FromArgb(125, 153, 163);

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 test = new Form4("Easy");
            test.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 test = new Form4("Hard");
            test.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            string message = "A challenge to type words quickly. Developed as part of the Advanced Applications Programming course requirements " ;

            MessageBox.Show(message, "حول البرنامج (About)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblInstruction_Click(object sender, EventArgs e)
        {

        }

  



    }
}
