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
	public partial class ExpenseForm : Form
	{
		public ExpenseForm()
		{
			InitializeComponent();
		}

		private void btnSaveExpense_Click(object sender, EventArgs e)
		{
			string path = Path.Combine(Application.StartupPath, "expense.txt");

			string category = txtCategory.Text;
			string amount = txtExpenseAmount.Text;

			if (category == "" || amount == "")
			{
				MessageBox.Show("Please fill all fields.");
				return;
			}

			decimal expenseAmount;

			if (!decimal.TryParse(amount, out expenseAmount))
			{
				MessageBox.Show("Invalid amount.");
				return;
			}

			File.AppendAllText(
				path,
				category + "|" + expenseAmount + Environment.NewLine
			);

			MessageBox.Show("Expense saved!");

			txtCategory.Clear();
			txtExpenseAmount.Clear();

			LoadExpenses();

			DashboardForm dashboard = (DashboardForm)Application.OpenForms["DashboardForm"];

			if (dashboard != null)
			{
				dashboard.UpdateDashboard();
			}
		}

		private void listBoxExpense_SelectedIndexChanged(object sender, EventArgs e)
		{
			string path = Path.Combine(Application.StartupPath, "expense.txt");

			listBoxExpense.Items.Clear();

			if (!File.Exists(path))
				return;

			foreach (string line in File.ReadAllLines(path))
			{
				string[] data = line.Split('|');

				listBoxExpense.Items.Add(
					data[0] + " - ₱" + data[1]
				);
			}
		}

		private void btnSaveExpense_Click_1(object sender, EventArgs e)
		{
			string path = Path.Combine(Application.StartupPath, "expense.txt");

			string category = txtCategory.Text;
			string amount = txtExpenseAmount.Text;

			if (category == "" || amount == "")
			{
				MessageBox.Show("Please fill all fields.");
				return;
			}

			decimal expenseAmount;

			if (!decimal.TryParse(amount, out expenseAmount))
			{
				MessageBox.Show("Invalid amount.");
				return;
			}

			File.AppendAllText(
				path,
				category + "|" + expenseAmount + Environment.NewLine
			);

			MessageBox.Show("Expense saved!");

			txtCategory.Clear();
			txtExpenseAmount.Clear();

			LoadExpenses();

			DashboardForm dashboard = (DashboardForm)Application.OpenForms["DashboardForm"];

			if (dashboard != null)
			{
				dashboard.UpdateDashboard();
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
	}
}