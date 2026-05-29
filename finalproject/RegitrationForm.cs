using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
	public partial class RegitrationForm : Form
	{
		public RegitrationForm()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void linkLabel1_Click(object sender, EventArgs e)
		{
			LoginForm loginForm = new LoginForm();
			loginForm.Show();
			this.Hide();
		}

		private void showPassCheckBx_CheckedChanged(object sender, EventArgs e)
		{
			passwordText.PasswordChar = showPassCheckBx.Checked ? '\0' : '*';

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string phoneNumber = phoneNum.Text;
			string password = passwordText.Text;

			if (!IsValidPhoneNumber(phoneNumber))
			{
				MessageBox.Show("Invalid Phone Number (must be 11 digits and start with 09)");
				return;
			}

			if (!IsValidPassword(password))
			{
				MessageBox.Show("Invalid Password (8-12 chars, must contain letters and numbers)");
				return;
			}

			MessageBox.Show("Registration Successful!");

			LoginForm login = new LoginForm();
			login.Show();
			this.Hide();
		}

		private bool IsValidPhoneNumber(string phoneNumber)
		{
			if (string.IsNullOrWhiteSpace(phoneNumber))
				return false;

			if (phoneNumber.Length != 11)
				return false;

			if (!phoneNumber.StartsWith("09"))
				return false;

			foreach (char c in phoneNumber)
			{
				if (!char.IsDigit(c))
					return false;
			}

			return true;
		}

		private bool IsValidPassword(string password)
		{
			if (string.IsNullOrWhiteSpace(password))
				return false;

			if (password.Length < 8 || password.Length > 12)
				return false;

			bool hasLetter = false;
			bool hasDigit = false;

			foreach (char c in password)
			{
				if (char.IsLetter(c))
					hasLetter = true;

				if (char.IsDigit(c))
					hasDigit = true;
			}

			return hasLetter && hasDigit;
		}
	}
}

