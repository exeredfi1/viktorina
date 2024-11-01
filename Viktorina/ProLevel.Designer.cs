namespace Viktorina
{
    partial class ProLevel
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
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(404, 341);
            this.buttonFinish.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(100, 28);
            this.buttonFinish.TabIndex = 13;
            this.buttonFinish.Text = "Закончить";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(208, 341);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(100, 28);
            this.buttonNext.TabIndex = 12;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(387, 248);
            this.radioButtonD.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(103, 20);
            this.radioButtonD.TabIndex = 11;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "radioButton4";
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(205, 248);
            this.radioButtonC.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(103, 20);
            this.radioButtonC.TabIndex = 10;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "radioButton3";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(387, 203);
            this.radioButtonB.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(103, 20);
            this.radioButtonB.TabIndex = 9;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "radioButton2";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(205, 203);
            this.radioButtonA.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(103, 20);
            this.radioButtonA.TabIndex = 8;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "radioButton1";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(298, 46);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(44, 16);
            this.labelQuestion.TabIndex = 7;
            this.labelQuestion.Text = "label1";
            // 
            // ButtonBack
            // 
            this.ButtonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBack.Location = new System.Drawing.Point(673, 384);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(115, 54);
            this.ButtonBack.TabIndex = 14;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            // 
            // ProLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.radioButtonD);
            this.Controls.Add(this.radioButtonC);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonA);
            this.Controls.Add(this.labelQuestion);
            this.Name = "ProLevel";
            this.Text = "ProLevel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button ButtonBack;
    }
}