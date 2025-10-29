using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finance_Manager.UI.Forms;

namespace Finance_Manager
{
    public partial class FinanceManagerMain : Form
    {
        public static FinanceManagerMain Instance { get; private set; }
        private bool menuIsVisible = false;

        public FinanceManagerMain()
        {
            InitializeComponent();
            AddMenuItems();
            Instance = this;
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

        }

        private void Доходы_Click(object sender, EventArgs e)
        {

        }

        private void AddTransaction_Click(object sender, EventArgs e)
        {

        }

       
    }
}
