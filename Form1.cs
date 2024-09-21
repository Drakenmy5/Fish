using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;




namespace Login
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30  ");

        SqlCommand cmd = new SqlCommand();

        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (txt_Username.Text == "" || txt_Password.Text == "")
                {
                    MessageBox.Show("Yor are Loggin Detail Is Invalied", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    con.Open();

                    cmd = con.CreateCommand();

                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "Select * From db_admin Where adminname = '" + txt_Username.Text + "' and adminpassword = '" + txt_Password.Text + "'";

                    cmd.ExecuteNonQuery();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        this.Hide();
                        Dashboard fh = new Dashboard();

                    }
                    else
                    {
                        MessageBox.Show("You're Loggin Detail Is Invalied", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    con.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_User.Focus();
            lblAdmin.Visible = false;
            lbl_btnUser.Visible = false;
            butto1.Visible = false;


        }

        private void label4_Click(object sender, EventArgs e)
        {
            lblAdmin.Visible = false;
            lbl_btnUser.Visible = false;
            butto1.Visible = false;
            lbl_adminlogin.Visible = true;
        }

        private void lbl_btnLogin_Click(object sender, EventArgs e)
        {
            lblAdmin.Visible = true;
            lbl_btnUser.Visible = true;
            butto1.Visible = true;
            lbl_adminlogin.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_Username.Text == "admin" || txt_Password.Text == "admin")
                {
                    this.Hide();
                    Dashboard fh = new Dashboard();
                    fh.ShowDialog();

                }
                else
                {
                    MessageBox.Show("You're Loggin Detail Is Invalied", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_Password.UseSystemPasswordChar = true;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_Password.Text = "";
            txt_Username.Text = "";

        }
    }
}
