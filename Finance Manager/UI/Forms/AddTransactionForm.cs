using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Finance_Manager.models;
using static Finance_Manager.UI.Forms.Kategories;

namespace Finance_Manager.UI.Forms
{
    public partial class AddTransactionForm : Form
    {
        private List<string> incomeCategories = new List<string>
    {
        "Зарплата",
        "Премия",
        "Возврат долга",
        "Подарок"
    };

        private List<string> expenseCategories = new List<string>
    {
        "Продукты",
        "Транспорт",
        "Жилье",
        "Развлечения",
        "Здоровье"
    };
        public Transaction Transaction { get; private set; }

        public AddTransactionForm()
        {
            InitializeComponent();
            radioIncome.CheckedChanged += radioIncome_CheckedChanged;
            radioExpense.CheckedChanged += radioExpense_CheckedChanged;

            radioIncome.Checked = true;
            UpdateCategoryList();
        }
        private void UpdateCategoryList()
        {
            cmbCategory.DataSource = radioIncome.Checked
           ? CategoryStorage.IncomeCategories
           : CategoryStorage.ExpenseCategories;
        }



        private void radioIncome_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCategoryList();
        }

        private void radioExpense_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCategoryList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
                return;

            // Создаем объект транзакции
            Transaction = new Transaction
            {
                Name = txtTransactionName.Text,
                Amount = numAmount.Value,
                Category = cmbCategory.Text,
                IsIncome = radioIncome.Checked,
                Date = dtpDate.Value
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private bool ValidateData()
        {
            if (string.IsNullOrEmpty(txtTransactionName.Text))
            {
                MessageBox.Show("Введите название транзакции!");
                return false;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите категорию!");
                return false;
            }

            if (numAmount.Value <= 0)
            {
                MessageBox.Show("Сумма должна быть больше нуля!");
                return false;
            }

            return true; // Все проверки пройдены успешно
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void numAmount_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
