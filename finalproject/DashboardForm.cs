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
	public partial class DashboardForm : Form
	{
		public DashboardForm()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		public void UpdateDashboard()
		{
			string incomePath = Path.Combine(Application.StartupPath, "income.txt");
			string expensePath = Path.Combine(Application.StartupPath, "expense.txt");

			decimal totalIncome = 0;
			decimal totalExpense = 0;

			// GET TOTAL INCOME
			if (File.Exists(incomePath))
			{
				foreach (string line in File.ReadAllLines(incomePath))
				{
					string[] data = line.Split('|');
					decimal amount;

					if (decimal.TryParse(data[1], out amount))
					{
						totalIncome += amount;
					}
				}
			}

			// GET TOTAL EXPENSE
			if (File.Exists(expensePath))
			{
				foreach (string line in File.ReadAllLines(expensePath))
				{
					string[] data = line.Split('|');
					decimal amount;

					if (decimal.TryParse(data[1], out amount))
					{
						totalExpense += amount;
					}
				}
			}

			// CALCULATIONS
			decimal balance = totalIncome - totalExpense;
			decimal savings = balance;

			// DISPLAY ON LABELS
			lblIncome.Text = "Total Income: ₱" + totalIncome;
			lblExpense.Text = "Total Expenses: ₱" + totalExpense;
			lblBalance.Text = "Current Balance: ₱" + balance;
			lblSavings.Text = "Total Savings: ₱" + savings;
		}

		private void lblBalance_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(
		"Are you sure you want to logout?",
		"Logout Confirmation",
		MessageBoxButtons.YesNo,
		MessageBoxIcon.Question
	);

			if (result == DialogResult.Yes)
			{
				LoginForm login = new LoginForm();
				login.Show();
				this.Close();
			}
		}

		private void btnIncome_Click(object sender, EventArgs e)
		{
			IncomeForm incomeForm = new IncomeForm();
			incomeForm.Show();
		}

		private void btnExpense_Click(object sender, EventArgs e)
		{
			ExpenseForm exp = new ExpenseForm();
			exp.Show();
		}

		private void lblExpense_Click(object sender, EventArgs e)
		{

		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(
				"Are you sure you want to reset all data?",
				"Confirm Reset",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning
			);

			if (result == DialogResult.Yes)
			{
				string incomePath = Path.Combine(Application.StartupPath, "income.txt");
				string expensePath = Path.Combine(Application.StartupPath, "expense.txt");

				if (File.Exists(incomePath))
				{
					File.WriteAllText(incomePath, string.Empty);
				}

				if (File.Exists(expensePath))
				{
					File.WriteAllText(expensePath, string.Empty);
				}

				UpdateDashboard();

				MessageBox.Show("All data has been reset!");
			}
		}
	}
}
