namespace Login
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            paneln = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            paneln.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 830);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button6
            // 
            button6.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 592);
            button6.Name = "button6";
            button6.Size = new Size(259, 62);
            button6.TabIndex = 5;
            button6.Text = "INVENTORY";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 503);
            button5.Name = "button5";
            button5.Size = new Size(259, 64);
            button5.TabIndex = 4;
            button5.Text = "FISHERMAN";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ma_ni;
            pictureBox1.Location = new Point(67, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Font = new Font("Elephant", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Image = Properties.Resources.dor;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(85, 822);
            button4.Name = "button4";
            button4.Size = new Size(96, 55);
            button4.TabIndex = 2;
            button4.Text = "EXIT";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Image = Properties.Resources._132209_bar_chart_icon;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 412);
            button3.Name = "button3";
            button3.Size = new Size(259, 64);
            button3.TabIndex = 1;
            button3.Text = "PRODUCTION";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources._132341_dollar_financial_finance_banking_money_icon;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 319);
            button2.Name = "button2";
            button2.Size = new Size(259, 64);
            button2.TabIndex = 1;
            button2.Text = "SALES";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources._132252_computer_icon;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 228);
            button1.Name = "button1";
            button1.Size = new Size(259, 64);
            button1.TabIndex = 0;
            button1.Text = "DASHBOARD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // paneln
            // 
            paneln.Controls.Add(pictureBox2);
            paneln.Dock = DockStyle.Fill;
            paneln.Location = new Point(259, 0);
            paneln.Name = "paneln";
            paneln.Size = new Size(959, 830);
            paneln.TabIndex = 2;
            paneln.Paint += panel2_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.Titil;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(959, 830);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1218, 830);
            Controls.Add(paneln);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            paneln.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
        private PictureBox pictureBox1;
        private Button button5;
        private Panel paneln;
        private Button button6;
        public PictureBox pictureBox2;
    }
}