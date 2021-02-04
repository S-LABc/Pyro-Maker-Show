namespace PyroMaker
{
    partial class PyroMakerShow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PyroMakerShow));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.nameTile = new MetroFramework.Controls.MetroTile();
            this.nameCUE1 = new MetroFramework.Controls.MetroTextBox();
            this.delayTile = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.nameCUE2 = new MetroFramework.Controls.MetroTextBox();
            this.nameCUE3 = new MetroFramework.Controls.MetroTextBox();
            this.nameCUE4 = new MetroFramework.Controls.MetroTextBox();
            this.nameCUE5 = new MetroFramework.Controls.MetroTextBox();
            this.nameCUE6 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.delayCUE1 = new MetroFramework.Controls.MetroTextBox();
            this.delayCUE2 = new MetroFramework.Controls.MetroTextBox();
            this.delayCUE3 = new MetroFramework.Controls.MetroTextBox();
            this.delayCUE4 = new MetroFramework.Controls.MetroTextBox();
            this.delayCUE5 = new MetroFramework.Controls.MetroTextBox();
            this.timeCUE6 = new MetroFramework.Controls.MetroTextBox();
            this.timeCUE5 = new MetroFramework.Controls.MetroTextBox();
            this.timeTile = new MetroFramework.Controls.MetroTile();
            this.timeCUE4 = new MetroFramework.Controls.MetroTextBox();
            this.timeCUE1 = new MetroFramework.Controls.MetroTextBox();
            this.timeCUE3 = new MetroFramework.Controls.MetroTextBox();
            this.timeCUE2 = new MetroFramework.Controls.MetroTextBox();
            this.portsBox = new MetroFramework.Controls.MetroComboBox();
            this.saveLink = new MetroFramework.Controls.MetroLink();
            this.openLink = new MetroFramework.Controls.MetroLink();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.memoLink = new MetroFramework.Controls.MetroLink();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.serialP = new System.IO.Ports.SerialPort(this.components);
            this.downloadLink = new MetroFramework.Controls.MetroLink();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.youtubeLink = new MetroFramework.Controls.MetroLink();
            this.donateLink = new MetroFramework.Controls.MetroLink();
            this.aboutLink = new MetroFramework.Controls.MetroLink();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 119);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "CUE #1";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.AutoSize = true;
            this.metroTile1.Enabled = false;
            this.metroTile1.Location = new System.Drawing.Point(23, 73);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(63, 32);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile1.TabIndex = 500;
            this.metroTile1.TabStop = false;
            this.metroTile1.Text = "КАНАЛ";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseMnemonic = false;
            this.metroTile1.UseSelectable = true;
            // 
            // nameTile
            // 
            this.nameTile.ActiveControl = null;
            this.nameTile.AutoSize = true;
            this.nameTile.Location = new System.Drawing.Point(92, 73);
            this.nameTile.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.nameTile.Name = "nameTile";
            this.nameTile.Size = new System.Drawing.Size(166, 32);
            this.nameTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.nameTile.TabIndex = 23;
            this.nameTile.Text = "НАЗВАНИЕ ИЗДЕЛИЯ";
            this.nameTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nameTile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.nameTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroToolTip1.SetToolTip(this.nameTile, "Очистка ячеек столбца \"Название изделя\"");
            this.nameTile.UseMnemonic = false;
            this.nameTile.UseSelectable = true;
            this.nameTile.Click += new System.EventHandler(this.nameTile_Click);
            // 
            // nameCUE1
            // 
            this.nameCUE1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            // 
            // 
            // 
            this.nameCUE1.CustomButton.Image = null;
            this.nameCUE1.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.nameCUE1.CustomButton.Name = "";
            this.nameCUE1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameCUE1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameCUE1.CustomButton.TabIndex = 1;
            this.nameCUE1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameCUE1.CustomButton.UseSelectable = true;
            this.nameCUE1.CustomButton.Visible = false;
            this.nameCUE1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.nameCUE1.Lines = new string[0];
            this.nameCUE1.Location = new System.Drawing.Point(92, 115);
            this.nameCUE1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.nameCUE1.MaxLength = 20;
            this.nameCUE1.Name = "nameCUE1";
            this.nameCUE1.PasswordChar = '\0';
            this.nameCUE1.PromptText = "Изделие 1";
            this.nameCUE1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameCUE1.SelectedText = "";
            this.nameCUE1.SelectionLength = 0;
            this.nameCUE1.SelectionStart = 0;
            this.nameCUE1.ShortcutsEnabled = true;
            this.nameCUE1.Size = new System.Drawing.Size(166, 23);
            this.nameCUE1.Style = MetroFramework.MetroColorStyle.Orange;
            this.nameCUE1.TabIndex = 1;
            this.nameCUE1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.nameCUE1, "Введите сюда название изделия\r\nМаксимум 20 символов");
            this.nameCUE1.UseSelectable = true;
            this.nameCUE1.WaterMark = "Изделие 1";
            this.nameCUE1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameCUE1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // delayTile
            // 
            this.delayTile.ActiveControl = null;
            this.delayTile.AutoSize = true;
            this.delayTile.Location = new System.Drawing.Point(365, 73);
            this.delayTile.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.delayTile.Name = "delayTile";
            this.delayTile.Size = new System.Drawing.Size(95, 32);
            this.delayTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.delayTile.TabIndex = 25;
            this.delayTile.Text = "ЗАДЕРЖКА";
            this.delayTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delayTile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.delayTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.delayTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroToolTip1.SetToolTip(this.delayTile, "Очистка ячеек столбца \"Задержка\"");
            this.delayTile.UseMnemonic = false;
            this.delayTile.UseSelectable = true;
            this.delayTile.Click += new System.EventHandler(this.delayTile_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(23, 147);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "CUE #2";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // nameCUE2
            // 
            this.nameCUE2.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            // 
            // 
            // 
            this.nameCUE2.CustomButton.Image = null;
            this.nameCUE2.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.nameCUE2.CustomButton.Name = "";
            this.nameCUE2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameCUE2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameCUE2.CustomButton.TabIndex = 1;
            this.nameCUE2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameCUE2.CustomButton.UseSelectable = true;
            this.nameCUE2.CustomButton.Visible = false;
            this.nameCUE2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.nameCUE2.Lines = new string[0];
            this.nameCUE2.Location = new System.Drawing.Point(92, 143);
            this.nameCUE2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.nameCUE2.MaxLength = 20;
            this.nameCUE2.Name = "nameCUE2";
            this.nameCUE2.PasswordChar = '\0';
            this.nameCUE2.PromptText = "Изделие 2";
            this.nameCUE2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameCUE2.SelectedText = "";
            this.nameCUE2.SelectionLength = 0;
            this.nameCUE2.SelectionStart = 0;
            this.nameCUE2.ShortcutsEnabled = true;
            this.nameCUE2.Size = new System.Drawing.Size(166, 23);
            this.nameCUE2.Style = MetroFramework.MetroColorStyle.Orange;
            this.nameCUE2.TabIndex = 2;
            this.nameCUE2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.nameCUE2, "Введите сюда название изделия\r\nМаксимум 20 символов");
            this.nameCUE2.UseSelectable = true;
            this.nameCUE2.WaterMark = "Изделие 2";
            this.nameCUE2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameCUE2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nameCUE3
            // 
            this.nameCUE3.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            // 
            // 
            // 
            this.nameCUE3.CustomButton.Image = null;
            this.nameCUE3.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.nameCUE3.CustomButton.Name = "";
            this.nameCUE3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameCUE3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameCUE3.CustomButton.TabIndex = 1;
            this.nameCUE3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameCUE3.CustomButton.UseSelectable = true;
            this.nameCUE3.CustomButton.Visible = false;
            this.nameCUE3.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.nameCUE3.Lines = new string[0];
            this.nameCUE3.Location = new System.Drawing.Point(92, 171);
            this.nameCUE3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.nameCUE3.MaxLength = 20;
            this.nameCUE3.Name = "nameCUE3";
            this.nameCUE3.PasswordChar = '\0';
            this.nameCUE3.PromptText = "Изделие 3";
            this.nameCUE3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameCUE3.SelectedText = "";
            this.nameCUE3.SelectionLength = 0;
            this.nameCUE3.SelectionStart = 0;
            this.nameCUE3.ShortcutsEnabled = true;
            this.nameCUE3.Size = new System.Drawing.Size(166, 23);
            this.nameCUE3.Style = MetroFramework.MetroColorStyle.Orange;
            this.nameCUE3.TabIndex = 3;
            this.nameCUE3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.nameCUE3, "Введите сюда название изделия\r\nМаксимум 20 символов");
            this.nameCUE3.UseSelectable = true;
            this.nameCUE3.WaterMark = "Изделие 3";
            this.nameCUE3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameCUE3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nameCUE4
            // 
            this.nameCUE4.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            // 
            // 
            // 
            this.nameCUE4.CustomButton.Image = null;
            this.nameCUE4.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.nameCUE4.CustomButton.Name = "";
            this.nameCUE4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameCUE4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameCUE4.CustomButton.TabIndex = 1;
            this.nameCUE4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameCUE4.CustomButton.UseSelectable = true;
            this.nameCUE4.CustomButton.Visible = false;
            this.nameCUE4.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.nameCUE4.Lines = new string[0];
            this.nameCUE4.Location = new System.Drawing.Point(92, 199);
            this.nameCUE4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.nameCUE4.MaxLength = 20;
            this.nameCUE4.Name = "nameCUE4";
            this.nameCUE4.PasswordChar = '\0';
            this.nameCUE4.PromptText = "Изделие 4";
            this.nameCUE4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameCUE4.SelectedText = "";
            this.nameCUE4.SelectionLength = 0;
            this.nameCUE4.SelectionStart = 0;
            this.nameCUE4.ShortcutsEnabled = true;
            this.nameCUE4.Size = new System.Drawing.Size(166, 23);
            this.nameCUE4.Style = MetroFramework.MetroColorStyle.Orange;
            this.nameCUE4.TabIndex = 4;
            this.nameCUE4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.nameCUE4, "Введите сюда название изделия\r\nМаксимум 20 символов");
            this.nameCUE4.UseSelectable = true;
            this.nameCUE4.WaterMark = "Изделие 4";
            this.nameCUE4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameCUE4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nameCUE5
            // 
            this.nameCUE5.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            // 
            // 
            // 
            this.nameCUE5.CustomButton.Image = null;
            this.nameCUE5.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.nameCUE5.CustomButton.Name = "";
            this.nameCUE5.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameCUE5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameCUE5.CustomButton.TabIndex = 1;
            this.nameCUE5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameCUE5.CustomButton.UseSelectable = true;
            this.nameCUE5.CustomButton.Visible = false;
            this.nameCUE5.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.nameCUE5.Lines = new string[0];
            this.nameCUE5.Location = new System.Drawing.Point(92, 227);
            this.nameCUE5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.nameCUE5.MaxLength = 20;
            this.nameCUE5.Name = "nameCUE5";
            this.nameCUE5.PasswordChar = '\0';
            this.nameCUE5.PromptText = "Изделие 5";
            this.nameCUE5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameCUE5.SelectedText = "";
            this.nameCUE5.SelectionLength = 0;
            this.nameCUE5.SelectionStart = 0;
            this.nameCUE5.ShortcutsEnabled = true;
            this.nameCUE5.Size = new System.Drawing.Size(166, 23);
            this.nameCUE5.Style = MetroFramework.MetroColorStyle.Orange;
            this.nameCUE5.TabIndex = 5;
            this.nameCUE5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.nameCUE5, "Введите сюда название изделия\r\nМаксимум 20 символов");
            this.nameCUE5.UseSelectable = true;
            this.nameCUE5.WaterMark = "Изделие 5";
            this.nameCUE5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameCUE5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nameCUE6
            // 
            this.nameCUE6.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            // 
            // 
            // 
            this.nameCUE6.CustomButton.Image = null;
            this.nameCUE6.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.nameCUE6.CustomButton.Name = "";
            this.nameCUE6.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameCUE6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameCUE6.CustomButton.TabIndex = 1;
            this.nameCUE6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameCUE6.CustomButton.UseSelectable = true;
            this.nameCUE6.CustomButton.Visible = false;
            this.nameCUE6.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.nameCUE6.Lines = new string[0];
            this.nameCUE6.Location = new System.Drawing.Point(92, 255);
            this.nameCUE6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.nameCUE6.MaxLength = 20;
            this.nameCUE6.Name = "nameCUE6";
            this.nameCUE6.PasswordChar = '\0';
            this.nameCUE6.PromptText = "Изделие 6";
            this.nameCUE6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameCUE6.SelectedText = "";
            this.nameCUE6.SelectionLength = 0;
            this.nameCUE6.SelectionStart = 0;
            this.nameCUE6.ShortcutsEnabled = true;
            this.nameCUE6.Size = new System.Drawing.Size(166, 23);
            this.nameCUE6.Style = MetroFramework.MetroColorStyle.Orange;
            this.nameCUE6.TabIndex = 6;
            this.nameCUE6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.nameCUE6, "Введите сюда название изделия\r\nМаксимум 20 символов");
            this.nameCUE6.UseSelectable = true;
            this.nameCUE6.WaterMark = "Изделие 6";
            this.nameCUE6.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameCUE6.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(23, 175);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "CUE #3";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(23, 203);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(55, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "CUE #4";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(23, 231);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(55, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "CUE #5";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(23, 259);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(55, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "CUE #6";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // delayCUE1
            // 
            // 
            // 
            // 
            this.delayCUE1.CustomButton.Image = null;
            this.delayCUE1.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.delayCUE1.CustomButton.Name = "";
            this.delayCUE1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.delayCUE1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.delayCUE1.CustomButton.TabIndex = 1;
            this.delayCUE1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.delayCUE1.CustomButton.UseSelectable = true;
            this.delayCUE1.CustomButton.Visible = false;
            this.delayCUE1.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.delayCUE1.Lines = new string[0];
            this.delayCUE1.Location = new System.Drawing.Point(365, 113);
            this.delayCUE1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.delayCUE1.MaxLength = 2;
            this.delayCUE1.Name = "delayCUE1";
            this.delayCUE1.PasswordChar = '\0';
            this.delayCUE1.PromptText = "0";
            this.delayCUE1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.delayCUE1.SelectedText = "";
            this.delayCUE1.SelectionLength = 0;
            this.delayCUE1.SelectionStart = 0;
            this.delayCUE1.ShortcutsEnabled = true;
            this.delayCUE1.Size = new System.Drawing.Size(95, 23);
            this.delayCUE1.Style = MetroFramework.MetroColorStyle.Orange;
            this.delayCUE1.TabIndex = 13;
            this.delayCUE1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delayCUE1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.delayCUE1, "Введите сюда время задержки\r\nв секундах после запуска CUE#1.\r\nМаксимум 2 цифры.\r\n" +
        "");
            this.delayCUE1.UseSelectable = true;
            this.delayCUE1.WaterMark = "0";
            this.delayCUE1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.delayCUE1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.delayCUE1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber_KeyPress);
            // 
            // delayCUE2
            // 
            // 
            // 
            // 
            this.delayCUE2.CustomButton.Image = null;
            this.delayCUE2.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.delayCUE2.CustomButton.Name = "";
            this.delayCUE2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.delayCUE2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.delayCUE2.CustomButton.TabIndex = 1;
            this.delayCUE2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.delayCUE2.CustomButton.UseSelectable = true;
            this.delayCUE2.CustomButton.Visible = false;
            this.delayCUE2.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.delayCUE2.Lines = new string[0];
            this.delayCUE2.Location = new System.Drawing.Point(365, 141);
            this.delayCUE2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.delayCUE2.MaxLength = 2;
            this.delayCUE2.Name = "delayCUE2";
            this.delayCUE2.PasswordChar = '\0';
            this.delayCUE2.PromptText = "0";
            this.delayCUE2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.delayCUE2.SelectedText = "";
            this.delayCUE2.SelectionLength = 0;
            this.delayCUE2.SelectionStart = 0;
            this.delayCUE2.ShortcutsEnabled = true;
            this.delayCUE2.Size = new System.Drawing.Size(95, 23);
            this.delayCUE2.Style = MetroFramework.MetroColorStyle.Orange;
            this.delayCUE2.TabIndex = 14;
            this.delayCUE2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delayCUE2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.delayCUE2, "Введите сюда время задержки\r\nв секундах после запуска CUE#2.\r\nМаксимум 2 цифры.\r\n" +
        "По умолчанию 0.");
            this.delayCUE2.UseSelectable = true;
            this.delayCUE2.WaterMark = "0";
            this.delayCUE2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.delayCUE2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.delayCUE2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber_KeyPress);
            // 
            // delayCUE3
            // 
            // 
            // 
            // 
            this.delayCUE3.CustomButton.Image = null;
            this.delayCUE3.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.delayCUE3.CustomButton.Name = "";
            this.delayCUE3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.delayCUE3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.delayCUE3.CustomButton.TabIndex = 1;
            this.delayCUE3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.delayCUE3.CustomButton.UseSelectable = true;
            this.delayCUE3.CustomButton.Visible = false;
            this.delayCUE3.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.delayCUE3.Lines = new string[0];
            this.delayCUE3.Location = new System.Drawing.Point(365, 169);
            this.delayCUE3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.delayCUE3.MaxLength = 2;
            this.delayCUE3.Name = "delayCUE3";
            this.delayCUE3.PasswordChar = '\0';
            this.delayCUE3.PromptText = "0";
            this.delayCUE3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.delayCUE3.SelectedText = "";
            this.delayCUE3.SelectionLength = 0;
            this.delayCUE3.SelectionStart = 0;
            this.delayCUE3.ShortcutsEnabled = true;
            this.delayCUE3.Size = new System.Drawing.Size(95, 23);
            this.delayCUE3.Style = MetroFramework.MetroColorStyle.Orange;
            this.delayCUE3.TabIndex = 15;
            this.delayCUE3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delayCUE3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.delayCUE3, "Введите сюда время задержки\r\nв секундах после запуска CUE#3.\r\nМаксимум 2 цифры.\r\n" +
        "По умолчанию 0.");
            this.delayCUE3.UseSelectable = true;
            this.delayCUE3.WaterMark = "0";
            this.delayCUE3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.delayCUE3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.delayCUE3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber_KeyPress);
            // 
            // delayCUE4
            // 
            // 
            // 
            // 
            this.delayCUE4.CustomButton.Image = null;
            this.delayCUE4.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.delayCUE4.CustomButton.Name = "";
            this.delayCUE4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.delayCUE4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.delayCUE4.CustomButton.TabIndex = 1;
            this.delayCUE4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.delayCUE4.CustomButton.UseSelectable = true;
            this.delayCUE4.CustomButton.Visible = false;
            this.delayCUE4.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.delayCUE4.Lines = new string[0];
            this.delayCUE4.Location = new System.Drawing.Point(365, 197);
            this.delayCUE4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.delayCUE4.MaxLength = 2;
            this.delayCUE4.Name = "delayCUE4";
            this.delayCUE4.PasswordChar = '\0';
            this.delayCUE4.PromptText = "0";
            this.delayCUE4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.delayCUE4.SelectedText = "";
            this.delayCUE4.SelectionLength = 0;
            this.delayCUE4.SelectionStart = 0;
            this.delayCUE4.ShortcutsEnabled = true;
            this.delayCUE4.Size = new System.Drawing.Size(95, 23);
            this.delayCUE4.Style = MetroFramework.MetroColorStyle.Orange;
            this.delayCUE4.TabIndex = 16;
            this.delayCUE4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delayCUE4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.delayCUE4, "Введите сюда время задержки\r\nв секундах после запуска CUE#4.\r\nМаксимум 2 цифры.\r\n" +
        "По умолчанию 0.");
            this.delayCUE4.UseSelectable = true;
            this.delayCUE4.WaterMark = "0";
            this.delayCUE4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.delayCUE4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.delayCUE4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber_KeyPress);
            // 
            // delayCUE5
            // 
            // 
            // 
            // 
            this.delayCUE5.CustomButton.Image = null;
            this.delayCUE5.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.delayCUE5.CustomButton.Name = "";
            this.delayCUE5.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.delayCUE5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.delayCUE5.CustomButton.TabIndex = 1;
            this.delayCUE5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.delayCUE5.CustomButton.UseSelectable = true;
            this.delayCUE5.CustomButton.Visible = false;
            this.delayCUE5.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.delayCUE5.Lines = new string[0];
            this.delayCUE5.Location = new System.Drawing.Point(365, 225);
            this.delayCUE5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.delayCUE5.MaxLength = 2;
            this.delayCUE5.Name = "delayCUE5";
            this.delayCUE5.PasswordChar = '\0';
            this.delayCUE5.PromptText = "0";
            this.delayCUE5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.delayCUE5.SelectedText = "";
            this.delayCUE5.SelectionLength = 0;
            this.delayCUE5.SelectionStart = 0;
            this.delayCUE5.ShortcutsEnabled = true;
            this.delayCUE5.Size = new System.Drawing.Size(95, 23);
            this.delayCUE5.Style = MetroFramework.MetroColorStyle.Orange;
            this.delayCUE5.TabIndex = 17;
            this.delayCUE5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delayCUE5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.delayCUE5, "Введите сюда время задержки\r\nв секундах после запуска CUE#5.\r\nМаксимум 2 цифры.\r\n" +
        "По умолчанию 0.");
            this.delayCUE5.UseSelectable = true;
            this.delayCUE5.WaterMark = "0";
            this.delayCUE5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.delayCUE5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.delayCUE5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber_KeyPress);
            // 
            // timeCUE6
            // 
            // 
            // 
            // 
            this.timeCUE6.CustomButton.Image = null;
            this.timeCUE6.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.timeCUE6.CustomButton.Name = "";
            this.timeCUE6.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.timeCUE6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.timeCUE6.CustomButton.TabIndex = 1;
            this.timeCUE6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.timeCUE6.CustomButton.UseSelectable = true;
            this.timeCUE6.CustomButton.Visible = false;
            this.timeCUE6.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.timeCUE6.Lines = new string[0];
            this.timeCUE6.Location = new System.Drawing.Point(264, 253);
            this.timeCUE6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.timeCUE6.MaxLength = 2;
            this.timeCUE6.Name = "timeCUE6";
            this.timeCUE6.PasswordChar = '\0';
            this.timeCUE6.PromptText = "0";
            this.timeCUE6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.timeCUE6.SelectedText = "";
            this.timeCUE6.SelectionLength = 0;
            this.timeCUE6.SelectionStart = 0;
            this.timeCUE6.ShortcutsEnabled = true;
            this.timeCUE6.Size = new System.Drawing.Size(95, 23);
            this.timeCUE6.Style = MetroFramework.MetroColorStyle.Orange;
            this.timeCUE6.TabIndex = 12;
            this.timeCUE6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeCUE6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.timeCUE6, "Введите сюда время работы изделия\r\nв секундах.\r\nЦелое число 0-99");
            this.timeCUE6.UseSelectable = true;
            this.timeCUE6.WaterMark = "0";
            this.timeCUE6.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.timeCUE6.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.timeCUE6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber_KeyPress);
            // 
            // timeCUE5
            // 
            // 
            // 
            // 
            this.timeCUE5.CustomButton.Image = null;
            this.timeCUE5.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.timeCUE5.CustomButton.Name = "";
            this.timeCUE5.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.timeCUE5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.timeCUE5.CustomButton.TabIndex = 1;
            this.timeCUE5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.timeCUE5.CustomButton.UseSelectable = true;
            this.timeCUE5.CustomButton.Visible = false;
            this.timeCUE5.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.timeCUE5.Lines = new string[0];
            this.timeCUE5.Location = new System.Drawing.Point(264, 225);
            this.timeCUE5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.timeCUE5.MaxLength = 2;
            this.timeCUE5.Name = "timeCUE5";
            this.timeCUE5.PasswordChar = '\0';
            this.timeCUE5.PromptText = "0";
            this.timeCUE5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.timeCUE5.SelectedText = "";
            this.timeCUE5.SelectionLength = 0;
            this.timeCUE5.SelectionStart = 0;
            this.timeCUE5.ShortcutsEnabled = true;
            this.timeCUE5.Size = new System.Drawing.Size(95, 23);
            this.timeCUE5.Style = MetroFramework.MetroColorStyle.Orange;
            this.timeCUE5.TabIndex = 11;
            this.timeCUE5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeCUE5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.timeCUE5, "Введите сюда время работы изделия\r\nв секундах.\r\nЦелое число 0-99");
            this.timeCUE5.UseSelectable = true;
            this.timeCUE5.WaterMark = "0";
            this.timeCUE5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.timeCUE5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.timeCUE5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber_KeyPress);
            // 
            // timeTile
            // 
            this.timeTile.ActiveControl = null;
            this.timeTile.AutoSize = true;
            this.timeTile.Location = new System.Drawing.Point(264, 73);
            this.timeTile.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.timeTile.Name = "timeTile";
            this.timeTile.Size = new System.Drawing.Size(95, 32);
            this.timeTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.timeTile.TabIndex = 24;
            this.timeTile.Text = "ВРЕМЯ";
            this.timeTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeTile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.timeTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.timeTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroToolTip1.SetToolTip(this.timeTile, "Очистка ячеек столбца \"Время\"");
            this.timeTile.UseMnemonic = false;
            this.timeTile.UseSelectable = true;
            this.timeTile.Click += new System.EventHandler(this.timeTile_Click);
            // 
            // timeCUE4
            // 
            // 
            // 
            // 
            this.timeCUE4.CustomButton.Image = null;
            this.timeCUE4.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.timeCUE4.CustomButton.Name = "";
            this.timeCUE4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.timeCUE4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.timeCUE4.CustomButton.TabIndex = 1;
            this.timeCUE4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.timeCUE4.CustomButton.UseSelectable = true;
            this.timeCUE4.CustomButton.Visible = false;
            this.timeCUE4.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.timeCUE4.Lines = new string[0];
            this.timeCUE4.Location = new System.Drawing.Point(264, 197);
            this.timeCUE4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.timeCUE4.MaxLength = 2;
            this.timeCUE4.Name = "timeCUE4";
            this.timeCUE4.PasswordChar = '\0';
            this.timeCUE4.PromptText = "0";
            this.timeCUE4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.timeCUE4.SelectedText = "";
            this.timeCUE4.SelectionLength = 0;
            this.timeCUE4.SelectionStart = 0;
            this.timeCUE4.ShortcutsEnabled = true;
            this.timeCUE4.Size = new System.Drawing.Size(95, 23);
            this.timeCUE4.Style = MetroFramework.MetroColorStyle.Orange;
            this.timeCUE4.TabIndex = 10;
            this.timeCUE4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeCUE4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.timeCUE4, "Введите сюда время работы изделия\r\nв секундах.\r\nЦелое число 0-99");
            this.timeCUE4.UseSelectable = true;
            this.timeCUE4.WaterMark = "0";
            this.timeCUE4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.timeCUE4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.timeCUE4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber_KeyPress);
            // 
            // timeCUE1
            // 
            // 
            // 
            // 
            this.timeCUE1.CustomButton.Image = null;
            this.timeCUE1.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.timeCUE1.CustomButton.Name = "";
            this.timeCUE1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.timeCUE1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.timeCUE1.CustomButton.TabIndex = 1;
            this.timeCUE1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.timeCUE1.CustomButton.UseSelectable = true;
            this.timeCUE1.CustomButton.Visible = false;
            this.timeCUE1.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.timeCUE1.Lines = new string[0];
            this.timeCUE1.Location = new System.Drawing.Point(264, 113);
            this.timeCUE1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.timeCUE1.MaxLength = 2;
            this.timeCUE1.Name = "timeCUE1";
            this.timeCUE1.PasswordChar = '\0';
            this.timeCUE1.PromptText = "0";
            this.timeCUE1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.timeCUE1.SelectedText = "";
            this.timeCUE1.SelectionLength = 0;
            this.timeCUE1.SelectionStart = 0;
            this.timeCUE1.ShortcutsEnabled = true;
            this.timeCUE1.Size = new System.Drawing.Size(95, 23);
            this.timeCUE1.Style = MetroFramework.MetroColorStyle.Orange;
            this.timeCUE1.TabIndex = 7;
            this.timeCUE1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeCUE1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.timeCUE1, "Введите сюда время работы изделия\r\nв секундах.\r\nЦелое число 0-99");
            this.timeCUE1.UseSelectable = true;
            this.timeCUE1.WaterMark = "0";
            this.timeCUE1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.timeCUE1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.timeCUE1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber_KeyPress);
            // 
            // timeCUE3
            // 
            // 
            // 
            // 
            this.timeCUE3.CustomButton.Image = null;
            this.timeCUE3.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.timeCUE3.CustomButton.Name = "";
            this.timeCUE3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.timeCUE3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.timeCUE3.CustomButton.TabIndex = 1;
            this.timeCUE3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.timeCUE3.CustomButton.UseSelectable = true;
            this.timeCUE3.CustomButton.Visible = false;
            this.timeCUE3.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.timeCUE3.Lines = new string[0];
            this.timeCUE3.Location = new System.Drawing.Point(264, 169);
            this.timeCUE3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.timeCUE3.MaxLength = 2;
            this.timeCUE3.Name = "timeCUE3";
            this.timeCUE3.PasswordChar = '\0';
            this.timeCUE3.PromptText = "0";
            this.timeCUE3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.timeCUE3.SelectedText = "";
            this.timeCUE3.SelectionLength = 0;
            this.timeCUE3.SelectionStart = 0;
            this.timeCUE3.ShortcutsEnabled = true;
            this.timeCUE3.Size = new System.Drawing.Size(95, 23);
            this.timeCUE3.Style = MetroFramework.MetroColorStyle.Orange;
            this.timeCUE3.TabIndex = 9;
            this.timeCUE3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeCUE3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.timeCUE3, "Введите сюда время работы изделия\r\nв секундах.\r\nЦелое число 0-99");
            this.timeCUE3.UseSelectable = true;
            this.timeCUE3.WaterMark = "0";
            this.timeCUE3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.timeCUE3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.timeCUE3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber_KeyPress);
            // 
            // timeCUE2
            // 
            // 
            // 
            // 
            this.timeCUE2.CustomButton.Image = null;
            this.timeCUE2.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.timeCUE2.CustomButton.Name = "";
            this.timeCUE2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.timeCUE2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.timeCUE2.CustomButton.TabIndex = 1;
            this.timeCUE2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.timeCUE2.CustomButton.UseSelectable = true;
            this.timeCUE2.CustomButton.Visible = false;
            this.timeCUE2.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.timeCUE2.Lines = new string[0];
            this.timeCUE2.Location = new System.Drawing.Point(264, 141);
            this.timeCUE2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.timeCUE2.MaxLength = 2;
            this.timeCUE2.Name = "timeCUE2";
            this.timeCUE2.PasswordChar = '\0';
            this.timeCUE2.PromptText = "0";
            this.timeCUE2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.timeCUE2.SelectedText = "";
            this.timeCUE2.SelectionLength = 0;
            this.timeCUE2.SelectionStart = 0;
            this.timeCUE2.ShortcutsEnabled = true;
            this.timeCUE2.Size = new System.Drawing.Size(95, 23);
            this.timeCUE2.Style = MetroFramework.MetroColorStyle.Orange;
            this.timeCUE2.TabIndex = 8;
            this.timeCUE2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeCUE2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.timeCUE2, "Введите сюда время работы изделия\r\nв секундах.\r\nЦелое число 0-99");
            this.timeCUE2.UseSelectable = true;
            this.timeCUE2.WaterMark = "0";
            this.timeCUE2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.timeCUE2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.timeCUE2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber_KeyPress);
            // 
            // portsBox
            // 
            this.portsBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.portsBox.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.portsBox.FormattingEnabled = true;
            this.portsBox.ItemHeight = 19;
            this.portsBox.Location = new System.Drawing.Point(471, 73);
            this.portsBox.Name = "portsBox";
            this.portsBox.Size = new System.Drawing.Size(75, 25);
            this.portsBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.portsBox.TabIndex = 18;
            this.portsBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.portsBox, "Выберите из списка порт,\r\nкоторый использует пульт");
            this.portsBox.UseSelectable = true;
            this.portsBox.Click += new System.EventHandler(this.PortsRescan_Click);
            // 
            // saveLink
            // 
            this.saveLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.saveLink.Location = new System.Drawing.Point(471, 113);
            this.saveLink.Name = "saveLink";
            this.saveLink.Size = new System.Drawing.Size(86, 23);
            this.saveLink.Style = MetroFramework.MetroColorStyle.Orange;
            this.saveLink.TabIndex = 19;
            this.saveLink.TabStop = false;
            this.saveLink.Text = "&Сохранить";
            this.saveLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveLink.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.saveLink, "Сохраненить сценарий\r\nAlt+С (рус.)");
            this.saveLink.UseSelectable = true;
            this.saveLink.Click += new System.EventHandler(this.saveLink_Click);
            // 
            // openLink
            // 
            this.openLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.openLink.Location = new System.Drawing.Point(471, 141);
            this.openLink.Name = "openLink";
            this.openLink.Size = new System.Drawing.Size(75, 23);
            this.openLink.Style = MetroFramework.MetroColorStyle.Orange;
            this.openLink.TabIndex = 20;
            this.openLink.TabStop = false;
            this.openLink.Text = "&Открыть";
            this.openLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openLink.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.openLink, "Открыть сценарий\r\nAlt+О (рус.)");
            this.openLink.UseSelectable = true;
            this.openLink.Click += new System.EventHandler(this.openLink_Click);
            // 
            // memoLink
            // 
            this.memoLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.memoLink.Location = new System.Drawing.Point(471, 197);
            this.memoLink.Name = "memoLink";
            this.memoLink.Size = new System.Drawing.Size(75, 23);
            this.memoLink.Style = MetroFramework.MetroColorStyle.Orange;
            this.memoLink.TabIndex = 22;
            this.memoLink.TabStop = false;
            this.memoLink.Text = "&Памятка";
            this.memoLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.memoLink.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.memoLink, "Создание картинки-памятки\r\nAlt+П (рус.)");
            this.memoLink.UseSelectable = true;
            this.memoLink.Click += new System.EventHandler(this.memoLink_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(23, 293);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(3, 10, 0, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(101, 15);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel7.TabIndex = 29;
            this.metroLabel7.Text = "Copyright © 2017";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // serialP
            // 
            this.serialP.ReadBufferSize = 2;
            this.serialP.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialP_DataReceived);
            // 
            // downloadLink
            // 
            this.downloadLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.downloadLink.Location = new System.Drawing.Point(471, 169);
            this.downloadLink.Name = "downloadLink";
            this.downloadLink.Size = new System.Drawing.Size(83, 23);
            this.downloadLink.Style = MetroFramework.MetroColorStyle.Orange;
            this.downloadLink.TabIndex = 21;
            this.downloadLink.TabStop = false;
            this.downloadLink.Text = "&Загрузить";
            this.downloadLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.downloadLink.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.downloadLink, "Загрузка сценария в пульт\r\nAlt+З (рус.)");
            this.downloadLink.UseSelectable = true;
            this.downloadLink.Click += new System.EventHandler(this.downloadLink_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.AutoPopDelay = 3000;
            this.metroToolTip1.InitialDelay = 500;
            this.metroToolTip1.ReshowDelay = 500;
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // youtubeLink
            // 
            this.youtubeLink.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.youtubeLink.ForeColor = System.Drawing.Color.Blue;
            this.youtubeLink.Location = new System.Drawing.Point(121, 293);
            this.youtubeLink.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.youtubeLink.Name = "youtubeLink";
            this.youtubeLink.Size = new System.Drawing.Size(95, 15);
            this.youtubeLink.TabIndex = 503;
            this.youtubeLink.Text = "S-LAB YouTube";
            this.youtubeLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroToolTip1.SetToolTip(this.youtubeLink, "Ссылка на YouTube канал\r\nhttps://www.youtube.com/c/SLABORATORY");
            this.youtubeLink.UseSelectable = true;
            this.youtubeLink.Click += new System.EventHandler(this.youtubeLink_Click);
            // 
            // donateLink
            // 
            this.donateLink.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.donateLink.ForeColor = System.Drawing.Color.Blue;
            this.donateLink.Location = new System.Drawing.Point(264, 293);
            this.donateLink.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.donateLink.Name = "donateLink";
            this.donateLink.Size = new System.Drawing.Size(95, 15);
            this.donateLink.TabIndex = 504;
            this.donateLink.Text = "Поддержать :-)";
            this.donateLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroToolTip1.SetToolTip(this.donateLink, "Откроется файл \"Promote.txt\"\r\nсо способами денежной поддержки канала");
            this.donateLink.UseSelectable = true;
            this.donateLink.Click += new System.EventHandler(this.donateLink_Click);
            // 
            // aboutLink
            // 
            this.aboutLink.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.aboutLink.ForeColor = System.Drawing.Color.Blue;
            this.aboutLink.Location = new System.Drawing.Point(365, 293);
            this.aboutLink.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.aboutLink.Name = "aboutLink";
            this.aboutLink.Size = new System.Drawing.Size(95, 15);
            this.aboutLink.TabIndex = 505;
            this.aboutLink.Text = "О программе";
            this.aboutLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroToolTip1.SetToolTip(this.aboutLink, "Информационное окно с информацией о программе");
            this.aboutLink.UseSelectable = true;
            this.aboutLink.Click += new System.EventHandler(this.aboutLink_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // PyroMakerShow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(580, 331);
            this.Controls.Add(this.aboutLink);
            this.Controls.Add(this.donateLink);
            this.Controls.Add(this.youtubeLink);
            this.Controls.Add(this.downloadLink);
            this.Controls.Add(this.timeCUE6);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.timeCUE5);
            this.Controls.Add(this.memoLink);
            this.Controls.Add(this.timeTile);
            this.Controls.Add(this.timeCUE4);
            this.Controls.Add(this.openLink);
            this.Controls.Add(this.timeCUE1);
            this.Controls.Add(this.saveLink);
            this.Controls.Add(this.timeCUE3);
            this.Controls.Add(this.portsBox);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.timeCUE2);
            this.Controls.Add(this.nameTile);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.nameCUE1);
            this.Controls.Add(this.delayCUE5);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.delayTile);
            this.Controls.Add(this.nameCUE2);
            this.Controls.Add(this.nameCUE6);
            this.Controls.Add(this.delayCUE2);
            this.Controls.Add(this.delayCUE4);
            this.Controls.Add(this.nameCUE3);
            this.Controls.Add(this.nameCUE5);
            this.Controls.Add(this.delayCUE3);
            this.Controls.Add(this.delayCUE1);
            this.Controls.Add(this.nameCUE4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PyroMakerShow";
            this.Padding = new System.Windows.Forms.Padding(20, 70, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Pyro Maker Show";
            this.Load += new System.EventHandler(this.PyroMaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile nameTile;
        private MetroFramework.Controls.MetroTextBox nameCUE1;
        private MetroFramework.Controls.MetroTile delayTile;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox nameCUE2;
        private MetroFramework.Controls.MetroTextBox nameCUE3;
        private MetroFramework.Controls.MetroTextBox nameCUE4;
        private MetroFramework.Controls.MetroTextBox nameCUE5;
        private MetroFramework.Controls.MetroTextBox nameCUE6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox delayCUE1;
        private MetroFramework.Controls.MetroTextBox delayCUE2;
        private MetroFramework.Controls.MetroTextBox delayCUE3;
        private MetroFramework.Controls.MetroTextBox delayCUE4;
        private MetroFramework.Controls.MetroTextBox delayCUE5;
        private MetroFramework.Controls.MetroComboBox portsBox;
        private MetroFramework.Controls.MetroLink saveLink;
        private MetroFramework.Controls.MetroLink openLink;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private MetroFramework.Controls.MetroLink memoLink;
        private MetroFramework.Controls.MetroTextBox timeCUE6;
        private MetroFramework.Controls.MetroTextBox timeCUE5;
        private MetroFramework.Controls.MetroTile timeTile;
        private MetroFramework.Controls.MetroTextBox timeCUE4;
        private MetroFramework.Controls.MetroTextBox timeCUE1;
        private MetroFramework.Controls.MetroTextBox timeCUE3;
        private MetroFramework.Controls.MetroTextBox timeCUE2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.IO.Ports.SerialPort serialP;
        private MetroFramework.Controls.MetroLink downloadLink;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLink youtubeLink;
        private MetroFramework.Controls.MetroLink donateLink;
        private MetroFramework.Controls.MetroLink aboutLink;
    }
}

