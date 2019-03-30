using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = textBox1.Text;
            pass = textBox2.Text;
            if(user=="Asif" && pass=="0000"){
                this.Hide();
                MessageBox.Show("Welcome Admin");
                Admin r = new Admin();
                r.ShowDialog();
            }
            else
            {
                this.Hide();
                MessageBox.Show("Welcome To Our Bus Service");
                Reservation r = new Reservation();
                r.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration rr = new Registration();
            rr.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
