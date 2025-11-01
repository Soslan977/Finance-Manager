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
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNewCategory.Text))
            {
                if (groupBoxIncome.ContainsFocus)
                {
                    listBoxIncome.Items.Add(txtNewCategory.Text);
                }
                else if (groupBoxExpense.ContainsFocus)
                {
                    listBoxExpense.Items.Add(txtNewCategory.Text);
                }
                txtNewCategory.Clear();
            }
        }
        private void txtNewCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAddCategory_Click(sender, e);
            }
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            FinanceManagerMain.Instance.Show();
            this.Close();
        }
    }
}
