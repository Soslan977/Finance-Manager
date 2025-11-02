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

            switch (theme)
            {
                case ThemeType.Light:
                    ApplyLightTheme();
                    break;
                case ThemeType.Dark:
                    ApplyDarkTheme();
                    break;
            }
        }

        private void ApplyLightTheme()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;

            DarkTheme.BackColor = Color.LightGray;
            DarkTheme.ForeColor = Color.Black;
            LightTheme.BackColor = Color.LightBlue;
            LightTheme.ForeColor = Color.White;

            Chosetheme.ForeColor = Color.Black;

            ThemeSaver.SaveTheme((int)ThemeType.Light);
        }

        private void ApplyDarkTheme()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.ForeColor = Color.White;

            DarkTheme.BackColor = Color.LightBlue;
            DarkTheme.ForeColor = Color.White;
            LightTheme.BackColor = Color.LightGray;
            LightTheme.ForeColor = Color.Black;

            Chosetheme.ForeColor = Color.White;

            ThemeSaver.SaveTheme((int)ThemeType.Dark);
        }

       

        private void LightTheme_Click(object sender, EventArgs e)
        {
            ApplyTheme(ThemeType.Light);
            ApplyThemeToAllForms(ThemeType.Light);
        }

        private void ApplyThemeToAllForms(ThemeType theme)
        {
            foreach (Form form in Application.OpenForms)
            {
                ApplyTheme(form, theme);
            }
        }

        private void ApplyTheme(Form form, ThemeType theme)
        {
            switch (theme)
            {
                case ThemeType.Light:
                    form.BackColor = Color.White;
                    form.ForeColor = Color.Black;
                    break;
                case ThemeType.Dark:
                    form.BackColor = Color.FromArgb(30, 30, 30);
                    form.ForeColor = Color.White;
                    break;
            }
        }

        private void Dizain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ThemeSaver.SaveTheme((int)currentTheme);
        }
        private void GoBack_Click(object sender, EventArgs e)
        {
            FinanceManagerMain.Instance.Show();
            this.Close();
        }

        private void DarkTheme_Click_1(object sender, EventArgs e)
        {
            ApplyTheme(ThemeType.Dark);
            ApplyThemeToAllForms(ThemeType.Dark);
        }
    }

}
