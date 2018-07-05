namespace Windows_Forms_App_MVC.View.Shared
{
    partial class SubPageButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SubButtonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubButtonLabel
            // 
            this.SubButtonLabel.AutoSize = true;
            this.SubButtonLabel.Location = new System.Drawing.Point(23, 27);
            this.SubButtonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubButtonLabel.Name = "SubButtonLabel";
            this.SubButtonLabel.Size = new System.Drawing.Size(88, 17);
            this.SubButtonLabel.TabIndex = 1;
            this.SubButtonLabel.Text = "Button Label";
            // 
            // SubPageButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.SubButtonLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SubPageButton";
            this.Size = new System.Drawing.Size(285, 64);
            this.Click += new System.EventHandler(this.SubPageButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubButtonLabel;
    }
}
