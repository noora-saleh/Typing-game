namespace TypingTrainer
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timeLbl = new System.Windows.Forms.Label();
            this.counterLbl = new System.Windows.Forms.Label();
            this.wordLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.finishBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.skipBtn = new System.Windows.Forms.Button();
            this.nextWordBtn = new System.Windows.Forms.Label();
            this.accuracyBtn = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.Location = new System.Drawing.Point(49, 47);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(74, 27);
            this.timeLbl.TabIndex = 0;
            this.timeLbl.Text = "Time";
            this.timeLbl.Click += new System.EventHandler(this.timeLbl_Click);
            // 
            // counterLbl
            // 
            this.counterLbl.AutoSize = true;
            this.counterLbl.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLbl.Location = new System.Drawing.Point(527, 56);
            this.counterLbl.Name = "counterLbl";
            this.counterLbl.Size = new System.Drawing.Size(112, 27);
            this.counterLbl.TabIndex = 1;
            this.counterLbl.Text = "Counter";
            // 
            // wordLbl
            // 
            this.wordLbl.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordLbl.Location = new System.Drawing.Point(141, 76);
            this.wordLbl.Name = "wordLbl";
            this.wordLbl.Size = new System.Drawing.Size(369, 50);
            this.wordLbl.TabIndex = 2;
            this.wordLbl.Text = "The Word";
            this.wordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(147, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // finishBtn
            // 
            this.finishBtn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishBtn.Location = new System.Drawing.Point(187, 279);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(115, 39);
            this.finishBtn.TabIndex = 4;
            this.finishBtn.Text = "Finish";
            this.finishBtn.UseVisualStyleBackColor = true;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.skipBtn);
            this.panel1.Controls.Add(this.nextWordBtn);
            this.panel1.Controls.Add(this.accuracyBtn);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.counterLbl);
            this.panel1.Controls.Add(this.wordLbl);
            this.panel1.Controls.Add(this.timeLbl);
            this.panel1.Controls.Add(this.finishBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 433);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // skipBtn
            // 
            this.skipBtn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipBtn.Location = new System.Drawing.Point(366, 279);
            this.skipBtn.Name = "skipBtn";
            this.skipBtn.Size = new System.Drawing.Size(115, 39);
            this.skipBtn.TabIndex = 9;
            this.skipBtn.Text = "Skip";
            this.skipBtn.UseVisualStyleBackColor = true;
            this.skipBtn.Click += new System.EventHandler(this.skipBtn_Click);
            // 
            // nextWordBtn
            // 
            this.nextWordBtn.AutoSize = true;
            this.nextWordBtn.Location = new System.Drawing.Point(288, 144);
            this.nextWordBtn.Name = "nextWordBtn";
            this.nextWordBtn.Size = new System.Drawing.Size(71, 17);
            this.nextWordBtn.TabIndex = 8;
            this.nextWordBtn.Text = "next word";
            this.nextWordBtn.Click += new System.EventHandler(this.nextWordBtn_Click);
            // 
            // accuracyBtn
            // 
            this.accuracyBtn.AutoSize = true;
            this.accuracyBtn.Location = new System.Drawing.Point(512, 198);
            this.accuracyBtn.Name = "accuracyBtn";
            this.accuracyBtn.Size = new System.Drawing.Size(64, 17);
            this.accuracyBtn.TabIndex = 7;
            this.accuracyBtn.Text = "accuracy";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(208, 234);
            this.progressBar1.Maximum = 5;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(219, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 433);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Screen";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label counterLbl;
        private System.Windows.Forms.Label wordLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button skipBtn;
        private System.Windows.Forms.Label nextWordBtn;
        private System.Windows.Forms.Label accuracyBtn;
    }
}