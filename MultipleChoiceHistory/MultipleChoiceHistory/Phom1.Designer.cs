namespace MultipleChoiceHistory
{
    partial class Phom1
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
            this.battan1 = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // battan1
            // 
            this.battan1.Location = new System.Drawing.Point(23, 13);
            this.battan1.Name = "battan1";
            this.battan1.Size = new System.Drawing.Size(75, 23);
            this.battan1.TabIndex = 0;
            this.battan1.Text = "button1";
            this.battan1.UseVisualStyleBackColor = true;
            this.battan1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(56, 99);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(168, 20);
            this.txtAnswer.TabIndex = 1;
            // 
            // Phom1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.battan1);
            this.Name = "Phom1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button battan1;
        private System.Windows.Forms.TextBox txtAnswer;
    }
}

