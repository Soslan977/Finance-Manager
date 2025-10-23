using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_Manager
{
    public partial class FinanceManagerMain : Form
    {
        private Panel menuPanel;
        private Button burgerButton;
        private bool menuIsVisible = false;

        public FinanceManagerMain()
        {
            InitializeComponent();
            InitializeMenu();
            

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            burgerButton.Visible = true;
            menuPanel.Visible = true;
        }
        private void BurgerButton_Click(object sender, EventArgs e)
        {
            menuIsVisible = !menuIsVisible;
            menuPanel.Visible = menuIsVisible;

            if (menuIsVisible)
            {
                burgerButton.Text = "×";
            }
            else
            {
                burgerButton.Text = "☰";
            }
        }
        private void MenuItem_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            

            switch (button.Text)
            {
                case "Главная":
                    break;
                case "Категории":
                    break;
                case "Графики":
                    break;
                case "Настройки":
                case "Регулярный платеж":
                case "Дизайн":
                case "Валюта":
                    break;
            }
        }
        private void InitializeMenu()
        {
            burgerButton = new Button
            {
                Location = new Point(10, 10),
                Width = 30,
                Height = 30,
                Text = "☰",
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                Visible = true
            };
            burgerButton.Click += BurgerButton_Click;
            this.Controls.Add(burgerButton);

            menuPanel = new Panel
            {
                Dock = DockStyle.Left,
                Width = 200,
                BackColor = Color.LightGray,
                Visible = false
            };

            AddMenuItems();
            this.Controls.Add(menuPanel);
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


        
    }
}
