using System;
using System.IO;
using System.Windows.Forms;

namespace finalproject
{
	partial class ExpenseForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveExpense = new System.Windows.Forms.Button();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxExpense = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Record and categorize your expenses.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXPENSE ENTRY";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 99);
            this.panel1.TabIndex = 1;
            // 
            // btnSaveExpense
            // 
            this.btnSaveExpense.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSaveExpense.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveExpense.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveExpense.Location = new System.Drawing.Point(640, 198);
            this.btnSaveExpense.Name = "btnSaveExpense";
            this.btnSaveExpense.Size = new System.Drawing.Size(174, 40);
            this.btnSaveExpense.TabIndex = 12;
            this.btnSaveExpense.Text = "SAVE EXPENSE";
            this.btnSaveExpense.UseVisualStyleBackColor = false;
            this.btnSaveExpense.Click += new System.EventHandler(this.btnSaveExpense_Click_1);
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Location = new System.Drawing.Point(208, 216);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(375, 22);
            this.txtExpenseAmount.TabIndex = 11;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(208, 179);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(375, 22);
            this.txtCategory.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Amount (₱):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Expense Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(7, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "ADD EXPENSE";
            // 
            // listBoxExpense
            // 
            this.listBoxExpense.FormattingEnabled = true;
            this.listBoxExpense.ItemHeight = 16;
            this.listBoxExpense.Location = new System.Drawing.Point(15, 337);
            this.listBoxExpense.Name = "listBoxExpense";
            this.listBoxExpense.Size = new System.Drawing.Size(754, 116);
            this.listBoxExpense.TabIndex = 14;
            this.listBoxExpense.SelectedIndexChanged += new System.EventHandler(this.listBoxExpense_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(10, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "EXPENSE RECORDS";
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBack.Location = new System.Drawing.Point(334, 502);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 40);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 621);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listBoxExpense);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSaveExpense);
            this.Controls.Add(this.txtExpenseAmount);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "ExpenseForm";
            this.Text = "ExpenseForm";
            this.Load += new System.EventHandler(this.ExpenseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void ExpenseForm_Load(object sender, EventArgs e)
		{
			LoadExpenses();
		}

		private void LoadExpenses()
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

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSaveExpense;
		private System.Windows.Forms.TextBox txtExpenseAmount;
		private System.Windows.Forms.TextBox txtCategory;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox listBoxExpense;
		private System.Windows.Forms.Label label6;
		private Button btnBack;
	}
}