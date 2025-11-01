namespace Finance_Manager.UI.Forms
{
    partial class Kategories
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
            this.GoBack = new System.Windows.Forms.Button();
            this.groupBoxIncome = new System.Windows.Forms.GroupBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtNewCategory = new System.Windows.Forms.TextBox();
            this.listBoxIncome = new System.Windows.Forms.ListBox();
            this.groupBoxExpense = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxExpense = new System.Windows.Forms.ListBox();
            this.groupBoxIncome.SuspendLayout();
            this.groupBoxExpense.SuspendLayout();
            this.SuspendLayout();
            // 
            // GoBack
            // 
            this.GoBack.Location = new System.Drawing.Point(12, 1);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(33, 37);
            this.GoBack.TabIndex = 1;
            this.GoBack.Text = "🡸";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // groupBoxIncome
            // 
            this.groupBoxIncome.Controls.Add(this.btnAddCategory);
            this.groupBoxIncome.Controls.Add(this.txtNewCategory);
            this.groupBoxIncome.Controls.Add(this.listBoxIncome);
            this.groupBoxIncome.Location = new System.Drawing.Point(87, 12);
            this.groupBoxIncome.Name = "groupBoxIncome";
            this.groupBoxIncome.Size = new System.Drawing.Size(200, 574);
            this.groupBoxIncome.TabIndex = 2;
            this.groupBoxIncome.TabStop = false;
            this.groupBoxIncome.Text = "Доходы";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(6, 536);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(75, 23);
            this.btnAddCategory.TabIndex = 3;
            this.btnAddCategory.Text = "Добавить";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtNewCategory
            // 
            this.txtNewCategory.Location = new System.Drawing.Point(6, 510);
            this.txtNewCategory.Name = "txtNewCategory";
            this.txtNewCategory.Size = new System.Drawing.Size(100, 20);
            this.txtNewCategory.TabIndex = 3;
            // 
            // listBoxIncome
            // 
            this.listBoxIncome.AllowDrop = true;
            this.listBoxIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxIncome.FormattingEnabled = true;
            this.listBoxIncome.Location = new System.Drawing.Point(3, 16);
            this.listBoxIncome.Name = "listBoxIncome";
            this.listBoxIncome.Size = new System.Drawing.Size(194, 555);
            this.listBoxIncome.TabIndex = 3;
            // 
            // groupBoxExpense
            // 
            this.groupBoxExpense.Controls.Add(this.button1);
            this.groupBoxExpense.Controls.Add(this.textBox1);
            this.groupBoxExpense.Controls.Add(this.listBoxExpense);
            this.groupBoxExpense.Location = new System.Drawing.Point(466, 12);
            this.groupBoxExpense.Name = "groupBoxExpense";
            this.groupBoxExpense.Size = new System.Drawing.Size(215, 574);
            this.groupBoxExpense.TabIndex = 3;
            this.groupBoxExpense.TabStop = false;
            this.groupBoxExpense.Text = "Расходы";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 510);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // listBoxExpense
            // 
            this.listBoxExpense.AllowDrop = true;
            this.listBoxExpense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxExpense.FormattingEnabled = true;
            this.listBoxExpense.Location = new System.Drawing.Point(3, 16);
            this.listBoxExpense.Name = "listBoxExpense";
            this.listBoxExpense.Size = new System.Drawing.Size(209, 555);
            this.listBoxExpense.TabIndex = 3;
            // 
            // Kategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 598);
            this.Controls.Add(this.groupBoxExpense);
            this.Controls.Add(this.groupBoxIncome);
            this.Controls.Add(this.GoBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategories";
            this.groupBoxIncome.ResumeLayout(false);
            this.groupBoxIncome.PerformLayout();
            this.groupBoxExpense.ResumeLayout(false);
            this.groupBoxExpense.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.GroupBox groupBoxIncome;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtNewCategory;
        private System.Windows.Forms.GroupBox groupBoxExpense;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBoxExpense;
        private System.Windows.Forms.ListBox listBoxIncome;
    }
}