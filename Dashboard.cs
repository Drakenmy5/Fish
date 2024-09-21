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

namespace Login
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public void Loadform(object Form)
        {
            if (this.paneln.Controls.Count > 0)
                this.paneln.Controls.RemoveAt(0);
            Form f = (Form)Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.paneln.Controls.Add(f);
            this.paneln.Tag = f;
            f.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Loadform(new Dashboar());
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Loadform(new Cashflow());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Loadform(new Aproduct());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Loadform(new Members());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Loadform(new Inventory());
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
