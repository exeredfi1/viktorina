namespace Viktorina
{
    partial class QuizForm
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
            this.optionButton1 = new System.Windows.Forms.Button();
            this.optionButton2 = new System.Windows.Forms.Button();
            this.optionButton3 = new System.Windows.Forms.Button();
            this.optionButton4 = new System.Windows.Forms.Button();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.scoreDisplayLabel = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // optionButton1
            // 
            this.optionButton1.Location = new System.Drawing.Point(198, 56);
            this.optionButton1.Name = "optionButton1";
            this.optionButton1.Size = new System.Drawing.Size(241, 116);
            this.optionButton1.TabIndex = 0;
            this.optionButton1.Text = "button1";
            this.optionButton1.UseVisualStyleBackColor = true;
            this.optionButton1.Click += new System.EventHandler(this.OptionButton_Click);
            // 
            // optionButton2
            // 
            this.optionButton2.Location = new System.Drawing.Point(460, 56);
            this.optionButton2.Name = "optionButton2";
            this.optionButton2.Size = new System.Drawing.Size(241, 120);
            this.optionButton2.TabIndex = 1;
            this.optionButton2.Text = "button2";
            this.optionButton2.UseVisualStyleBackColor = true;
            this.optionButton2.Click += new System.EventHandler(this.OptionButton_Click);
            // 
            // optionButton3
            // 
            this.optionButton3.Location = new System.Drawing.Point(198, 188);
            this.optionButton3.Name = "optionButton3";
            this.optionButton3.Size = new System.Drawing.Size(241, 129);
            this.optionButton3.TabIndex = 2;
            this.optionButton3.Text = "button3";
            this.optionButton3.UseVisualStyleBackColor = true;
            this.optionButton3.Click += new System.EventHandler(this.OptionButton_Click);
            // 
            // optionButton4
            // 
            this.optionButton4.Location = new System.Drawing.Point(460, 188);
            this.optionButton4.Name = "optionButton4";
            this.optionButton4.Size = new System.Drawing.Size(241, 129);
            this.optionButton4.TabIndex = 3;
            this.optionButton4.Text = "button4";
            this.optionButton4.UseVisualStyleBackColor = true;
            this.optionButton4.Click += new System.EventHandler(this.OptionButton_Click);
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Location = new System.Drawing.Point(350, 9);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(44, 16);
            this.questionTextLabel.TabIndex = 4;
            this.questionTextLabel.Text = "label1";
            // 
            // scoreDisplayLabel
            // 
            this.scoreDisplayLabel.AutoSize = true;
            this.scoreDisplayLabel.Location = new System.Drawing.Point(432, 343);
            this.scoreDisplayLabel.Name = "scoreDisplayLabel";
            this.scoreDisplayLabel.Size = new System.Drawing.Size(44, 16);
            this.scoreDisplayLabel.TabIndex = 6;
            this.scoreDisplayLabel.Text = "label1";
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(877, 480);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(172, 49);
            this.ButtonBack.TabIndex = 8;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 541);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.scoreDisplayLabel);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.optionButton4);
            this.Controls.Add(this.optionButton3);
            this.Controls.Add(this.optionButton2);
            this.Controls.Add(this.optionButton1);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button optionButton1;
        private System.Windows.Forms.Button optionButton2;
        private System.Windows.Forms.Button optionButton3;
        private System.Windows.Forms.Button optionButton4;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.Label scoreDisplayLabel;
        private System.Windows.Forms.Button ButtonBack;
    }
}