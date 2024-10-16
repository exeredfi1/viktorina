namespace Viktorina
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonProfile = new System.Windows.Forms.Button();
            this.ButtonAbout = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(72, 40);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(162, 49);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Начать";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonProfile
            // 
            this.ButtonProfile.Location = new System.Drawing.Point(72, 95);
            this.ButtonProfile.Name = "ButtonProfile";
            this.ButtonProfile.Size = new System.Drawing.Size(162, 47);
            this.ButtonProfile.TabIndex = 1;
            this.ButtonProfile.Text = "Профиль";
            this.ButtonProfile.UseVisualStyleBackColor = true;
            this.ButtonProfile.Click += new System.EventHandler(this.ButtonProfile_Click);
            // 
            // ButtonAbout
            // 
            this.ButtonAbout.Location = new System.Drawing.Point(72, 148);
            this.ButtonAbout.Name = "ButtonAbout";
            this.ButtonAbout.Size = new System.Drawing.Size(162, 51);
            this.ButtonAbout.TabIndex = 2;
            this.ButtonAbout.Text = "О программе";
            this.ButtonAbout.UseVisualStyleBackColor = true;
            this.ButtonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(72, 205);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(162, 44);
            this.ButtonExit.TabIndex = 3;
            this.ButtonExit.Text = "Выход";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 354);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonAbout);
            this.Controls.Add(this.ButtonProfile);
            this.Controls.Add(this.ButtonStart);
            this.Name = "MainMenu";
            this.Text = "Главное Меню";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonProfile;
        private System.Windows.Forms.Button ButtonAbout;
        private System.Windows.Forms.Button ButtonExit;
    }
}

