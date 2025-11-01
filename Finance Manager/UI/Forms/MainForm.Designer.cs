﻿namespace Finance_Manager
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuPanel = new System.Windows.Forms.Panel();
            this.burgerButton = new System.Windows.Forms.Button();
            this.Расходы = new System.Windows.Forms.Button();
            this.Доходы = new System.Windows.Forms.Button();
            this.AddTransaction = new System.Windows.Forms.Button();
            this.Balance = new System.Windows.Forms.Button();
            this.chartGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
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
            // chartGraphic
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraphic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraphic.Legends.Add(legend1);
            resources.ApplyResources(this.chartGraphic, "chartGraphic");
            this.chartGraphic.Name = "chartGraphic";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGraphic.Series.Add(series1);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            resources.ApplyResources(this.chart2, "chart2");
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            // 
            // FinanceManagerMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chartGraphic);
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
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraphic;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

