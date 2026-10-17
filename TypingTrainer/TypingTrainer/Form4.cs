using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TypingTrainer
{
    public partial class Form4 : Form
    {
        List<string> words;
        int index = 0;
        int correct = 0;
        int wrong = 0;
        int remainingSeconds = 60;
        string level;
        List<string> wrongDetails = new List<string>();

        string[] easyWords = { "cat", "dog", "sun", "book", "tree" };
        string[] hardWords = { "accommodation", "rhythm", "consequence", "phenomenon", "metamorphosis" };

        public Form4(string selectedLevel)
        {
            InitializeComponent();
            level = selectedLevel;
            this.Text = "Typing Test - " + level;
            this.BackColor = Color.FromArgb(255, 205, 193);

            timeLbl.Font = new Font("Tahoma", 12, FontStyle.Bold);
            timeLbl.ForeColor = Color.FromArgb(60, 60, 60);

            counterLbl.Font = new Font("Tahoma", 12, FontStyle.Bold);
            counterLbl.ForeColor = Color.FromArgb(60, 60, 60);

            wordLbl.Font = new Font("Tahoma", 24, FontStyle.Bold);
            wordLbl.ForeColor = Color.FromArgb(60, 60, 60);
            wordLbl.TextAlign = ContentAlignment.MiddleCenter;

            nextWordBtn.Font = new Font("Tahoma", 10);
            nextWordBtn.ForeColor = Color.Gray;

            accuracyBtn.Font = new Font("Tahoma", 10, FontStyle.Bold);
            accuracyBtn.ForeColor = Color.FromArgb(60, 60, 60);

            textBox1.Font = new Font("Tahoma", 14);
            textBox1.TextAlign = HorizontalAlignment.Center;

            skipBtn.Font = new Font("Tahoma", 11, FontStyle.Bold);
            skipBtn.BackColor = Color.FromArgb(125, 153, 163);
            skipBtn.ForeColor = Color.White;
            skipBtn.FlatStyle = FlatStyle.Flat;
            skipBtn.FlatAppearance.BorderSize = 0;

            finishBtn.Font = new Font("Tahoma", 11, FontStyle.Bold);
            finishBtn.BackColor = Color.FromArgb(125, 153, 163);
            finishBtn.ForeColor = Color.White;
            finishBtn.FlatStyle = FlatStyle.Flat;
            finishBtn.FlatAppearance.BorderSize = 0;

            PrepareTest();
        }

        void PrepareTest()
        {
            if (level == "Easy")
            {
                words = easyWords.ToList();
                remainingSeconds = 30;
            }
            else
            {
                words = hardWords.ToList();
                remainingSeconds = 60;
            }

            Random rnd = new Random();
            words = words.OrderBy(x => rnd.Next()).ToList();

            index = 0;
            correct = 0;
            wrong = 0;

            if (level == "Easy")
                timeLbl.Text = "Time: 00:30";
            else
                timeLbl.Text = "Time: 01:00";

            counterLbl.Text = "1 / " + words.Count;
            wordLbl.Text = words[index];
            accuracyBtn.Text = "Accuracy: 0%";

            if (words.Count > 1)
                nextWordBtn.Text = "Next: " + words[1];
            else
                nextWordBtn.Text = "Next: ---";

            progressBar1.Maximum = words.Count;
            progressBar1.Value = 0;

            timer1.Interval = 1000;
        }

        void MoveToNextWord()
        {
            index++;
            textBox1.Clear();
            textBox1.BackColor = Color.White;
            progressBar1.Value = index;

            if (index < words.Count)
            {
                wordLbl.Text = words[index];
                counterLbl.Text = (index + 1) + " / " + words.Count;

                if (index + 1 < words.Count)
                    nextWordBtn.Text = "Next: " + words[index + 1];
                else
                    nextWordBtn.Text = "Next: ---";
            }
            else
            {
                EndTest();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (textBox1.Text.Trim() == "")
                    return;

                if (textBox1.Text.Trim().ToLower() == words[index].ToLower())
                {
                    correct++;
                    textBox1.BackColor = Color.LightGreen;
                }
                else
                {
                    wrong++;
                    wrongDetails.Add(words[index] + " -> " + textBox1.Text);
                    textBox1.BackColor = Color.LightCoral;
                }

                int total = correct + wrong;
                if (total > 0)
                    accuracyBtn.Text = "Accuracy: " + (correct * 100 / total) + "%";

                MoveToNextWord();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingSeconds--;
            int min = remainingSeconds / 60;
            int sec = remainingSeconds % 60;
            timeLbl.Text = "Time: " + min.ToString("00") + ":" + sec.ToString("00");

            if (remainingSeconds <= 0)
            {
                timer1.Stop();
                EndTest();
            }
        }

        private void skipBtn_Click(object sender, EventArgs e)
        {
            wrong++;
            wrongDetails.Add(words[index] + " -> (Skipped)");

            int total = correct + wrong;
            if (total > 0)
                accuracyBtn.Text = "Accuracy: " + (correct * 100 / total) + "%";

            MoveToNextWord();
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            EndTest();
        }

        void EndTest()
        {
            timer1.Stop();
            
            int totalTime = (level == "Easy") ? 30 : 60;
            int timeTaken = totalTime - remainingSeconds;
            
            Form3 result = new Form3(timeTaken, correct, wrong, wrongDetails);
            result.Show();
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            timer1.Start();
        }

        private void timeLbl_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void nextWordBtn_Click(object sender, EventArgs e) { }
    }
}