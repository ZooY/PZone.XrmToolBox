using System;
using XrmToolBox.Extensibility;


namespace PZone.XrmToolBox
{
    partial class UserViewsManagerControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserViewsManagerControl));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.ViewsList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.UsersList = new System.Windows.Forms.ComboBox();
            this.MainCommandBar = new System.Windows.Forms.ToolStrip();
            this.CloseButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.AboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAssemblyDialog = new System.Windows.Forms.SaveFileDialog();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QueryTypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainEntityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewsListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowViewsListFetchXml = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.MainCommandBar.SuspendLayout();
            this.ViewsListContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.ViewsList);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.UsersList);
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
            // ViewsList
            // 
            this.ViewsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.IdColumn,
            this.QueryTypeColumn,
            this.MainEntityColumn,
            this.DescriptionColumn});
            this.ViewsList.ContextMenuStrip = this.ViewsListContextMenu;
            this.ViewsList.FullRowSelect = true;
            this.ViewsList.Location = new System.Drawing.Point(6, 30);
            this.ViewsList.Name = "ViewsList";
            this.ViewsList.Size = new System.Drawing.Size(932, 136);
            this.ViewsList.TabIndex = 2;
            this.ViewsList.UseCompatibleStateImageBehavior = false;
            this.ViewsList.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // UsersList
            // 
            this.UsersList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.UsersList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UsersList.FormattingEnabled = true;
            this.UsersList.Location = new System.Drawing.Point(38, 3);
            this.UsersList.Name = "UsersList";
            this.UsersList.Size = new System.Drawing.Size(250, 21);
            this.UsersList.TabIndex = 0;
            this.UsersList.SelectedIndexChanged += new System.EventHandler(this.UsersList_SelectedIndexChanged);
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
            // NameColumn
            // 
            this.NameColumn.DisplayIndex = 2;
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 216;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.Text = "Description";
            this.DescriptionColumn.Width = 338;
            // 
            // IdColumn
            // 
            this.IdColumn.DisplayIndex = 0;
            this.IdColumn.Text = "Id";
            this.IdColumn.Width = 0;
            // 
            // QueryTypeColumn
            // 
            this.QueryTypeColumn.DisplayIndex = 1;
            this.QueryTypeColumn.Text = "Type";
            this.QueryTypeColumn.Width = 93;
            // 
            // MainEntityColumn
            // 
            this.MainEntityColumn.Text = "Main Entity";
            this.MainEntityColumn.Width = 191;
            // 
            // ViewsListContextMenu
            // 
            this.ViewsListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowViewsListFetchXml});
            this.ViewsListContextMenu.Name = "ViewsListContextMenu";
            this.ViewsListContextMenu.Size = new System.Drawing.Size(156, 26);
            // 
            // ShowViewsListFetchXml
            // 
            this.ShowViewsListFetchXml.Name = "ShowViewsListFetchXml";
            this.ShowViewsListFetchXml.Size = new System.Drawing.Size(155, 22);
            this.ShowViewsListFetchXml.Text = "View FetchXML";
            this.ShowViewsListFetchXml.Click += new System.EventHandler(this.ShowViewsListFetchXml_Click);
            // 
            // UserViewsManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "UserViewsManagerControl";
            this.Size = new System.Drawing.Size(941, 565);
            this.Load += new System.EventHandler(this.UserViewsManagerControl_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.MainCommandBar.ResumeLayout(false);
            this.MainCommandBar.PerformLayout();
            this.ViewsListContextMenu.ResumeLayout(false);
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
        private System.Windows.Forms.ListView ViewsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox UsersList;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader IdColumn;
        private System.Windows.Forms.ColumnHeader DescriptionColumn;
        private System.Windows.Forms.ColumnHeader QueryTypeColumn;
        private System.Windows.Forms.ColumnHeader MainEntityColumn;
        private System.Windows.Forms.ContextMenuStrip ViewsListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ShowViewsListFetchXml;
    }
}
