using System;
using XrmToolBox.Extensibility;


namespace PZone.XrmToolBox
{
    partial class ErrorAnalizerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorAnalizerControl));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.MainCommandBar = new System.Windows.Forms.ToolStrip();
            this.CloseButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.AboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveAssemblyDialog = new System.Windows.Forms.SaveFileDialog();
            this.Source = new System.Windows.Forms.TextBox();
            this.AnalizeButton = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.MainCommandBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.AnalizeButton);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Output);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Source);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(941, 540);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(941, 565);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.MainCommandBar);
            // 
            // MainCommandBar
            // 
            this.MainCommandBar.Dock = System.Windows.Forms.DockStyle.None;
            this.MainCommandBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseButton,
            this.toolStripSeparator1,
            this.AboutDropDownButton,
            this.toolStripSeparator2});
            this.MainCommandBar.Location = new System.Drawing.Point(3, 0);
            this.MainCommandBar.Name = "MainCommandBar";
            this.MainCommandBar.Size = new System.Drawing.Size(116, 25);
            this.MainCommandBar.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(23, 22);
            this.CloseButton.Text = "Close";
            this.CloseButton.ToolTipText = "Close this tab";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // AboutDropDownButton
            // 
            this.AboutDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutButton});
            this.AboutDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutDropDownButton.Image")));
            this.AboutDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutDropDownButton.Name = "AboutDropDownButton";
            this.AboutDropDownButton.Size = new System.Drawing.Size(69, 22);
            this.AboutDropDownButton.Text = "About";
            // 
            // AboutButton
            // 
            this.AboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(180, 22);
            this.AboutButton.Text = "About";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveAssemblyDialog
            // 
            this.SaveAssemblyDialog.DefaultExt = "dll";
            this.SaveAssemblyDialog.Filter = "DLL (*.dll)|*.dll|All files (*.*)|*.*";
            this.SaveAssemblyDialog.InitialDirectory = "C:\\Users\\ra.kopaev\\Desktop";
            // 
            // Source
            // 
            this.Source.AcceptsReturn = true;
            this.Source.AcceptsTab = true;
            this.Source.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Source.Location = new System.Drawing.Point(3, 3);
            this.Source.Multiline = true;
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(935, 183);
            this.Source.TabIndex = 0;
            // 
            // AnalizeButton
            // 
            this.AnalizeButton.Location = new System.Drawing.Point(3, 192);
            this.AnalizeButton.Name = "AnalizeButton";
            this.AnalizeButton.Size = new System.Drawing.Size(134, 23);
            this.AnalizeButton.TabIndex = 1;
            this.AnalizeButton.Text = "Analize";
            this.AnalizeButton.UseVisualStyleBackColor = true;
            this.AnalizeButton.Click += new System.EventHandler(this.AnalizeButton_Click);
            // 
            // Output
            // 
            this.Output.AcceptsReturn = true;
            this.Output.AcceptsTab = true;
            this.Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output.Location = new System.Drawing.Point(3, 221);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(935, 316);
            this.Output.TabIndex = 0;
            // 
            // ErrorAnalizerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "ErrorAnalizerControl";
            this.Size = new System.Drawing.Size(941, 565);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.MainCommandBar.ResumeLayout(false);
            this.MainCommandBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip MainCommandBar;
        private System.Windows.Forms.SaveFileDialog SaveAssemblyDialog;
        private System.Windows.Forms.ToolStripButton CloseButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton AboutDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem AboutButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button AnalizeButton;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.TextBox Source;
    }
}
