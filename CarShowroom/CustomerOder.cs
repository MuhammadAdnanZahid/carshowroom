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
    public partial class CustomerOder : Form
    {
        public CustomerOder()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm if you want to exit", "Vechile Managment System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            int num;
            Random rnd = new Random();
            num = rnd.Next(4238, 34238);
            num = 1325 + num;
            String refs = Convert.ToString(num);

            //==================================================================

            rtbReceipt.AppendText("\tCAR SHOWROOM MANAGMENT SYSTEM:\n\n"
                + "Ref:\t\t\t\t" + refs
                + "\n--------------------------------------------------------------"
                + "\nName:\t\t\t" + txtFirstname.Text
                + "\nLastname:\t\t" + txtLastname.Text
                + "\nAddress:\t\t\t" + txtAddress.Text
                + "\nPostcode:\t\t" + txtPostcode.Text
                + "\nContact:\t\t\t" + txtContact.Text
                + "\n---------------------------------------------------------------"
                + "\nTax:\t\t\t" + lblTax.Text
                + "\nSub Total:\t\t" + lblSubtotal.Text
                + "\nTotal:\t\t\t" + lblTotal.Text
                + "\n---------------------------------------------------------------"
                + "\n\n\n\tThanks for using \n\tCAR SHOWROOM MANAGMENT SYSTEM"
                + "\n\n\t\t\tCreated by RAZ"
                );
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            this.Hide();
            Car_Showroom showroom = new Car_Showroom();
            showroom.Show();
        }
    }
}
