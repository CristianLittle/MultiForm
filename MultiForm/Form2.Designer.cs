namespace MultiForm
{
    partial class FrmTwo
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
            this.lblShare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblShare
            // 
            this.lblShare.AutoSize = true;
            this.lblShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblShare.Location = new System.Drawing.Point(278, 76);
            this.lblShare.Name = "lblShare";
            this.lblShare.Size = new System.Drawing.Size(86, 31);
            this.lblShare.TabIndex = 0;
            this.lblShare.Text = "label1";
            // 
            // FrmTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblShare);
            this.Name = "FrmTwo";
            this.Text = "Form 2";
            this.Load += new System.EventHandler(this.FrmTwo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblShare;
    }
}