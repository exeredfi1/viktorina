namespace Viktorina
{
    partial class Start
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
            this.ButtonEasy = new System.Windows.Forms.Button();
            this.ButtonNormal = new System.Windows.Forms.Button();
            this.ButtonHard = new System.Windows.Forms.Button();
            this.ButtonTheory = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonEasy
            // 
            this.ButtonEasy.Location = new System.Drawing.Point(247, 12);
            this.ButtonEasy.Name = "ButtonEasy";
            this.ButtonEasy.Size = new System.Drawing.Size(327, 63);
            this.ButtonEasy.TabIndex = 0;
            this.ButtonEasy.Text = "Легкий";
            this.ButtonEasy.UseVisualStyleBackColor = true;
            this.ButtonEasy.Click += new System.EventHandler(this.ButtonEasy_Click);
            // 
            // ButtonNormal
            // 
            this.ButtonNormal.Enabled = false;
            this.ButtonNormal.Location = new System.Drawing.Point(247, 98);
            this.ButtonNormal.Name = "ButtonNormal";
            this.ButtonNormal.Size = new System.Drawing.Size(327, 63);
            this.ButtonNormal.TabIndex = 1;
            this.ButtonNormal.Text = "Средний ";
            this.ButtonNormal.UseVisualStyleBackColor = true;
            // 
            // ButtonHard
            // 
            this.ButtonHard.Enabled = false;
            this.ButtonHard.Location = new System.Drawing.Point(247, 181);
            this.ButtonHard.Name = "ButtonHard";
            this.ButtonHard.Size = new System.Drawing.Size(327, 63);
            this.ButtonHard.TabIndex = 2;
            this.ButtonHard.Text = "Продвинутый";
            this.ButtonHard.UseVisualStyleBackColor = true;
            // 
            // ButtonTheory
            // 
            this.ButtonTheory.Location = new System.Drawing.Point(12, 387);
            this.ButtonTheory.Name = "ButtonTheory";
            this.ButtonTheory.Size = new System.Drawing.Size(255, 63);
            this.ButtonTheory.TabIndex = 3;
            this.ButtonTheory.Text = "Теория";
            this.ButtonTheory.UseVisualStyleBackColor = true;
            this.ButtonTheory.Click += new System.EventHandler(this.ButtonTheory_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(553, 390);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(237, 56);
            this.ButtonBack.TabIndex = 4;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 462);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonTheory);
            this.Controls.Add(this.ButtonHard);
            this.Controls.Add(this.ButtonNormal);
            this.Controls.Add(this.ButtonEasy);
            this.Name = "Start";
            this.Text = "Выбор сложности";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonEasy;
        private System.Windows.Forms.Button ButtonNormal;
        private System.Windows.Forms.Button ButtonHard;
        private System.Windows.Forms.Button ButtonTheory;
        private System.Windows.Forms.Button ButtonBack;
    }
}