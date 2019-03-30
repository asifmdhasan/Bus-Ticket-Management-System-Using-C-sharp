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
    public partial class Sit_Plan : Form
    {
        public Sit_Plan()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           // MessageBox.Show("total cost \n500");
        }
       // private void Cost()
     //   {
           
       // }

        private void Cost(object sender, EventArgs e)
        {
            MessageBox.Show("total cost \n500");
            this.Hide();
            Personal_Information r = new Personal_Information();
            r.ShowDialog();
        }
    }
}
