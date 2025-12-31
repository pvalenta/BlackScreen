using System;
using System.Windows.Forms;

namespace BlackScreen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PopulateScreens();
        }

        private void PopulateScreens()
        {
            comboBoxScreens.Items.Clear();
            var screens = Screen.AllScreens;
            for (int i = 0; i < screens.Length; i++)
            {
                var s = screens[i];
                var name = $"Monitor {i + 1}";
                if (s.Primary) name += " (Primary)";
                name += $" - {s.Bounds.Width}x{s.Bounds.Height}";
                comboBoxScreens.Items.Add(name);
            }
            if (comboBoxScreens.Items.Count > 0) comboBoxScreens.SelectedIndex = 0;
        }

        private void buttonMakeBlack_Click(object? sender, EventArgs e)
        {
            var idx = comboBoxScreens.SelectedIndex;
            if (idx < 0) return;
            var screen = Screen.AllScreens[idx];
            var black = new BlackForm(screen);
            this.Hide();
            black.FormClosed += (s, args) => { this.Show(); };
            black.Show();
        }
    }
}
