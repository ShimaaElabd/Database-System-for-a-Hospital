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
using System.Data;


namespace Hospital1
{
    public partial class Form1 : Form
    {
        BL.Cls_Login log = new BL.Cls_Login();
        private string ID;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable Dt = log.Login(textBox1.Text, textBox2.Text);

            if (Dt.Rows.Count>0)
            {
                MessageBox.Show("Welcome" + @ID);
            }
            else
            {
                MessageBox.Show("You Cann't access this app");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        
    }
}
