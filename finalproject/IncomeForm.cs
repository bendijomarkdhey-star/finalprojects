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

namespace finalproject
{
	public partial class IncomeForm : Form
	{
		public IncomeForm()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void btnSaveIncome_Click(object sender, EventArgs e)
		{
			string path = Path.Combine(Application.StartupPath, "income.txt");

			string source = txtSource.Text;
			string amount = txtAmount.Text;

			if (source == "" || amount == "")
			{
				MessageBox.Show("Please fill all fields.");
				return;
			}

			File.AppendAllText(path, source + "|" + amount + Environment.NewLine);

			MessageBox.Show("Income saved!");

			txtSource.Clear();
			txtAmount.Clear();
		}

		private void IncomeForm_Load(object sender, EventArgs e)
		{
			LoadIncome();
		}

		private void LoadIncome()
		{
			string path = Path.Combine(Application.StartupPath, "income.txt");

			listBoxIncome.Items.Clear();

			if (!File.Exists(path))
				return;

			foreach (string line in File.ReadAllLines(path))
			{
				string[] data = line.Split('|');

				listBoxIncome.Items.Add(
					data[0] + " - ₱" + data[1]
				);
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			DashboardForm dashboard = (DashboardForm)Application.OpenForms["DashboardForm"];

			if (dashboard != null)
			{
				dashboard.UpdateDashboard();
				dashboard.Show();
			}

			this.Close();
		}

		private void IncomeForm_Load_1(object sender, EventArgs e)
		{
			LoadIncome();
		}
	}
}
