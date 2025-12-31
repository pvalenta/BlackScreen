using System.Drawing;
using System.Windows.Forms;

namespace BlackScreen
{
    public class BlackForm : Form
    {
        private Screen targetScreen;

        public BlackForm(Screen screen)
        {
            targetScreen = screen;
            Initialize();
        }

        private void Initialize()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.BackColor = Color.Black;
            this.DoubleBuffered = true;
            this.MouseDoubleClick += BlackForm_MouseDoubleClick;

            // Set bounds to the screen's bounds
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = targetScreen.Bounds;
        }

        private void BlackForm_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
