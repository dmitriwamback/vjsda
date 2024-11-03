namespace vjsda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(41, 45, 62);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(12, 368);
            button1.Name = "button1";
            button1.Size = new Size(129, 50);
            button1.TabIndex = 0;
            button1.Text = "EXECUTE";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(41, 45, 62);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(147, 368);
            button2.Name = "button2";
            button2.Size = new Size(129, 50);
            button2.TabIndex = 1;
            button2.Text = "INJECT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(41, 45, 62);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(788, 362);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(41, 45, 62);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(737, 368);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 3;
            button3.Text = "TP";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(41, 45, 62);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(604, 368);
            button4.Name = "button4";
            button4.Size = new Size(127, 50);
            button4.TabIndex = 4;
            button4.Text = "SUPER SPEED";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(41, 45, 62);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(471, 368);
            button5.Name = "button5";
            button5.Size = new Size(127, 50);
            button5.TabIndex = 5;
            button5.Text = "SUPER JUMP";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 21, 33);
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        public RichTextBox richTextBox1;
        private Button button4;
        private Button button5;
    }
}
