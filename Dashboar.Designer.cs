namespace Login
{
    partial class Dashboar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboar));
            Print = new Label();
            pictureBox5 = new PictureBox();
            textBox1 = new TextBox();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Print
            // 
            Print.AutoSize = true;
            Print.Location = new Point(1540, 106);
            Print.Name = "Print";
            Print.Size = new Size(39, 40);
            Print.TabIndex = 9;
            Print.Text = "Print\r\n\r\n";
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = Properties.Resources.print;
            pictureBox5.Location = new Point(1509, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(105, 91);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.Hand;
            textBox1.Location = new Point(166, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 27);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 19);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 11;
            label5.Text = "Search Here:";
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources._132341_dollar_financial_finance_banking_money_icon;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(108, 270);
            button2.Name = "button2";
            button2.Size = new Size(259, 64);
            button2.TabIndex = 12;
            button2.Text = "SALES";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Image = Properties.Resources._132209_bar_chart_icon;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(690, 270);
            button3.Name = "button3";
            button3.Size = new Size(259, 64);
            button3.TabIndex = 13;
            button3.Text = "PRODUCTION";
            button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(1279, 270);
            button6.Name = "button6";
            button6.Size = new Size(259, 64);
            button6.TabIndex = 14;
            button6.Text = "INVENTORY";
            button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 340);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(542, 761);
            dataGridView1.TabIndex = 15;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(564, 340);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(542, 761);
            dataGridView2.TabIndex = 16;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(1133, 340);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(542, 761);
            dataGridView3.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._132289_search_icon;
            pictureBox1.Location = new Point(439, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Dashboar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1706, 1102);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(Print);
            Controls.Add(pictureBox5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboar";
            Text = "Dashboar";
            WindowState = FormWindowState.Maximized;
            Load += Dashboar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Print;
        private PictureBox pictureBox5;
        private TextBox textBox1;
        private Label label5;
        private Button button2;
        private Button button3;
        private Button button6;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private PictureBox pictureBox1;
    }
}