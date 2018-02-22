using System;
using XrmToolBox.Extensibility;


namespace PZone.XrmToolBox
{
    partial class ComponentComparerControl
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Resource",
            "00000000-0000-0000-0000-000000000000",
            "1.0.0",
            "2.2"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentComparerControl));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.ResultList = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SourceIdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SourceVersionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SourceSizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ResultColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OtherIdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OtherVersionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OtherSizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainCommandBar = new System.Windows.Forms.ToolStrip();
            this.CloseButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.AboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ConnectButton = new System.Windows.Forms.ToolStripButton();
            this.ConnectionLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CompareMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.ComparePluginsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.WebResourcesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CompareHtmlButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CompareJsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CompareStylesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CompareStylesButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.CompareCssButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CompareXslButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CompareXmlButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CompareImageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CompareImagesButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ComparePngButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CompareJpgButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CompareGifButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CompareIconsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CompareXapButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowMode = new System.Windows.Forms.ToolStripComboBox();
            this.SaveAssemblyDialog = new System.Windows.Forms.SaveFileDialog();
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.ResultList);
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
            // ResultList
            // 
            this.ResultList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.SourceIdColumn,
            this.SourceVersionColumn,
            this.SourceSizeColumn,
            this.ResultColumn,
            this.OtherIdColumn,
            this.OtherVersionColumn,
            this.OtherSizeColumn});
            this.ResultList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultList.FullRowSelect = true;
            this.ResultList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ResultList.Location = new System.Drawing.Point(0, 0);
            this.ResultList.Name = "ResultList";
            this.ResultList.Size = new System.Drawing.Size(941, 540);
            this.ResultList.TabIndex = 0;
            this.ResultList.UseCompatibleStateImageBehavior = false;
            this.ResultList.View = System.Windows.Forms.View.Details;
            // 
            // NameColumn
            // 
            this.NameColumn.DisplayIndex = 2;
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 200;
            // 
            // SourceIdColumn
            // 
            this.SourceIdColumn.DisplayIndex = 0;
            this.SourceIdColumn.Text = "ID";
            this.SourceIdColumn.Width = 0;
            // 
            // SourceVersionColumn
            // 
            this.SourceVersionColumn.DisplayIndex = 3;
            this.SourceVersionColumn.Text = "Version";
            // 
            // SourceSizeColumn
            // 
            this.SourceSizeColumn.DisplayIndex = 4;
            this.SourceSizeColumn.Text = "Size";
            // 
            // ResultColumn
            // 
            this.ResultColumn.DisplayIndex = 5;
            this.ResultColumn.Text = "";
            this.ResultColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ResultColumn.Width = 42;
            // 
            // OtherIdColumn
            // 
            this.OtherIdColumn.DisplayIndex = 1;
            this.OtherIdColumn.Text = "ID";
            this.OtherIdColumn.Width = 0;
            // 
            // OtherVersionColumn
            // 
            this.OtherVersionColumn.Text = "Version";
            // 
            // OtherSizeColumn
            // 
            this.OtherSizeColumn.Text = "Size";
            // 
            // MainCommandBar
            // 
            this.MainCommandBar.Dock = System.Windows.Forms.DockStyle.None;
            this.MainCommandBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseButton,
            this.toolStripSeparator1,
            this.AboutDropDownButton,
            this.toolStripSeparator2,
            this.ConnectButton,
            this.ConnectionLabel,
            this.toolStripSeparator3,
            this.CompareMenu,
            this.ShowMode});
            this.MainCommandBar.Location = new System.Drawing.Point(3, 0);
            this.MainCommandBar.Name = "MainCommandBar";
            this.MainCommandBar.Size = new System.Drawing.Size(492, 25);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ConnectButton
            // 
            this.ConnectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ConnectButton.Image = ((System.Drawing.Image)(resources.GetObject("ConnectButton.Image")));
            this.ConnectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(56, 22);
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ConnectionLabel
            // 
            this.ConnectionLabel.Name = "ConnectionLabel";
            this.ConnectionLabel.Size = new System.Drawing.Size(89, 22);
            this.ConnectionLabel.Text = "Connected to #";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // CompareMenu
            // 
            this.CompareMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CompareMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComparePluginsButton,
            this.WebResourcesMenu});
            this.CompareMenu.Image = ((System.Drawing.Image)(resources.GetObject("CompareMenu.Image")));
            this.CompareMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CompareMenu.Name = "CompareMenu";
            this.CompareMenu.Size = new System.Drawing.Size(69, 22);
            this.CompareMenu.Text = "Compare";
            // 
            // ComparePluginsButton
            // 
            this.ComparePluginsButton.Name = "ComparePluginsButton";
            this.ComparePluginsButton.Size = new System.Drawing.Size(154, 22);
            this.ComparePluginsButton.Text = "Plug-ins";
            this.ComparePluginsButton.Click += new System.EventHandler(this.ComparePluginsButton_Click);
            // 
            // WebResourcesMenu
            // 
            this.WebResourcesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CompareHtmlButton,
            this.CompareJsButton,
            this.CompareStylesMenu,
            this.CompareXmlButton,
            this.CompareImageMenu,
            this.CompareXapButton});
            this.WebResourcesMenu.Name = "WebResourcesMenu";
            this.WebResourcesMenu.Size = new System.Drawing.Size(154, 22);
            this.WebResourcesMenu.Text = "Web Resources";
            // 
            // CompareHtmlButton
            // 
            this.CompareHtmlButton.Name = "CompareHtmlButton";
            this.CompareHtmlButton.Size = new System.Drawing.Size(126, 22);
            this.CompareHtmlButton.Text = "HTML";
            this.CompareHtmlButton.Click += new System.EventHandler(this.CompareHtmlButton_Click);
            // 
            // CompareJsButton
            // 
            this.CompareJsButton.Name = "CompareJsButton";
            this.CompareJsButton.Size = new System.Drawing.Size(126, 22);
            this.CompareJsButton.Text = "JavaScript";
            this.CompareJsButton.Click += new System.EventHandler(this.CompareJsButton_Click);
            // 
            // CompareStylesMenu
            // 
            this.CompareStylesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CompareStylesButton,
            this.toolStripSeparator4,
            this.CompareCssButton,
            this.CompareXslButton});
            this.CompareStylesMenu.Name = "CompareStylesMenu";
            this.CompareStylesMenu.Size = new System.Drawing.Size(126, 22);
            this.CompareStylesMenu.Text = "Styles";
            // 
            // CompareStylesButton
            // 
            this.CompareStylesButton.Name = "CompareStylesButton";
            this.CompareStylesButton.Size = new System.Drawing.Size(94, 22);
            this.CompareStylesButton.Text = "All";
            this.CompareStylesButton.Click += new System.EventHandler(this.CompareStylesButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(91, 6);
            // 
            // CompareCssButton
            // 
            this.CompareCssButton.Name = "CompareCssButton";
            this.CompareCssButton.Size = new System.Drawing.Size(94, 22);
            this.CompareCssButton.Text = "CSS";
            this.CompareCssButton.Click += new System.EventHandler(this.CompareCssButton_Click);
            // 
            // CompareXslButton
            // 
            this.CompareXslButton.Name = "CompareXslButton";
            this.CompareXslButton.Size = new System.Drawing.Size(94, 22);
            this.CompareXslButton.Text = "XSL";
            this.CompareXslButton.Click += new System.EventHandler(this.CompareXslButton_Click);
            // 
            // CompareXmlButton
            // 
            this.CompareXmlButton.Name = "CompareXmlButton";
            this.CompareXmlButton.Size = new System.Drawing.Size(126, 22);
            this.CompareXmlButton.Text = "XML";
            this.CompareXmlButton.Click += new System.EventHandler(this.CompareXmlButton_Click);
            // 
            // CompareImageMenu
            // 
            this.CompareImageMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CompareImagesButton,
            this.toolStripSeparator5,
            this.ComparePngButton,
            this.CompareJpgButton,
            this.CompareGifButton,
            this.CompareIconsButton});
            this.CompareImageMenu.Name = "CompareImageMenu";
            this.CompareImageMenu.Size = new System.Drawing.Size(126, 22);
            this.CompareImageMenu.Text = "Images";
            // 
            // CompareImagesButton
            // 
            this.CompareImagesButton.Name = "CompareImagesButton";
            this.CompareImagesButton.Size = new System.Drawing.Size(102, 22);
            this.CompareImagesButton.Text = "All";
            this.CompareImagesButton.Click += new System.EventHandler(this.CompareImagesButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(99, 6);
            // 
            // ComparePngButton
            // 
            this.ComparePngButton.Name = "ComparePngButton";
            this.ComparePngButton.Size = new System.Drawing.Size(102, 22);
            this.ComparePngButton.Text = "PNG";
            this.ComparePngButton.Click += new System.EventHandler(this.ComparePngButton_Click);
            // 
            // CompareJpgButton
            // 
            this.CompareJpgButton.Name = "CompareJpgButton";
            this.CompareJpgButton.Size = new System.Drawing.Size(102, 22);
            this.CompareJpgButton.Text = "JPG";
            this.CompareJpgButton.Click += new System.EventHandler(this.CompareJpgButton_Click);
            // 
            // CompareGifButton
            // 
            this.CompareGifButton.Name = "CompareGifButton";
            this.CompareGifButton.Size = new System.Drawing.Size(102, 22);
            this.CompareGifButton.Text = "GIF";
            this.CompareGifButton.Click += new System.EventHandler(this.CompareGifButton_Click);
            // 
            // CompareIconsButton
            // 
            this.CompareIconsButton.Name = "CompareIconsButton";
            this.CompareIconsButton.Size = new System.Drawing.Size(102, 22);
            this.CompareIconsButton.Text = "Icons";
            this.CompareIconsButton.Click += new System.EventHandler(this.CompareIconsButton_Click);
            // 
            // CompareXapButton
            // 
            this.CompareXapButton.Name = "CompareXapButton";
            this.CompareXapButton.Size = new System.Drawing.Size(126, 22);
            this.CompareXapButton.Text = "Silverlight";
            this.CompareXapButton.Click += new System.EventHandler(this.CompareXapButton_Click);
            // 
            // ShowMode
            // 
            this.ShowMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShowMode.Items.AddRange(new object[] {
            "Show All",
            "Show Different"});
            this.ShowMode.Name = "ShowMode";
            this.ShowMode.Size = new System.Drawing.Size(121, 25);
            this.ShowMode.SelectedIndexChanged += new System.EventHandler(this.ShowMode_SelectedIndexChanged);
            // 
            // SaveAssemblyDialog
            // 
            this.SaveAssemblyDialog.DefaultExt = "dll";
            this.SaveAssemblyDialog.Filter = "DLL (*.dll)|*.dll|All files (*.*)|*.*";
            this.SaveAssemblyDialog.InitialDirectory = "C:\\Users\\ra.kopaev\\Desktop";
            // 
            // СomponentСomparerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "ComponentComparerControl";
            this.Size = new System.Drawing.Size(941, 565);
            this.Load += new System.EventHandler(this.СomponentСomparerControl_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
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
        private System.Windows.Forms.ListView ResultList;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader SourceIdColumn;
        private System.Windows.Forms.ColumnHeader SourceVersionColumn;
        private System.Windows.Forms.ColumnHeader ResultColumn;
        private System.Windows.Forms.ToolStripButton ConnectButton;
        private System.Windows.Forms.ToolStripLabel ConnectionLabel;
        private System.Windows.Forms.ColumnHeader OtherIdColumn;
        private System.Windows.Forms.ColumnHeader OtherVersionColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton CompareMenu;
        private System.Windows.Forms.ToolStripMenuItem ComparePluginsButton;
        private System.Windows.Forms.ToolStripMenuItem WebResourcesMenu;
        private System.Windows.Forms.ToolStripMenuItem CompareJsButton;
        private System.Windows.Forms.ColumnHeader SourceSizeColumn;
        private System.Windows.Forms.ColumnHeader OtherSizeColumn;
        private System.Windows.Forms.ToolStripMenuItem CompareHtmlButton;
        private System.Windows.Forms.ToolStripMenuItem CompareStylesMenu;
        private System.Windows.Forms.ToolStripMenuItem CompareStylesButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem CompareCssButton;
        private System.Windows.Forms.ToolStripMenuItem CompareXslButton;
        private System.Windows.Forms.ToolStripMenuItem CompareXmlButton;
        private System.Windows.Forms.ToolStripMenuItem CompareXapButton;
        private System.Windows.Forms.ToolStripMenuItem CompareImageMenu;
        private System.Windows.Forms.ToolStripMenuItem CompareImagesButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem ComparePngButton;
        private System.Windows.Forms.ToolStripMenuItem CompareJpgButton;
        private System.Windows.Forms.ToolStripMenuItem CompareGifButton;
        private System.Windows.Forms.ToolStripMenuItem CompareIconsButton;
        private System.Windows.Forms.ToolStripComboBox ShowMode;
    }
}
