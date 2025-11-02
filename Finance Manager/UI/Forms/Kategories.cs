using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_Manager.UI.Forms
{
    public partial class Kategories : Form
    {
        public Kategories()
        {
            InitializeComponent();
            LoadCategories();

            listBoxIncome.DataSource = CategoryStorage.IncomeCategories;
            listBoxExpense.DataSource = CategoryStorage.ExpenseCategories;
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
