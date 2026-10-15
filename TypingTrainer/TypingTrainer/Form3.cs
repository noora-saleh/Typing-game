using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingTrainer
{
    public partial class Form3 : Form
    {

        public Form3(int seconds,int correct,int wrong,List<string> wrongDetails)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 205, 193);
            label1.ForeColor = Color.FromArgb(125, 153, 163);
            label2.ForeColor = Color.FromArgb(125, 153, 163);
            label3.ForeColor = Color.FromArgb(125, 153, 163);

            button2.BackColor = Color.FromArgb(125, 153, 163);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;


            int min = seconds / 60;
            int sec = seconds % 60;
            label1.Text = "time :" + min.ToString("00") + ":" + sec.ToString("00");
            label2.Text = "correct:" + correct;
            label3.Text = "wrong:" + wrong;
            foreach(string item in wrongDetails)
            {
                listBox1.Items.Add(item);
            }
          }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 start = new Form1();
            start.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
