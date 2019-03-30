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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Time", typeof(string));
            table.Columns.Add("Id", typeof(string));

            dataGridView1.DataSource = table;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Time", typeof(string));
            table.Columns.Add("Id", typeof(string));

            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
            dataGridView1.DataSource = table;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
           // MessageBox.Show("Welcome");
            SourceDestination r = new SourceDestination();
            r.ShowDialog();
        }
    }
}
