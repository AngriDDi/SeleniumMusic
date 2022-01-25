namespace SeleniumNaverTestApp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.LogBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(9, 54);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(116, 59);
            this.metroTile1.TabIndex = 5;
            this.metroTile1.Text = "Start";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.Start_Click);
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(131, 98);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(52, 15);
            this.metroRadioButton1.TabIndex = 6;
            this.metroRadioButton1.Text = "Show";
            this.metroRadioButton1.UseSelectable = true;
            // 
            // LogBox
            // 
            // 
            // 
            // 
            this.LogBox.CustomButton.Image = null;
            this.LogBox.CustomButton.Location = new System.Drawing.Point(-36, 2);
            this.LogBox.CustomButton.Name = "";
            this.LogBox.CustomButton.Size = new System.Drawing.Size(361, 361);
            this.LogBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LogBox.CustomButton.TabIndex = 1;
            this.LogBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LogBox.CustomButton.UseSelectable = true;
            this.LogBox.CustomButton.Visible = false;
            this.LogBox.Lines = new string[0];
            this.LogBox.Location = new System.Drawing.Point(9, 128);
            this.LogBox.MaxLength = 32767;
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.PasswordChar = '\0';
            this.LogBox.ReadOnly = true;
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogBox.SelectedText = "";
            this.LogBox.SelectionLength = 0;
            this.LogBox.SelectionStart = 0;
            this.LogBox.ShortcutsEnabled = true;
            this.LogBox.Size = new System.Drawing.Size(328, 366);
            this.LogBox.TabIndex = 7;
            this.LogBox.UseSelectable = true;
            this.LogBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LogBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.metroLabel1.Location = new System.Drawing.Point(9, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "대백마트";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 503);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.metroTile1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroTextBox LogBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

