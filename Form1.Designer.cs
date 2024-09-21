namespace Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            butto1 = new Button();
            button2 = new Button();
            txt_Username = new TextBox();
            txt_Password = new TextBox();
            txt_User = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            lbl_adminlogin = new Label();
            lblAdmin = new Label();
            lbl_btnUser = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // butto1
            // 
            butto1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butto1.Location = new Point(321, 560);
            butto1.Name = "butto1";
            butto1.Size = new Size(116, 56);
            butto1.TabIndex = 0;
            butto1.Text = "LOGIN";
            butto1.UseVisualStyleBackColor = true;
            butto1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(513, 550);
            button2.Name = "button2";
            button2.Size = new Size(140, 66);
            button2.TabIndex = 1;
            button2.Text = "EXIT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(329, 391);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(350, 27);
            txt_Username.TabIndex = 2;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(329, 449);
            txt_Password.Multiline = true;
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(350, 27);
            txt_Password.TabIndex = 10;
            // 
            // txt_User
            // 
            txt_User.AutoSize = true;
            txt_User.BackColor = Color.LightCyan;
            txt_User.Font = new Font("Segoe UI", 10.8F);
            txt_User.Location = new Point(223, 393);
            txt_User.Name = "txt_User";
            txt_User.Size = new Size(100, 25);
            txt_User.TabIndex = 4;
            txt_User.Text = "User name:";
            txt_User.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCyan;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(232, 449);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(287, 4);
            label3.Margin = new Padding(4, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(356, 68);
            label3.TabIndex = 6;
            label3.Text = "WELCOME";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkSlateGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(341, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lbl_adminlogin
            // 
            lbl_adminlogin.AutoSize = true;
            lbl_adminlogin.BackColor = Color.LightCyan;
            lbl_adminlogin.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_adminlogin.Location = new Point(379, 336);
            lbl_adminlogin.Name = "lbl_adminlogin";
            lbl_adminlogin.Size = new Size(174, 32);
            lbl_adminlogin.TabIndex = 9;
            lbl_adminlogin.Text = "Admin Login";
            lbl_adminlogin.Click += lbl_btnLogin_Click;
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.BackColor = Color.LightCyan;
            lblAdmin.Font = new Font("Segoe UI", 10.8F);
            lblAdmin.Location = new Point(205, 393);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(118, 25);
            lblAdmin.TabIndex = 10;
            lblAdmin.Text = "Admin name:";
            // 
            // lbl_btnUser
            // 
            lbl_btnUser.AutoSize = true;
            lbl_btnUser.BackColor = Color.LightCyan;
            lbl_btnUser.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_btnUser.Location = new Point(390, 336);
            lbl_btnUser.Name = "lbl_btnUser";
            lbl_btnUser.Size = new Size(146, 32);
            lbl_btnUser.TabIndex = 11;
            lbl_btnUser.Text = "User Login";
            lbl_btnUser.Click += label4_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(297, 550);
            button1.Name = "button1";
            button1.Size = new Size(140, 66);
            button1.TabIndex = 12;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(329, 482);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(720, 401);
            button3.Name = "button3";
            button3.Size = new Size(125, 55);
            button3.TabIndex = 14;
            button3.Text = "CLEAR TEXT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(961, 663);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(lblAdmin);
            Controls.Add(txt_User);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            Controls.Add(button2);
            Controls.Add(butto1);
            Controls.Add(lbl_btnUser);
            Controls.Add(lbl_adminlogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butto1;
        private Button button2;
        private TextBox txt_Username;
        private TextBox txt_Password;
        private Label txt_User;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label lbl_adminlogin;
        private Label lblAdmin;
        private Label lbl_btnUser;
        private Button button1;
        private CheckBox checkBox1;
        private Button button3;
    }
}
