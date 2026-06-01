using System;
using System.IO;
using System.Windows.Forms;

namespace finalproject
{
	partial class IncomeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnSaveIncome = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxIncome = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 94);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Record and manage your income source.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "INCOME ENTRY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(8, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "ADD INCOME";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Income Source:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Amount (₱):";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(190, 175);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(375, 22);
            this.txtSource.TabIndex = 4;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(190, 212);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(375, 22);
            this.txtAmount.TabIndex = 5;
            // 
            // btnSaveIncome
            // 
            this.btnSaveIncome.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSaveIncome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveIncome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveIncome.Location = new System.Drawing.Point(620, 194);
            this.btnSaveIncome.Name = "btnSaveIncome";
            this.btnSaveIncome.Size = new System.Drawing.Size(150, 40);
            this.btnSaveIncome.TabIndex = 6;
            this.btnSaveIncome.Text = "SAVE INCOME";
            this.btnSaveIncome.UseVisualStyleBackColor = false;
            this.btnSaveIncome.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(11, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "INCOME RECORDS";
            // 
            // listBoxIncome
            // 
            this.listBoxIncome.FormattingEnabled = true;
            this.listBoxIncome.ItemHeight = 16;
            this.listBoxIncome.Location = new System.Drawing.Point(16, 339);
            this.listBoxIncome.Name = "listBoxIncome";
            this.listBoxIncome.Size = new System.Drawing.Size(754, 116);
            this.listBoxIncome.TabIndex = 8;
            this.listBoxIncome.SelectedIndexChanged += new System.EventHandler(this.listBoxIncome_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBack.Location = new System.Drawing.Point(335, 510);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 40);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 611);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listBoxIncome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSaveIncome);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "IncomeForm";
            this.Text = "IncomeForm";
            this.Load += new System.EventHandler(this.IncomeForm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void listBoxIncome_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadIncome();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string path = Path.Combine(Application.StartupPath, "income.txt");

			string source = txtSource.Text;
			string amount = txtAmount.Text;

			if (source == "" || amount == "")
			{
				MessageBox.Show("Please fill all fields.");
				return;
			}

			decimal incomeAmount;

			if (!decimal.TryParse(amount, out incomeAmount))
			{
				MessageBox.Show("Please enter a valid amount.");
				return;
			}

			File.AppendAllText(
				path,
				source + "|" + incomeAmount + Environment.NewLine
			);

			MessageBox.Show("Income saved successfully!");

			txtSource.Clear();
			txtAmount.Clear();

			LoadIncome();

			DashboardForm dashboard = (DashboardForm)Application.OpenForms["DashboardForm"];

			if (dashboard != null)
			{
				dashboard.UpdateDashboard();
			}
		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSource;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.Button btnSaveIncome;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ListBox listBoxIncome;
		private Button btnBack;
	}
}