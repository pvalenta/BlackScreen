namespace BlackScreen
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxScreens;
        private System.Windows.Forms.Button buttonMakeBlack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxScreens = new System.Windows.Forms.ComboBox();
            this.buttonMakeBlack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxScreens
            // 
            this.comboBoxScreens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScreens.FormattingEnabled = true;
            this.comboBoxScreens.Location = new System.Drawing.Point(12, 12);
            this.comboBoxScreens.Name = "comboBoxScreens";
            this.comboBoxScreens.Size = new System.Drawing.Size(360, 23);
            this.comboBoxScreens.TabIndex = 0;
            // 
            // buttonMakeBlack
            // 
            this.buttonMakeBlack.Location = new System.Drawing.Point(12, 50);
            this.buttonMakeBlack.Name = "buttonMakeBlack";
            this.buttonMakeBlack.Size = new System.Drawing.Size(120, 30);
            this.buttonMakeBlack.TabIndex = 1;
            this.buttonMakeBlack.Text = "Make it black";
            this.buttonMakeBlack.UseVisualStyleBackColor = true;
            this.buttonMakeBlack.Click += new System.EventHandler(this.buttonMakeBlack_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 101);
            this.Controls.Add(this.buttonMakeBlack);
            this.Controls.Add(this.comboBoxScreens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black Screen";
            this.ResumeLayout(false);
        }
    }
}
