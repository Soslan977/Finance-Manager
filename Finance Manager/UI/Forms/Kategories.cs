using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Finance_Manager.UI.Forms.Dizain;
using static Finance_Manager.UI.Forms.Dizain.ThemeManager;

namespace Finance_Manager.UI.Forms
{
    public partial class Kategories : Form, IThemeable
    {
        public Kategories()
        {
            InitializeComponent();
            LoadCategories();

            listBoxIncome.DataSource = CategoryStorage.IncomeCategories;
            listBoxExpense.DataSource = CategoryStorage.ExpenseCategories;
            ThemeManager.ThemeChanged += OnThemeChanged;
            ApplyTheme(ThemeManager.CurrentTheme);
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            ApplyTheme(ThemeManager.CurrentTheme);
        }


        public void ApplyTheme(ThemeType theme)
        {
            // Логика применения темы к элементам управления данной формы
            this.BackColor = theme == ThemeType.Light ? Color.White : Color.FromArgb(30, 30, 30);
            this.ForeColor = theme == ThemeType.Light ? Color.Black : Color.White;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button button)
                {
                    button.ForeColor = theme == ThemeType.Light ? Color.Black : Color.White;
                    button.BackColor = theme == ThemeType.Light ? Color.White : Color.FromArgb(50, 50, 50);
                }
                else if (ctrl is Label label)
                {
                    label.ForeColor = theme == ThemeType.Light ? Color.Black : Color.White;
                }
            }
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            ThemeManager.ThemeChanged -= OnThemeChanged;
            base.OnFormClosed(e);
        }
        public static class CategoryStorage
        {
            // Используем BindingList для автоматического обновления
            public static BindingList<string> IncomeCategories { get; set; } = new BindingList<string>
    {
        "Зарплата",
        "Премия",
        "Возврат долга",
        "Подарок"
    };

            public static BindingList<string> ExpenseCategories { get; set; } = new BindingList<string>
    {
        "Продукты",
        "Транспорт",
        "Жилье",
        "Развлечения",
        "Здоровье"
    };
        }


        private void LoadCategories()
        {
            listBoxIncome.Items.Clear();
            listBoxExpense.Items.Clear();

            listBoxIncome.Items.AddRange(CategoryStorage.IncomeCategories.ToArray());
            listBoxExpense.Items.AddRange(CategoryStorage.ExpenseCategories.ToArray());
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            string newCategory = txtIncomeInput.Text.Trim();

            if (!string.IsNullOrEmpty(newCategory) &&
                !CategoryStorage.IncomeCategories.Contains(newCategory))
            {
                CategoryStorage.IncomeCategories.Add(newCategory);
                txtIncomeInput.Clear();
            }
            else
            {
                MessageBox.Show("Категория уже существует или не заполнена!");
            }
        }


        private void GoBack_Click(object sender, EventArgs e)
        {
            FinanceManagerMain.Instance.Show();
            this.Close();
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            string newCategory = txtExpenseInput.Text.Trim();

            if (!string.IsNullOrEmpty(newCategory) &&
                !CategoryStorage.ExpenseCategories.Contains(newCategory))
            {
                CategoryStorage.ExpenseCategories.Add(newCategory);
                txtExpenseInput.Clear();
            }
            else
            {
                MessageBox.Show("Категория уже существует или не заполнена!");
            }
        }
    }
}
