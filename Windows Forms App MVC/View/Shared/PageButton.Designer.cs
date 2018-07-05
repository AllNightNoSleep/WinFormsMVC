namespace Windows_Forms_App_MVC
{
    partial class PageButton
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
            this.ButtonLabel = new System.Windows.Forms.Label();
            this.ButtonSymbolDown = new System.Windows.Forms.Label();
            this.ButtonSymbolUp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonLabel
            // 
            this.ButtonLabel.AutoSize = true;
            this.ButtonLabel.Location = new System.Drawing.Point(23, 27);
            this.ButtonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ButtonLabel.Name = "ButtonLabel";
            this.ButtonLabel.Size = new System.Drawing.Size(88, 17);
            this.ButtonLabel.TabIndex = 0;
            this.ButtonLabel.Text = "Button Label";
            // 
            // ButtonSymbolDown
            // 
            this.ButtonSymbolDown.AutoSize = true;
            this.ButtonSymbolDown.Location = new System.Drawing.Point(247, 26);
            this.ButtonSymbolDown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ButtonSymbolDown.Name = "ButtonSymbolDown";
            this.ButtonSymbolDown.Size = new System.Drawing.Size(18, 17);
            this.ButtonSymbolDown.TabIndex = 1;
            this.ButtonSymbolDown.Text = "▼";
            this.ButtonSymbolDown.Visible = false;
            // 
            // ButtonSymbolUp
            // 
            this.ButtonSymbolUp.AutoSize = true;
            this.ButtonSymbolUp.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSymbolUp.Location = new System.Drawing.Point(247, 25);
            this.ButtonSymbolUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ButtonSymbolUp.Name = "ButtonSymbolUp";
            this.ButtonSymbolUp.Size = new System.Drawing.Size(18, 17);
            this.ButtonSymbolUp.TabIndex = 2;
            this.ButtonSymbolUp.Text = "▲";
            // 
            // PageButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.ButtonSymbolUp);
            this.Controls.Add(this.ButtonSymbolDown);
            this.Controls.Add(this.ButtonLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PageButton";
            this.Size = new System.Drawing.Size(285, 64);
            this.Click += new System.EventHandler(this.PageButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ButtonLabel;
        private System.Windows.Forms.Label ButtonSymbolDown;
        private System.Windows.Forms.Label ButtonSymbolUp;
    }
}
