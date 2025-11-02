using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Finance_Manager.models;
using Finance_Manager.UI.Forms;

namespace Finance_Manager
{
    public partial class FinanceManagerMain : Form
    {
        public static FinanceManagerMain Instance { get; private set; }
        private bool menuIsVisible = false;
        private List<Transaction> transactions = new List<Transaction>();
        public bool isIncomeMode = true;
        private List<string> categories = new List<string>();
        public FinanceManagerMain()
        {
            InitializeComponent();
            AddMenuItems();
            Instance = this;

            chartGraphic.Series.Clear();
            chartGraphic.Series.Add("Транзакции");
            chartGraphic.Series[0].ChartType = SeriesChartType.Pie;
            chartGraphic.Titles.Add("Распределение транзакций");

            InitializeCategories();


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            burgerButton.Visible = true;
            menuPanel.Visible = menuIsVisible;
        }
        private void ShowForm(Form newForm)
        {
            this.Hide();

            newForm.Show();

            // При закрытии новой формы - показываем главную
            newForm.FormClosed += (s, args) => this.Show();
        }
        private void InitializeCategories()
        {
            categories.Add("Еда");
            categories.Add("Транспорт");
            categories.Add("Развлечения");
            categories.Add("Коммунальные услуги");
            categories.Add("Другое");
        }
        private void MenuItem_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            

            switch (button.Text)
            {
                case "Главная":
                    ShowForm(new FinanceManagerMain());
                    break;
                case "Категории":
                    ShowForm(new Kategories());
                    break;
                case "Графики":
                    ShowForm(new Graphicss());
                    break;
                case "Регулярный платеж":
                    break;
                case "Дизайн":
                    ShowForm(new Dizain());
                    break;
                case "Валюта":
                    ShowForm(new ChooseVallet());
                    break;
            }
        }



        private void AddMenuItems()
        {
            var items = new[] { "Настройки", "Категории", "Графики", "Регулярный платеж","Дизайн","Валюта" };

            foreach (var item in items)
            {
                var button = new Button
                {
                    Text = item,
                    Dock = DockStyle.Top,
                    Height = 30,
                    BackColor = Color.FromArgb(224, 224, 224)
                };
                button.Click += MenuItem_Click;
                menuPanel.Controls.Add(button);
            }
        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void burgerButton_Click_1(object sender, EventArgs e)
        {
            Panel menu = menuPanel;

            menu.Visible = !menu.Visible;

            if (menu.Visible)
            {
                burgerButton.Text = "×";
            }
            else
            {
                burgerButton.Text = "☰";
            }
        }

        private void Expensesbutton1_Click(object sender, EventArgs e)
        {
            isIncomeMode = false;
            UpdateChart();
        }

        private void Доходы_Click(object sender, EventArgs e)
        {
            isIncomeMode = true;
            UpdateChart();
        }
        private void UpdateChart()
        {
            chartGraphic.Series[0].Points.Clear();

            var filteredTransactions = isIncomeMode
                ? transactions.Where(t => t.IsIncome)
                : transactions.Where(t => !t.IsIncome);

            var grouped = filteredTransactions
                .GroupBy(t => t.Category)
                .Select(g => new { Category = g.Key, Total = g.Sum(t => t.Amount) });

            foreach (var item in grouped)
            {
                chartGraphic.Series[0].Points.AddXY(item.Category, item.Total);
            }

            UpdateBalance();
        }

        // Обновление баланса
        private void UpdateBalance()
        {
            decimal totalIncome = transactions.Where(t => t.IsIncome).Sum(t => t.Amount);
            decimal totalExpenses = transactions.Where(t => !t.IsIncome).Sum(t => t.Amount);
            decimal balance = totalIncome - totalExpenses;

            lblBalance.Text = $"Баланс: {balance:C}";
        }

        private void AddTransaction_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddTransactionForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // Получаем данные из формы
                    var transaction = addForm.Transaction;

                    transactions.Add(transaction);

                    UpdateChart();
                    UpdateBalance();
                }
            }
        }

       
    }
}
