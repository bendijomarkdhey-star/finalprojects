using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

		private void showPassCheckBx_CheckedChanged(object sender, EventArgs e)
		{
          textBox4.PasswordChar = showPassCheckBx.Checked ? '\0' : '*';
         
            }

		private void button1_Click(object sender, EventArgs e)
		{
            Form1 login  = new Form1();
            login.Show();
            this.Hide();

		}
	}
	}
