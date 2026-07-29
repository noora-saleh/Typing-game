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
    public partial class Form4 : Form
    {
        List<string> words;
        int index = 0;
        int correct = 0;
        int wrong = 0;
        int seconds = 0;
        string level;
        List<string> wrongDetails = new List<string>();

        string[] easyWords = { "cat", "dog", "sun", "book", "tree" };
        string[] hardWords = { "accommodation", "rhythm", "consequence", "phenomenon", "metamorphosis" };

        public Form4(string selectedLevel)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 205, 193);
            label1.ForeColor = Color.FromArgb(125, 153, 163);
            label2.ForeColor = Color.FromArgb(125, 153, 163);
            label3.ForeColor = Color.FromArgb(125, 153, 163);
            button1.BackColor = Color.FromArgb(125, 153, 163);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;

            level = selectedLevel;
            PrepareTest();
        }
        void PrepareTest()
        {
            if (level == "Easy")
                words = easyWords.ToList();
            else
                words = hardWords.ToList();

            label3.Text = words[index];
            label2.Text = "1 / " + words.Count;
            timer1.Interval = 1000;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (!timer1.Enabled)
                    timer1.Start();

                if (textBox1.Text.Trim().ToLower() == words[index].ToLower())
                    correct++;
                else
                {
                    wrong++;
                    wrongDetails.Add(words[index] + " -> " + textBox1.Text);
                }
                index++;
                textBox1.Clear();

                if (index < words.Count)
                {
                    label3.Text = words[index];
                    label2.Text = (index + 1) + " / " + words.Count;
                }
                else
                {
                    EndTest();
                }
            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            int min = seconds / 60;
            int sec = seconds % 60;
            label1.Text = min.ToString("00") + ":" + sec.ToString("00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EndTest();
        }
        void EndTest()
        {
            timer1.Stop();
            Form3 result = new Form3(seconds, correct, wrong, wrongDetails);
            result.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
