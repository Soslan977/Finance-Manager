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
        
        private bool menuIsVisible = false;

        public FinanceManagerMain()
        {
            InitializeComponent();
            AddMenuItems();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            burgerButton.Visible = true;
            menuPanel.Visible = menuIsVisible;
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
                    break;
                case "Регулярный платеж":
                    break;
                case "Дизайн":
                    break;
                case "Валюта":
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
    }
}
