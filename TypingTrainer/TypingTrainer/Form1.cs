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
            this.BackColor = Color.FromArgb(105,065,140);
            button1.BackColor = Color.FromArgb(125, 153, 163);
            button1.UseVisualStyleBackColor = false;
            button1.FlatStyle = FlatStyle.Flat;
            button2.UseVisualStyleBackColor = false;
            button2.FlatAppearance.BorderSize = 0;
            button2.BackColor = Color.FromArgb(125, 153, 163);
            button2.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            label1.ForeColor = Color.FromArgb(125, 153, 163);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
