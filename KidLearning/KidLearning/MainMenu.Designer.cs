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
            this.flGrSubject = new System.Windows.Forms.FlowLayoutPanel();
            this.lbSubjecMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flGrSubject
            // 
            this.flGrSubject.Location = new System.Drawing.Point(13, 57);
            this.flGrSubject.Name = "flGrSubject";
            this.flGrSubject.Size = new System.Drawing.Size(779, 372);
            this.flGrSubject.TabIndex = 1;
            // 
            // lbSubjecMenu
            // 
            this.lbSubjecMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSubjecMenu.AutoSize = true;
            this.lbSubjecMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubjecMenu.Location = new System.Drawing.Point(273, 20);
            this.lbSubjecMenu.Name = "lbSubjecMenu";
            this.lbSubjecMenu.Size = new System.Drawing.Size(274, 20);
            this.lbSubjecMenu.TabIndex = 2;
            this.lbSubjecMenu.Text = "CHOOSE ONE SUBJECT TO START";
            this.lbSubjecMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.lbSubjecMenu);
            this.Controls.Add(this.flGrSubject);
            this.Name = "MainMenu";
            this.Text = "Welcome to Kid Learning";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flGrSubject;
        private System.Windows.Forms.Label lbSubjecMenu;
    }
}

