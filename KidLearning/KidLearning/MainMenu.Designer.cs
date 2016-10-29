namespace KidLearning
{
    partial class MainMenu
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
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBox1
            // 
            this.txtBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox1.Location = new System.Drawing.Point(13, 12);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.ReadOnly = true;
            this.txtBox1.Size = new System.Drawing.Size(813, 13);
            this.txtBox1.TabIndex = 0;
            this.txtBox1.Text = "PLEASE CHOOSE ONE SUBJECT";
            this.txtBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.txtBox1);
            this.Name = "MainMenu";
            this.Text = "Welcome to Kid Learning";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox1;
    }
}

