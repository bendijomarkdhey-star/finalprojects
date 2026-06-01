using System;

namespace finalproject
{
	partial class DashboardForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblExpense = new System.Windows.Forms.Label();
            this.lblSavings = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERSONAL SPENDING AND SAVINGS MONITOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(7, 126);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(198, 29);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, User!";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblBalance.Location = new System.Drawing.Point(14, 12);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(237, 25);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Current Balance: ₱0.00";
            this.lblBalance.Click += new System.EventHandler(this.lblBalance_Click);
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblIncome.Location = new System.Drawing.Point(14, 63);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(189, 22);
            this.lblIncome.TabIndex = 3;
            this.lblIncome.Text = "Total Income: ₱0.00";
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpense.ForeColor = System.Drawing.Color.Maroon;
            this.lblExpense.Location = new System.Drawing.Point(274, 63);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(213, 22);
            this.lblExpense.TabIndex = 4;
            this.lblExpense.Text = "Total Expenses: ₱0.00";
            this.lblExpense.Click += new System.EventHandler(this.lblExpense_Click);
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavings.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSavings.Location = new System.Drawing.Point(554, 63);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(197, 22);
            this.lblSavings.TabIndex = 5;
            this.lblSavings.Text = "Total Savings: ₱0.00";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(12, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(403, 100);
            this.button1.TabIndex = 6;
            this.button1.Text = "ADD INCOME";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(421, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(384, 100);
            this.button2.TabIndex = 7;
            this.button2.Text = "ADD EXPENSE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(484, 555);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "LOGOUT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 104);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblBalance);
            this.panel2.Location = new System.Drawing.Point(12, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 51);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Manage your finances wisely.";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblSavings);
            this.panel3.Controls.Add(this.lblIncome);
            this.panel3.Controls.Add(this.lblExpense);
            this.panel3.Location = new System.Drawing.Point(12, 387);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(793, 136);
            this.panel3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "SAVINGS OVERVIEW REPORT";
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(97, 555);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(220, 40);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "RESET DATA";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 629);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWelcome);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			ExpenseForm exp = new ExpenseForm();
			exp.Show();
		}

		private void DashboardForm_Load(object sender, EventArgs e)
		{
			UpdateDashboard();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			IncomeForm incomeForm = new IncomeForm();
			incomeForm.Show();
		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblWelcome;
		private System.Windows.Forms.Label lblBalance;
		private System.Windows.Forms.Label lblIncome;
		private System.Windows.Forms.Label lblExpense;
		private System.Windows.Forms.Label lblSavings;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnReset;
	}
}