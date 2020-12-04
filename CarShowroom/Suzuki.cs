using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShowroom
{
    public partial class Suzuki : Form
    {
        public Suzuki()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CustomerOder().Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CustomerOder().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CustomerOder().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new CustomerOder().Show();
            this.Hide();
        }
    }
}
