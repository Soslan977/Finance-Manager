using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Finance_Manager.UI.Forms
{
    public partial class Dizain : Form
    {

        private void GoBack_Click(object sender, EventArgs e)
        {
            FinanceManagerMain.Instance.Show();
            this.Close();
        }

        public static class ThemeSaver
        {
            private static string filePath = "theme.txt";

            public static void SaveTheme(int theme)
            {
                try
                {
                    File.WriteAllText(filePath, theme.ToString());
                }
                catch { }
            }

            public static int LoadTheme()
            {
                if (File.Exists(filePath))
                {
                    try
                    {
                        return int.Parse(File.ReadAllText(filePath));
                    }
                    catch { }
                }
                return 0; // По умолчанию светлая тема
            }
        }

        private enum ThemeType
        {
            Light = 0,
            Dark = 1
        }

        private ThemeType currentTheme;

        public Dizain()
        {
            InitializeComponent();

            currentTheme = (ThemeType)ThemeSaver.LoadTheme();
            ApplyTheme(currentTheme);
        }

        private void ApplyTheme(ThemeType theme)
        {
            currentTheme = theme;
            ApplyThemeToAllForms(theme);
        }

        private void ApplyThemeToAllForms(ThemeType theme)
        {
            foreach (Form form in Application.OpenForms)
            {
                ApplyControlsTheme(form, theme);
            }
        }

        private void ApplyControlsTheme(Form form, ThemeType theme)
        {
            switch (theme)
            {
                case ThemeType.Light:
                    form.BackColor = Color.White;
                    form.ForeColor = Color.Black;
                    ApplyLightThemeControls(form);
                    break;
                case ThemeType.Dark:
                    form.BackColor = Color.FromArgb(30, 30, 30);
                    form.ForeColor = Color.White;
                    ApplyDarkThemeControls(form);
                    break;
            }
        }

        private void ApplyLightThemeControls(Form form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is Button button)
                {
                    button.ForeColor = Color.Black;
                    if (button == DarkTheme)
                    {
                        button.BackColor = Color.LightGray;
                    }
                    else if (button == LightTheme)
                    {
                        button.BackColor = Color.LightBlue;
                        button.ForeColor = Color.White;
                    }
                    else
                    {
                        button.BackColor = Color.White;
                    }
                }
                else if (ctrl is Label label)
                {
                    label.ForeColor = Color.Black;
                }
            }
        }

        private void ApplyDarkThemeControls(Form form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is Button button)
                {
                    if (button == DarkTheme)
                    {
                        button.BackColor = Color.LightBlue;
                        button.ForeColor = Color.White;
                    }
                    else if (button == LightTheme)
                    {
                        button.BackColor = Color.LightGray;
                        button.ForeColor = Color.Black;
                    }
                    else
                    {
                        button.BackColor = Color.FromArgb(50, 50, 50);
                        button.ForeColor = Color.White;
                    }
                }
                else if (ctrl is Label label)
                {
                    label.ForeColor = Color.White;
                }
            }
        }

        private void LightTheme_Click(object sender, EventArgs e)
        {
            ApplyTheme(ThemeType.Light);
            ThemeSaver.SaveTheme((int)ThemeType.Light);
        }

        private void DarkTheme_Click_1(object sender, EventArgs e)
        {
            ApplyTheme(ThemeType.Dark);
            ThemeSaver.SaveTheme((int)ThemeType.Dark);
        }
    }
}