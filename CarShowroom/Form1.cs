using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CarShowroom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textbox1.Text="";
            textbox_password.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=xe;User ID=system;Password =  adnan");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from projectlogin where UserName='" + textbox1.Text + "' and Password '" + textbox_password.Text + "'", con);
            OleDbDataAdapter d = new OleDbDataAdapter(cmd);
            String UserName, Password;
            UserName = textbox1.Text;
            Password = textbox_password.Text;  

            if(UserName == "system"  && Password == "adnan")
            {
                this.Hide();
                Car_Showroom showroom = new Car_Showroom();
                showroom.Show();
                
                
            }
            else
            {
                MessageBox.Show("Invalid UserName OR Passeord.......!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit The Application","Car Showroom Management System", MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if(iExit ==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_show_CheckedChanged(object sender, EventArgs e)
        {
            
            

            
        }

        private void textbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
