namespace Windows_Forms_App_MVC
{
    partial class MainWindow
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
            this.MainWindowPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MVCPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.ButtonFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TextPanel = new System.Windows.Forms.Panel();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.MainWindowPanel.SuspendLayout();
            this.MVCPanel.SuspendLayout();
            this.TextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWindowPanel
            // 
            this.MainWindowPanel.ColumnCount = 1;
            this.MainWindowPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainWindowPanel.Controls.Add(this.MVCPanel, 0, 0);
            this.MainWindowPanel.Controls.Add(this.TextPanel, 0, 1);
            this.MainWindowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowPanel.Location = new System.Drawing.Point(0, 0);
            this.MainWindowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainWindowPanel.Name = "MainWindowPanel";
            this.MainWindowPanel.RowCount = 2;
            this.MainWindowPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainWindowPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.MainWindowPanel.Size = new System.Drawing.Size(1067, 554);
            this.MainWindowPanel.TabIndex = 0;
            // 
            // MVCPanel
            // 
            this.MVCPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MVCPanel.ColumnCount = 2;
            this.MVCPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 333F));
            this.MVCPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MVCPanel.Controls.Add(this.DisplayPanel, 1, 0);
            this.MVCPanel.Controls.Add(this.ButtonFlowPanel, 0, 0);
            this.MVCPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MVCPanel.Location = new System.Drawing.Point(4, 4);
            this.MVCPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MVCPanel.Name = "MVCPanel";
            this.MVCPanel.RowCount = 1;
            this.MVCPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MVCPanel.Size = new System.Drawing.Size(1059, 503);
            this.MVCPanel.TabIndex = 0;
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayPanel.Location = new System.Drawing.Point(337, 4);
            this.DisplayPanel.Margin = new System.Windows.Forms.Padding(4);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(718, 495);
            this.DisplayPanel.TabIndex = 0;
            // 
            // ButtonFlowPanel
            // 
            this.ButtonFlowPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonFlowPanel.Location = new System.Drawing.Point(4, 4);
            this.ButtonFlowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonFlowPanel.Name = "ButtonFlowPanel";
            this.ButtonFlowPanel.Size = new System.Drawing.Size(325, 495);
            this.ButtonFlowPanel.TabIndex = 1;
            // 
            // TextPanel
            // 
            this.TextPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TextPanel.Controls.Add(this.DisplayLabel);
            this.TextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextPanel.Location = new System.Drawing.Point(3, 514);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(1061, 37);
            this.TextPanel.TabIndex = 1;
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.Location = new System.Drawing.Point(12, 10);
            this.DisplayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(101, 17);
            this.DisplayLabel.TabIndex = 0;
            this.DisplayLabel.Text = "Displayed Text";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.MainWindowPanel);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.MainWindowPanel.ResumeLayout(false);
            this.MVCPanel.ResumeLayout(false);
            this.TextPanel.ResumeLayout(false);
            this.TextPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainWindowPanel;
        private System.Windows.Forms.TableLayoutPanel MVCPanel;
        private System.Windows.Forms.Panel DisplayPanel;
        private System.Windows.Forms.FlowLayoutPanel ButtonFlowPanel;
        private System.Windows.Forms.Panel TextPanel;
        private System.Windows.Forms.Label DisplayLabel;
    }
}

