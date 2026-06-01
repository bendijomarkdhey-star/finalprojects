using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace finalproject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void linkLabel2_Click(object sender, EventArgs e)
        {
            RegitrationForm registerForm = new RegitrationForm();
            registerForm.Show();
            this.Hide();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
	{
		string path = Path.Combine(Application.StartupPath, "accounts.txt");

		string phone = textBox1.Text;
		string password = textBox2.Text;

		if (!File.Exists(path))
		{
			MessageBox.Show("No accounts found.");
			return;
		}

		var lines = File.ReadAllLines(path);

		bool found = lines.Any(line =>
		{
			string[] data = line.Split('|');
			return data[0] == phone && data[1] == password;
		});

		if (found)
		{
			MessageBox.Show("Login Successful!");

			DashboardForm dashboard = new DashboardForm();
			dashboard.Show();
			this.Hide();
		}
		else
		{
			MessageBox.Show("Invalid Phone Number or Password.");
		}
	}
}
}
