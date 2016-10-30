namespace KidLearning
{
    partial class Lession
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
            this.lbLession = new System.Windows.Forms.Label();
            this.flGrLession = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbLession
            // 
            this.lbLession.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbLession.AutoSize = true;
            this.lbLession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLession.Location = new System.Drawing.Point(260, 20);
            this.lbLession.Name = "lbLession";
            this.lbLession.Size = new System.Drawing.Size(301, 20);
            this.lbLession.TabIndex = 0;
            this.lbLession.Text = "CHOOSE ONE LESSION TO CONTINUE";
            // 
            // flGrLession
            // 
            this.flGrLession.Location = new System.Drawing.Point(13, 57);
            this.flGrLession.Name = "flGrLession";
            this.flGrLession.Size = new System.Drawing.Size(779, 372);
            this.flGrLession.TabIndex = 3;
            // 
            // Lession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.flGrLession);
            this.Controls.Add(this.lbLession);
            this.Name = "Lession";
            this.Text = "Lession";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLession;
        private System.Windows.Forms.FlowLayoutPanel flGrLession;
    }
}