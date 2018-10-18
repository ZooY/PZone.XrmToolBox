using System;
using XrmToolBox.Extensibility;


namespace PZone.XrmToolBox
{
    partial class MainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WebResourseNameBox = new System.Windows.Forms.TextBox();
            this.BrowseWebResourceButton = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.IsAutoCheckbox = new System.Windows.Forms.CheckBox();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.WebResourcesList = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.BrowsePluginFileButton = new System.Windows.Forms.Button();
            this.AddPluginButton = new System.Windows.Forms.Button();
            this.PluginAutoCheckbox = new System.Windows.Forms.CheckBox();
            this.PluginFileNameBox = new System.Windows.Forms.TextBox();
            this.PluginsList = new System.Windows.Forms.TableLayoutPanel();
            this.MainCommandBar = new System.Windows.Forms.ToolStrip();
            this.CloseButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.AboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAssemblyDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MainCommandBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl1);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(941, 540);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(933, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Web Resources";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.WebResourcesList, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(923, 504);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.WebResourseNameBox);
            this.panel1.Controls.Add(this.BrowseWebResourceButton);
            this.panel1.Controls.Add(this.BrowseButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.IsAutoCheckbox);
            this.panel1.Controls.Add(this.FileNameBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 46);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Web Resource";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "File";
            // 
            // WebResourseNameBox
            // 
            this.WebResourseNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebResourseNameBox.Location = new System.Drawing.Point(80, 25);
            this.WebResourseNameBox.Margin = new System.Windows.Forms.Padding(0);
            this.WebResourseNameBox.Name = "WebResourseNameBox";
            this.WebResourseNameBox.ReadOnly = true;
            this.WebResourseNameBox.Size = new System.Drawing.Size(688, 20);
            this.WebResourseNameBox.TabIndex = 9;
            // 
            // BrowseWebResourceButton
            // 
            this.BrowseWebResourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseWebResourceButton.Location = new System.Drawing.Point(773, 24);
            this.BrowseWebResourceButton.Margin = new System.Windows.Forms.Padding(0);
            this.BrowseWebResourceButton.Name = "BrowseWebResourceButton";
            this.BrowseWebResourceButton.Size = new System.Drawing.Size(70, 22);
            this.BrowseWebResourceButton.TabIndex = 8;
            this.BrowseWebResourceButton.Text = "Browse...";
            this.BrowseWebResourceButton.UseVisualStyleBackColor = true;
            this.BrowseWebResourceButton.Click += new System.EventHandler(this.BrowseWebResourceButton_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.Location = new System.Drawing.Point(773, 0);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(0);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(70, 22);
            this.BrowseButton.TabIndex = 7;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(853, 24);
            this.AddButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(70, 22);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // IsAutoCheckbox
            // 
            this.IsAutoCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IsAutoCheckbox.Location = new System.Drawing.Point(853, 0);
            this.IsAutoCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.IsAutoCheckbox.Name = "IsAutoCheckbox";
            this.IsAutoCheckbox.Size = new System.Drawing.Size(50, 22);
            this.IsAutoCheckbox.TabIndex = 4;
            this.IsAutoCheckbox.Text = "Auto";
            this.IsAutoCheckbox.UseVisualStyleBackColor = true;
            // 
            // FileNameBox
            // 
            this.FileNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameBox.Location = new System.Drawing.Point(80, 1);
            this.FileNameBox.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.ReadOnly = true;
            this.FileNameBox.Size = new System.Drawing.Size(688, 20);
            this.FileNameBox.TabIndex = 3;
            this.FileNameBox.TextChanged += new System.EventHandler(this.FileNameBox_TextChanged);
            // 
            // WebResourcesList
            // 
            this.WebResourcesList.AutoSize = true;
            this.WebResourcesList.ColumnCount = 1;
            this.WebResourcesList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WebResourcesList.Dock = System.Windows.Forms.DockStyle.Top;
            this.WebResourcesList.Location = new System.Drawing.Point(0, 0);
            this.WebResourcesList.Margin = new System.Windows.Forms.Padding(0);
            this.WebResourcesList.Name = "WebResourcesList";
            this.WebResourcesList.RowCount = 1;
            this.WebResourcesList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.WebResourcesList.Size = new System.Drawing.Size(923, 30);
            this.WebResourcesList.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage2.Size = new System.Drawing.Size(933, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Plug-ins";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.PluginsList, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(923, 504);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BrowsePluginFileButton);
            this.panel2.Controls.Add(this.AddPluginButton);
            this.panel2.Controls.Add(this.PluginAutoCheckbox);
            this.panel2.Controls.Add(this.PluginFileNameBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 22);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "File";
            // 
            // BrowsePluginFileButton
            // 
            this.BrowsePluginFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowsePluginFileButton.Location = new System.Drawing.Point(716, 0);
            this.BrowsePluginFileButton.Margin = new System.Windows.Forms.Padding(0);
            this.BrowsePluginFileButton.Name = "BrowsePluginFileButton";
            this.BrowsePluginFileButton.Size = new System.Drawing.Size(70, 22);
            this.BrowsePluginFileButton.TabIndex = 7;
            this.BrowsePluginFileButton.Text = "Browse...";
            this.BrowsePluginFileButton.UseVisualStyleBackColor = true;
            this.BrowsePluginFileButton.Click += new System.EventHandler(this.BrowsePluginFileButton_Click);
            // 
            // AddPluginButton
            // 
            this.AddPluginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPluginButton.Location = new System.Drawing.Point(853, 0);
            this.AddPluginButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddPluginButton.Name = "AddPluginButton";
            this.AddPluginButton.Size = new System.Drawing.Size(70, 22);
            this.AddPluginButton.TabIndex = 5;
            this.AddPluginButton.Text = "Add";
            this.AddPluginButton.UseVisualStyleBackColor = true;
            this.AddPluginButton.Click += new System.EventHandler(this.AddPluginButton_Click);
            // 
            // PluginAutoCheckbox
            // 
            this.PluginAutoCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PluginAutoCheckbox.Location = new System.Drawing.Point(803, 0);
            this.PluginAutoCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.PluginAutoCheckbox.Name = "PluginAutoCheckbox";
            this.PluginAutoCheckbox.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.PluginAutoCheckbox.Size = new System.Drawing.Size(50, 22);
            this.PluginAutoCheckbox.TabIndex = 4;
            this.PluginAutoCheckbox.Text = "Auto";
            this.PluginAutoCheckbox.UseVisualStyleBackColor = true;
            // 
            // PluginFileNameBox
            // 
            this.PluginFileNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PluginFileNameBox.Location = new System.Drawing.Point(25, 1);
            this.PluginFileNameBox.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.PluginFileNameBox.Name = "PluginFileNameBox";
            this.PluginFileNameBox.ReadOnly = true;
            this.PluginFileNameBox.Size = new System.Drawing.Size(686, 20);
            this.PluginFileNameBox.TabIndex = 3;
            // 
            // PluginsList
            // 
            this.PluginsList.AutoSize = true;
            this.PluginsList.ColumnCount = 1;
            this.PluginsList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PluginsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.PluginsList.Location = new System.Drawing.Point(0, 0);
            this.PluginsList.Margin = new System.Windows.Forms.Padding(0);
            this.PluginsList.Name = "PluginsList";
            this.PluginsList.RowCount = 1;
            this.PluginsList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PluginsList.Size = new System.Drawing.Size(923, 30);
            this.PluginsList.TabIndex = 4;
            // 
            // MainCommandBar
            // 
            this.MainCommandBar.Dock = System.Windows.Forms.DockStyle.None;
            this.MainCommandBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseButton,
            this.toolStripSeparator1,
            this.AboutDropDownButton});
            this.MainCommandBar.Location = new System.Drawing.Point(3, 0);
            this.MainCommandBar.Name = "MainCommandBar";
            this.MainCommandBar.Size = new System.Drawing.Size(110, 25);
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
            this.AboutButton.Size = new System.Drawing.Size(149, 22);
            this.AboutButton.Text = "About plug-in";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // SaveAssemblyDialog
            // 
            this.SaveAssemblyDialog.DefaultExt = "dll";
            this.SaveAssemblyDialog.Filter = "DLL (*.dll)|*.dll|All files (*.*)|*.*";
            this.SaveAssemblyDialog.InitialDirectory = "C:\\Users\\ra.kopaev\\Desktop";
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(941, 565);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.CheckBox IsAutoCheckbox;
        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.TableLayoutPanel WebResourcesList;
        private System.Windows.Forms.Button BrowseWebResourceButton;
        private System.Windows.Forms.TextBox WebResourseNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BrowsePluginFileButton;
        private System.Windows.Forms.Button AddPluginButton;
        private System.Windows.Forms.CheckBox PluginAutoCheckbox;
        private System.Windows.Forms.TextBox PluginFileNameBox;
        private System.Windows.Forms.TableLayoutPanel PluginsList;
    }
}
