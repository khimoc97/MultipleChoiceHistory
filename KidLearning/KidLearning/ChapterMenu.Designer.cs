namespace KidLearning
{
    partial class ChapterMenu
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
            this.lbChapter = new System.Windows.Forms.Label();
            this.flGrChapter = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbChapter
            // 
            this.lbChapter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbChapter.AutoSize = true;
            this.lbChapter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChapter.Location = new System.Drawing.Point(257, 20);
            this.lbChapter.Name = "lbChapter";
            this.lbChapter.Size = new System.Drawing.Size(307, 20);
            this.lbChapter.TabIndex = 0;
            this.lbChapter.Text = "CHOOSE ONE CHAPTER TO CONTINUE";
            // 
            // flGrChapter
            // 
            this.flGrChapter.Location = new System.Drawing.Point(13, 57);
            this.flGrChapter.Name = "flGrChapter";
            this.flGrChapter.Size = new System.Drawing.Size(779, 372);
            this.flGrChapter.TabIndex = 2;
            // 
            // ChapterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.flGrChapter);
            this.Controls.Add(this.lbChapter);
            this.Name = "ChapterMenu";
            this.Text = "ChapterMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChapter;
        private System.Windows.Forms.FlowLayoutPanel flGrChapter;
    }
}