namespace Finance_Manager
{
    partial class FinanceManagerMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceManagerMain));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuPanel = new System.Windows.Forms.Panel();
            this.burgerButton = new System.Windows.Forms.Button();
            this.Расходы = new System.Windows.Forms.Button();
            this.Доходы = new System.Windows.Forms.Button();
            this.AddTransaction = new System.Windows.Forms.Button();
            this.Balance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.menuPanel, "menuPanel");
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuPanel_Paint);
            // 
            // burgerButton
            // 
            this.burgerButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.burgerButton, "burgerButton");
            this.burgerButton.Name = "burgerButton";
            this.burgerButton.UseVisualStyleBackColor = false;
            this.burgerButton.Click += new System.EventHandler(this.burgerButton_Click_1);
            // 
            // Расходы
            // 
            resources.ApplyResources(this.Расходы, "Расходы");
            this.Расходы.Name = "Расходы";
            this.Расходы.UseVisualStyleBackColor = true;
            this.Расходы.Click += new System.EventHandler(this.Expensesbutton1_Click);
            // 
            // Доходы
            // 
            resources.ApplyResources(this.Доходы, "Доходы");
            this.Доходы.Name = "Доходы";
            this.Доходы.UseVisualStyleBackColor = true;
            this.Доходы.Click += new System.EventHandler(this.Доходы_Click);
            // 
            // AddTransaction
            // 
            resources.ApplyResources(this.AddTransaction, "AddTransaction");
            this.AddTransaction.Name = "AddTransaction";
            this.AddTransaction.UseVisualStyleBackColor = true;
            this.AddTransaction.Click += new System.EventHandler(this.AddTransaction_Click);
            // 
            // Balance
            // 
            resources.ApplyResources(this.Balance, "Balance");
            this.Balance.Name = "Balance";
            this.Balance.UseVisualStyleBackColor = true;
            // 
            // FinanceManagerMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.AddTransaction);
            this.Controls.Add(this.Доходы);
            this.Controls.Add(this.Расходы);
            this.Controls.Add(this.burgerButton);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinanceManagerMain";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button burgerButton;
        private System.Windows.Forms.Button Расходы;
        private System.Windows.Forms.Button Доходы;
        private System.Windows.Forms.Button AddTransaction;
        private System.Windows.Forms.Button Balance;
    }
}

