namespace NDP_PROJE_ODEVI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureGroupBox = new System.Windows.Forms.GroupBox();
            this.atikPictureBox = new System.Windows.Forms.PictureBox();
            this.sureVePuanGroupBox = new System.Windows.Forms.GroupBox();
            this.puanLabel = new System.Windows.Forms.Label();
            this.puan2Label = new System.Windows.Forms.Label();
            this.sureLabel = new System.Windows.Forms.Label();
            this.sure2Label = new System.Windows.Forms.Label();
            this.cikisButton = new System.Windows.Forms.Button();
            this.yeniOyunButton = new System.Windows.Forms.Button();
            this.baslikLabel = new System.Windows.Forms.Label();
            this.organikAtikPanel = new System.Windows.Forms.Panel();
            this.organikAtikProgressBar = new System.Windows.Forms.ProgressBar();
            this.organikAtikListBox = new System.Windows.Forms.ListBox();
            this.organikAtikBosaltButton = new System.Windows.Forms.Button();
            this.organikAtikButton = new System.Windows.Forms.Button();
            this.kagitAtikPanel = new System.Windows.Forms.Panel();
            this.kagitAtikProgressBar = new System.Windows.Forms.ProgressBar();
            this.kagitAtikListBox = new System.Windows.Forms.ListBox();
            this.kagitBosaltButton = new System.Windows.Forms.Button();
            this.kagitButton = new System.Windows.Forms.Button();
            this.camAtikPanel = new System.Windows.Forms.Panel();
            this.camAtikProgressBar = new System.Windows.Forms.ProgressBar();
            this.camAtikListBox = new System.Windows.Forms.ListBox();
            this.camBosaltButton = new System.Windows.Forms.Button();
            this.camButton = new System.Windows.Forms.Button();
            this.metalAtikPanel = new System.Windows.Forms.Panel();
            this.metalAtikProgressBar = new System.Windows.Forms.ProgressBar();
            this.metalAtikListBox = new System.Windows.Forms.ListBox();
            this.metalBosaltButton = new System.Windows.Forms.Button();
            this.metalButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atikPictureBox)).BeginInit();
            this.sureVePuanGroupBox.SuspendLayout();
            this.organikAtikPanel.SuspendLayout();
            this.kagitAtikPanel.SuspendLayout();
            this.camAtikPanel.SuspendLayout();
            this.metalAtikPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureGroupBox
            // 
            this.pictureGroupBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.pictureGroupBox.Controls.Add(this.atikPictureBox);
            this.pictureGroupBox.Location = new System.Drawing.Point(22, 23);
            this.pictureGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureGroupBox.Name = "pictureGroupBox";
            this.pictureGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureGroupBox.Size = new System.Drawing.Size(202, 190);
            this.pictureGroupBox.TabIndex = 0;
            this.pictureGroupBox.TabStop = false;
            // 
            // atikPictureBox
            // 
            this.atikPictureBox.BackColor = System.Drawing.Color.White;
            this.atikPictureBox.Location = new System.Drawing.Point(6, 21);
            this.atikPictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.atikPictureBox.Name = "atikPictureBox";
            this.atikPictureBox.Size = new System.Drawing.Size(188, 150);
            this.atikPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atikPictureBox.TabIndex = 0;
            this.atikPictureBox.TabStop = false;
            // 
            // sureVePuanGroupBox
            // 
            this.sureVePuanGroupBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.sureVePuanGroupBox.Controls.Add(this.puanLabel);
            this.sureVePuanGroupBox.Controls.Add(this.puan2Label);
            this.sureVePuanGroupBox.Controls.Add(this.sureLabel);
            this.sureVePuanGroupBox.Controls.Add(this.sure2Label);
            this.sureVePuanGroupBox.Controls.Add(this.cikisButton);
            this.sureVePuanGroupBox.Controls.Add(this.yeniOyunButton);
            this.sureVePuanGroupBox.Location = new System.Drawing.Point(22, 249);
            this.sureVePuanGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sureVePuanGroupBox.Name = "sureVePuanGroupBox";
            this.sureVePuanGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sureVePuanGroupBox.Size = new System.Drawing.Size(202, 371);
            this.sureVePuanGroupBox.TabIndex = 1;
            this.sureVePuanGroupBox.TabStop = false;
            // 
            // puanLabel
            // 
            this.puanLabel.BackColor = System.Drawing.Color.PapayaWhip;
            this.puanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanLabel.Location = new System.Drawing.Point(30, 218);
            this.puanLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.puanLabel.Name = "puanLabel";
            this.puanLabel.Size = new System.Drawing.Size(134, 64);
            this.puanLabel.TabIndex = 5;
            this.puanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // puan2Label
            // 
            this.puan2Label.BackColor = System.Drawing.Color.SeaGreen;
            this.puan2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puan2Label.Location = new System.Drawing.Point(30, 195);
            this.puan2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.puan2Label.Name = "puan2Label";
            this.puan2Label.Size = new System.Drawing.Size(134, 23);
            this.puan2Label.TabIndex = 4;
            this.puan2Label.Text = "PUAN";
            this.puan2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sureLabel
            // 
            this.sureLabel.BackColor = System.Drawing.Color.PapayaWhip;
            this.sureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sureLabel.Location = new System.Drawing.Point(28, 108);
            this.sureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sureLabel.Name = "sureLabel";
            this.sureLabel.Size = new System.Drawing.Size(138, 66);
            this.sureLabel.TabIndex = 3;
            this.sureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sure2Label
            // 
            this.sure2Label.BackColor = System.Drawing.Color.SeaGreen;
            this.sure2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sure2Label.Location = new System.Drawing.Point(28, 85);
            this.sure2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sure2Label.Name = "sure2Label";
            this.sure2Label.Size = new System.Drawing.Size(138, 23);
            this.sure2Label.TabIndex = 2;
            this.sure2Label.Text = "SÜRE";
            this.sure2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cikisButton
            // 
            this.cikisButton.BackColor = System.Drawing.Color.Teal;
            this.cikisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cikisButton.Location = new System.Drawing.Point(28, 306);
            this.cikisButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(138, 36);
            this.cikisButton.TabIndex = 1;
            this.cikisButton.Text = "ÇIKIŞ";
            this.cikisButton.UseVisualStyleBackColor = false;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // yeniOyunButton
            // 
            this.yeniOyunButton.BackColor = System.Drawing.Color.Teal;
            this.yeniOyunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniOyunButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yeniOyunButton.Location = new System.Drawing.Point(28, 30);
            this.yeniOyunButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.yeniOyunButton.Name = "yeniOyunButton";
            this.yeniOyunButton.Size = new System.Drawing.Size(138, 42);
            this.yeniOyunButton.TabIndex = 0;
            this.yeniOyunButton.Text = "YENİ OYUN";
            this.yeniOyunButton.UseVisualStyleBackColor = false;
            this.yeniOyunButton.Click += new System.EventHandler(this.yeniOyunButton_Click);
            // 
            // baslikLabel
            // 
            this.baslikLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.baslikLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslikLabel.Location = new System.Drawing.Point(244, 23);
            this.baslikLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baslikLabel.Name = "baslikLabel";
            this.baslikLabel.Size = new System.Drawing.Size(360, 48);
            this.baslikLabel.TabIndex = 2;
            this.baslikLabel.Text = "ATIK KUTULARI";
            this.baslikLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // organikAtikPanel
            // 
            this.organikAtikPanel.BackColor = System.Drawing.Color.Teal;
            this.organikAtikPanel.Controls.Add(this.organikAtikProgressBar);
            this.organikAtikPanel.Controls.Add(this.organikAtikListBox);
            this.organikAtikPanel.Controls.Add(this.organikAtikBosaltButton);
            this.organikAtikPanel.Controls.Add(this.organikAtikButton);
            this.organikAtikPanel.Location = new System.Drawing.Point(244, 86);
            this.organikAtikPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.organikAtikPanel.Name = "organikAtikPanel";
            this.organikAtikPanel.Size = new System.Drawing.Size(170, 261);
            this.organikAtikPanel.TabIndex = 3;
            // 
            // organikAtikProgressBar
            // 
            this.organikAtikProgressBar.Location = new System.Drawing.Point(20, 206);
            this.organikAtikProgressBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.organikAtikProgressBar.Name = "organikAtikProgressBar";
            this.organikAtikProgressBar.Size = new System.Drawing.Size(126, 23);
            this.organikAtikProgressBar.TabIndex = 3;
            // 
            // organikAtikListBox
            // 
            this.organikAtikListBox.BackColor = System.Drawing.SystemColors.Info;
            this.organikAtikListBox.FormattingEnabled = true;
            this.organikAtikListBox.ItemHeight = 16;
            this.organikAtikListBox.Location = new System.Drawing.Point(20, 32);
            this.organikAtikListBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.organikAtikListBox.Name = "organikAtikListBox";
            this.organikAtikListBox.Size = new System.Drawing.Size(126, 164);
            this.organikAtikListBox.TabIndex = 2;
            // 
            // organikAtikBosaltButton
            // 
            this.organikAtikBosaltButton.Enabled = false;
            this.organikAtikBosaltButton.Location = new System.Drawing.Point(20, 235);
            this.organikAtikBosaltButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.organikAtikBosaltButton.Name = "organikAtikBosaltButton";
            this.organikAtikBosaltButton.Size = new System.Drawing.Size(126, 26);
            this.organikAtikBosaltButton.TabIndex = 1;
            this.organikAtikBosaltButton.Text = "BOŞALT";
            this.organikAtikBosaltButton.UseVisualStyleBackColor = true;
            this.organikAtikBosaltButton.Click += new System.EventHandler(this.organikAtikBosaltButton_Click);
            // 
            // organikAtikButton
            // 
            this.organikAtikButton.Enabled = false;
            this.organikAtikButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.organikAtikButton.Location = new System.Drawing.Point(20, 3);
            this.organikAtikButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.organikAtikButton.Name = "organikAtikButton";
            this.organikAtikButton.Size = new System.Drawing.Size(126, 23);
            this.organikAtikButton.TabIndex = 0;
            this.organikAtikButton.Text = "ORGANİK ATIK";
            this.organikAtikButton.UseVisualStyleBackColor = true;
            this.organikAtikButton.Click += new System.EventHandler(this.organikAtikButton_Click);
            // 
            // kagitAtikPanel
            // 
            this.kagitAtikPanel.BackColor = System.Drawing.Color.Teal;
            this.kagitAtikPanel.Controls.Add(this.kagitAtikProgressBar);
            this.kagitAtikPanel.Controls.Add(this.kagitAtikListBox);
            this.kagitAtikPanel.Controls.Add(this.kagitBosaltButton);
            this.kagitAtikPanel.Controls.Add(this.kagitButton);
            this.kagitAtikPanel.Location = new System.Drawing.Point(436, 87);
            this.kagitAtikPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.kagitAtikPanel.Name = "kagitAtikPanel";
            this.kagitAtikPanel.Size = new System.Drawing.Size(168, 260);
            this.kagitAtikPanel.TabIndex = 4;
            // 
            // kagitAtikProgressBar
            // 
            this.kagitAtikProgressBar.Location = new System.Drawing.Point(22, 205);
            this.kagitAtikProgressBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.kagitAtikProgressBar.Name = "kagitAtikProgressBar";
            this.kagitAtikProgressBar.Size = new System.Drawing.Size(130, 23);
            this.kagitAtikProgressBar.TabIndex = 3;
            // 
            // kagitAtikListBox
            // 
            this.kagitAtikListBox.BackColor = System.Drawing.SystemColors.Info;
            this.kagitAtikListBox.FormattingEnabled = true;
            this.kagitAtikListBox.ItemHeight = 16;
            this.kagitAtikListBox.Location = new System.Drawing.Point(22, 30);
            this.kagitAtikListBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.kagitAtikListBox.Name = "kagitAtikListBox";
            this.kagitAtikListBox.Size = new System.Drawing.Size(130, 164);
            this.kagitAtikListBox.TabIndex = 2;
            // 
            // kagitBosaltButton
            // 
            this.kagitBosaltButton.Enabled = false;
            this.kagitBosaltButton.Location = new System.Drawing.Point(22, 234);
            this.kagitBosaltButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.kagitBosaltButton.Name = "kagitBosaltButton";
            this.kagitBosaltButton.Size = new System.Drawing.Size(130, 26);
            this.kagitBosaltButton.TabIndex = 1;
            this.kagitBosaltButton.Text = "BOŞALT";
            this.kagitBosaltButton.UseVisualStyleBackColor = true;
            this.kagitBosaltButton.Click += new System.EventHandler(this.kagitBosaltButton_Click);
            // 
            // kagitButton
            // 
            this.kagitButton.Enabled = false;
            this.kagitButton.Location = new System.Drawing.Point(22, 2);
            this.kagitButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.kagitButton.Name = "kagitButton";
            this.kagitButton.Size = new System.Drawing.Size(130, 23);
            this.kagitButton.TabIndex = 0;
            this.kagitButton.Text = "KAĞIT ATIK";
            this.kagitButton.UseVisualStyleBackColor = true;
            this.kagitButton.Click += new System.EventHandler(this.kagitButton_Click);
            // 
            // camAtikPanel
            // 
            this.camAtikPanel.BackColor = System.Drawing.Color.Teal;
            this.camAtikPanel.Controls.Add(this.camAtikProgressBar);
            this.camAtikPanel.Controls.Add(this.camAtikListBox);
            this.camAtikPanel.Controls.Add(this.camBosaltButton);
            this.camAtikPanel.Controls.Add(this.camButton);
            this.camAtikPanel.Location = new System.Drawing.Point(244, 353);
            this.camAtikPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.camAtikPanel.Name = "camAtikPanel";
            this.camAtikPanel.Size = new System.Drawing.Size(170, 270);
            this.camAtikPanel.TabIndex = 5;
            // 
            // camAtikProgressBar
            // 
            this.camAtikProgressBar.Location = new System.Drawing.Point(20, 219);
            this.camAtikProgressBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.camAtikProgressBar.Name = "camAtikProgressBar";
            this.camAtikProgressBar.Size = new System.Drawing.Size(126, 23);
            this.camAtikProgressBar.TabIndex = 3;
            // 
            // camAtikListBox
            // 
            this.camAtikListBox.BackColor = System.Drawing.SystemColors.Info;
            this.camAtikListBox.FormattingEnabled = true;
            this.camAtikListBox.ItemHeight = 16;
            this.camAtikListBox.Location = new System.Drawing.Point(20, 34);
            this.camAtikListBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.camAtikListBox.Name = "camAtikListBox";
            this.camAtikListBox.Size = new System.Drawing.Size(126, 180);
            this.camAtikListBox.TabIndex = 2;
            // 
            // camBosaltButton
            // 
            this.camBosaltButton.Enabled = false;
            this.camBosaltButton.Location = new System.Drawing.Point(20, 244);
            this.camBosaltButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.camBosaltButton.Name = "camBosaltButton";
            this.camBosaltButton.Size = new System.Drawing.Size(126, 23);
            this.camBosaltButton.TabIndex = 1;
            this.camBosaltButton.Text = "BOŞALT";
            this.camBosaltButton.UseVisualStyleBackColor = true;
            this.camBosaltButton.Click += new System.EventHandler(this.camBosaltButton_Click);
            // 
            // camButton
            // 
            this.camButton.Enabled = false;
            this.camButton.Location = new System.Drawing.Point(20, 4);
            this.camButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.camButton.Name = "camButton";
            this.camButton.Size = new System.Drawing.Size(126, 23);
            this.camButton.TabIndex = 0;
            this.camButton.Text = "CAM ATIK";
            this.camButton.UseVisualStyleBackColor = true;
            this.camButton.Click += new System.EventHandler(this.camButton_Click);
            // 
            // metalAtikPanel
            // 
            this.metalAtikPanel.BackColor = System.Drawing.Color.Teal;
            this.metalAtikPanel.Controls.Add(this.metalAtikProgressBar);
            this.metalAtikPanel.Controls.Add(this.metalAtikListBox);
            this.metalAtikPanel.Controls.Add(this.metalBosaltButton);
            this.metalAtikPanel.Controls.Add(this.metalButton);
            this.metalAtikPanel.Location = new System.Drawing.Point(436, 353);
            this.metalAtikPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metalAtikPanel.Name = "metalAtikPanel";
            this.metalAtikPanel.Size = new System.Drawing.Size(168, 270);
            this.metalAtikPanel.TabIndex = 6;
            // 
            // metalAtikProgressBar
            // 
            this.metalAtikProgressBar.Location = new System.Drawing.Point(22, 219);
            this.metalAtikProgressBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metalAtikProgressBar.Name = "metalAtikProgressBar";
            this.metalAtikProgressBar.Size = new System.Drawing.Size(130, 23);
            this.metalAtikProgressBar.TabIndex = 3;
            // 
            // metalAtikListBox
            // 
            this.metalAtikListBox.BackColor = System.Drawing.SystemColors.Info;
            this.metalAtikListBox.FormattingEnabled = true;
            this.metalAtikListBox.ItemHeight = 16;
            this.metalAtikListBox.Location = new System.Drawing.Point(22, 34);
            this.metalAtikListBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metalAtikListBox.Name = "metalAtikListBox";
            this.metalAtikListBox.Size = new System.Drawing.Size(130, 180);
            this.metalAtikListBox.TabIndex = 2;
            // 
            // metalBosaltButton
            // 
            this.metalBosaltButton.Enabled = false;
            this.metalBosaltButton.Location = new System.Drawing.Point(22, 244);
            this.metalBosaltButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metalBosaltButton.Name = "metalBosaltButton";
            this.metalBosaltButton.Size = new System.Drawing.Size(130, 23);
            this.metalBosaltButton.TabIndex = 1;
            this.metalBosaltButton.Text = "BOŞALT";
            this.metalBosaltButton.UseVisualStyleBackColor = true;
            this.metalBosaltButton.Click += new System.EventHandler(this.metalBosaltButton_Click);
            // 
            // metalButton
            // 
            this.metalButton.Enabled = false;
            this.metalButton.Location = new System.Drawing.Point(22, 4);
            this.metalButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metalButton.Name = "metalButton";
            this.metalButton.Size = new System.Drawing.Size(130, 23);
            this.metalButton.TabIndex = 0;
            this.metalButton.Text = "METAL ATIK";
            this.metalButton.UseVisualStyleBackColor = true;
            this.metalButton.Click += new System.EventHandler(this.metalButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(622, 635);
            this.Controls.Add(this.metalAtikPanel);
            this.Controls.Add(this.camAtikPanel);
            this.Controls.Add(this.kagitAtikPanel);
            this.Controls.Add(this.organikAtikPanel);
            this.Controls.Add(this.baslikLabel);
            this.Controls.Add(this.sureVePuanGroupBox);
            this.Controls.Add(this.pictureGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATIK TOPLAMA OYUNU";
            this.pictureGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.atikPictureBox)).EndInit();
            this.sureVePuanGroupBox.ResumeLayout(false);
            this.organikAtikPanel.ResumeLayout(false);
            this.kagitAtikPanel.ResumeLayout(false);
            this.camAtikPanel.ResumeLayout(false);
            this.metalAtikPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pictureGroupBox;
        private System.Windows.Forms.PictureBox atikPictureBox;
        private System.Windows.Forms.GroupBox sureVePuanGroupBox;
        private System.Windows.Forms.Label puanLabel;
        private System.Windows.Forms.Label puan2Label;
        private System.Windows.Forms.Label sureLabel;
        private System.Windows.Forms.Label sure2Label;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.Button yeniOyunButton;
        private System.Windows.Forms.Label baslikLabel;
        private System.Windows.Forms.Panel organikAtikPanel;
        private System.Windows.Forms.ProgressBar organikAtikProgressBar;
        private System.Windows.Forms.ListBox organikAtikListBox;
        private System.Windows.Forms.Button organikAtikBosaltButton;
        private System.Windows.Forms.Button organikAtikButton;
        private System.Windows.Forms.Panel kagitAtikPanel;
        private System.Windows.Forms.Panel camAtikPanel;
        private System.Windows.Forms.Panel metalAtikPanel;
        private System.Windows.Forms.ProgressBar kagitAtikProgressBar;
        private System.Windows.Forms.ListBox kagitAtikListBox;
        private System.Windows.Forms.Button kagitBosaltButton;
        private System.Windows.Forms.Button kagitButton;
        private System.Windows.Forms.ProgressBar camAtikProgressBar;
        private System.Windows.Forms.ListBox camAtikListBox;
        private System.Windows.Forms.Button camBosaltButton;
        private System.Windows.Forms.Button camButton;
        private System.Windows.Forms.ProgressBar metalAtikProgressBar;
        private System.Windows.Forms.ListBox metalAtikListBox;
        private System.Windows.Forms.Button metalBosaltButton;
        private System.Windows.Forms.Button metalButton;
        private System.Windows.Forms.Timer timer1;
    }
}

