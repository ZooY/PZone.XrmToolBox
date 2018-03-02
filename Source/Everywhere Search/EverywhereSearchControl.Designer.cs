namespace PZone.XrmToolBox
{
    partial class EverywhereSearchControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EverywhereSearchControl));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.SearchTypeTabs = new System.Windows.Forms.TabControl();
            this.SearchById = new System.Windows.Forms.TabPage();
            this.SearchByIdResult = new System.Windows.Forms.GroupBox();
            this.SearchByIdOpenInCrmButton = new System.Windows.Forms.Button();
            this.SearchByIdName = new System.Windows.Forms.TextBox();
            this.SearchByIdEntityDisplayName = new System.Windows.Forms.TextBox();
            this.SearchByIdEntityLogicalName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchByIdFindButton = new System.Windows.Forms.Button();
            this.SearchByIdString = new System.Windows.Forms.TextBox();
            this.SearchByIdFindCustom = new System.Windows.Forms.CheckBox();
            this.SearchByIdFindSystem = new System.Windows.Forms.CheckBox();
            this.SearchInWR = new System.Windows.Forms.TabPage();
            this.SearchInWRResult = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContentColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchInWRXml = new System.Windows.Forms.CheckBox();
            this.SearchInWRJavaScript = new System.Windows.Forms.CheckBox();
            this.SearchInWRStyles = new System.Windows.Forms.CheckBox();
            this.SearchInWRHtml = new System.Windows.Forms.CheckBox();
            this.SearchInWRFindButton = new System.Windows.Forms.Button();
            this.SearchInWRString = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MainCommandBar = new System.Windows.Forms.ToolStrip();
            this.CloseButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.AboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SearchTypeTabs.SuspendLayout();
            this.SearchById.SuspendLayout();
            this.SearchByIdResult.SuspendLayout();
            this.SearchInWR.SuspendLayout();
            this.MainCommandBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.SearchTypeTabs);
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
            // SearchTypeTabs
            // 
            this.SearchTypeTabs.Controls.Add(this.SearchById);
            this.SearchTypeTabs.Controls.Add(this.SearchInWR);
            this.SearchTypeTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchTypeTabs.Location = new System.Drawing.Point(0, 0);
            this.SearchTypeTabs.Name = "SearchTypeTabs";
            this.SearchTypeTabs.SelectedIndex = 0;
            this.SearchTypeTabs.Size = new System.Drawing.Size(941, 540);
            this.SearchTypeTabs.TabIndex = 0;
            // 
            // SearchById
            // 
            this.SearchById.Controls.Add(this.SearchByIdResult);
            this.SearchById.Controls.Add(this.label1);
            this.SearchById.Controls.Add(this.SearchByIdFindButton);
            this.SearchById.Controls.Add(this.SearchByIdString);
            this.SearchById.Controls.Add(this.SearchByIdFindCustom);
            this.SearchById.Controls.Add(this.SearchByIdFindSystem);
            this.SearchById.Location = new System.Drawing.Point(4, 22);
            this.SearchById.Name = "SearchById";
            this.SearchById.Padding = new System.Windows.Forms.Padding(3);
            this.SearchById.Size = new System.Drawing.Size(933, 514);
            this.SearchById.TabIndex = 0;
            this.SearchById.Text = "Search by ID";
            this.SearchById.UseVisualStyleBackColor = true;
            // 
            // SearchByIdResult
            // 
            this.SearchByIdResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchByIdResult.Controls.Add(this.SearchByIdOpenInCrmButton);
            this.SearchByIdResult.Controls.Add(this.SearchByIdName);
            this.SearchByIdResult.Controls.Add(this.SearchByIdEntityDisplayName);
            this.SearchByIdResult.Controls.Add(this.SearchByIdEntityLogicalName);
            this.SearchByIdResult.Controls.Add(this.label4);
            this.SearchByIdResult.Controls.Add(this.label3);
            this.SearchByIdResult.Controls.Add(this.label2);
            this.SearchByIdResult.Location = new System.Drawing.Point(3, 55);
            this.SearchByIdResult.Name = "SearchByIdResult";
            this.SearchByIdResult.Size = new System.Drawing.Size(927, 456);
            this.SearchByIdResult.TabIndex = 4;
            this.SearchByIdResult.TabStop = false;
            this.SearchByIdResult.Text = "Result";
            // 
            // SearchByIdOpenInCrmButton
            // 
            this.SearchByIdOpenInCrmButton.Location = new System.Drawing.Point(125, 95);
            this.SearchByIdOpenInCrmButton.Name = "SearchByIdOpenInCrmButton";
            this.SearchByIdOpenInCrmButton.Size = new System.Drawing.Size(100, 23);
            this.SearchByIdOpenInCrmButton.TabIndex = 2;
            this.SearchByIdOpenInCrmButton.Text = "Open in CRM";
            this.SearchByIdOpenInCrmButton.UseVisualStyleBackColor = true;
            this.SearchByIdOpenInCrmButton.Click += new System.EventHandler(this.SearchByIdOpenInCrmButton_Click);
            // 
            // SearchByIdName
            // 
            this.SearchByIdName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchByIdName.Location = new System.Drawing.Point(125, 69);
            this.SearchByIdName.Name = "SearchByIdName";
            this.SearchByIdName.ReadOnly = true;
            this.SearchByIdName.Size = new System.Drawing.Size(796, 20);
            this.SearchByIdName.TabIndex = 1;
            // 
            // SearchByIdEntityDisplayName
            // 
            this.SearchByIdEntityDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchByIdEntityDisplayName.Location = new System.Drawing.Point(125, 43);
            this.SearchByIdEntityDisplayName.Name = "SearchByIdEntityDisplayName";
            this.SearchByIdEntityDisplayName.ReadOnly = true;
            this.SearchByIdEntityDisplayName.Size = new System.Drawing.Size(796, 20);
            this.SearchByIdEntityDisplayName.TabIndex = 1;
            // 
            // SearchByIdEntityLogicalName
            // 
            this.SearchByIdEntityLogicalName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchByIdEntityLogicalName.Location = new System.Drawing.Point(125, 17);
            this.SearchByIdEntityLogicalName.Name = "SearchByIdEntityLogicalName";
            this.SearchByIdEntityLogicalName.ReadOnly = true;
            this.SearchByIdEntityLogicalName.Size = new System.Drawing.Size(796, 20);
            this.SearchByIdEntityLogicalName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Entity Display Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Entity Logical Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entity ID";
            // 
            // SearchByIdFindButton
            // 
            this.SearchByIdFindButton.Location = new System.Drawing.Point(385, 16);
            this.SearchByIdFindButton.Name = "SearchByIdFindButton";
            this.SearchByIdFindButton.Size = new System.Drawing.Size(75, 23);
            this.SearchByIdFindButton.TabIndex = 2;
            this.SearchByIdFindButton.Text = "Find";
            this.SearchByIdFindButton.UseVisualStyleBackColor = true;
            this.SearchByIdFindButton.Click += new System.EventHandler(this.SearchByIdFindButton_Click);
            // 
            // SearchByIdString
            // 
            this.SearchByIdString.Location = new System.Drawing.Point(59, 6);
            this.SearchByIdString.Name = "SearchByIdString";
            this.SearchByIdString.Size = new System.Drawing.Size(307, 20);
            this.SearchByIdString.TabIndex = 1;
            this.SearchByIdString.Text = "{7CE6D49B-160C-E811-A2BD-005056A53E59}";
            // 
            // SearchByIdFindCustom
            // 
            this.SearchByIdFindCustom.AutoSize = true;
            this.SearchByIdFindCustom.Checked = true;
            this.SearchByIdFindCustom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchByIdFindCustom.Location = new System.Drawing.Point(216, 32);
            this.SearchByIdFindCustom.Name = "SearchByIdFindCustom";
            this.SearchByIdFindCustom.Size = new System.Drawing.Size(132, 17);
            this.SearchByIdFindCustom.TabIndex = 0;
            this.SearchByIdFindCustom.Text = "Find in Custom Entities";
            this.SearchByIdFindCustom.UseVisualStyleBackColor = true;
            // 
            // SearchByIdFindSystem
            // 
            this.SearchByIdFindSystem.AutoSize = true;
            this.SearchByIdFindSystem.Checked = true;
            this.SearchByIdFindSystem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchByIdFindSystem.Location = new System.Drawing.Point(59, 32);
            this.SearchByIdFindSystem.Name = "SearchByIdFindSystem";
            this.SearchByIdFindSystem.Size = new System.Drawing.Size(131, 17);
            this.SearchByIdFindSystem.TabIndex = 0;
            this.SearchByIdFindSystem.Text = "Find in System Entities";
            this.SearchByIdFindSystem.UseVisualStyleBackColor = true;
            // 
            // SearchInWR
            // 
            this.SearchInWR.Controls.Add(this.SearchInWRResult);
            this.SearchInWR.Controls.Add(this.SearchInWRXml);
            this.SearchInWR.Controls.Add(this.SearchInWRJavaScript);
            this.SearchInWR.Controls.Add(this.SearchInWRStyles);
            this.SearchInWR.Controls.Add(this.SearchInWRHtml);
            this.SearchInWR.Controls.Add(this.SearchInWRFindButton);
            this.SearchInWR.Controls.Add(this.SearchInWRString);
            this.SearchInWR.Controls.Add(this.label5);
            this.SearchInWR.Location = new System.Drawing.Point(4, 22);
            this.SearchInWR.Name = "SearchInWR";
            this.SearchInWR.Padding = new System.Windows.Forms.Padding(3);
            this.SearchInWR.Size = new System.Drawing.Size(933, 514);
            this.SearchInWR.TabIndex = 1;
            this.SearchInWR.Text = "Search in Web Resources";
            this.SearchInWR.UseVisualStyleBackColor = true;
            // 
            // SearchInWRResult
            // 
            this.SearchInWRResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchInWRResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.IdColumn,
            this.TypeColumn,
            this.ContentColumn});
            this.SearchInWRResult.FullRowSelect = true;
            this.SearchInWRResult.Location = new System.Drawing.Point(0, 61);
            this.SearchInWRResult.Name = "SearchInWRResult";
            this.SearchInWRResult.Size = new System.Drawing.Size(933, 453);
            this.SearchInWRResult.TabIndex = 5;
            this.SearchInWRResult.UseCompatibleStateImageBehavior = false;
            this.SearchInWRResult.View = System.Windows.Forms.View.Details;
            this.SearchInWRResult.DoubleClick += new System.EventHandler(this.SearchInWRResult_DoubleClick);
            // 
            // NameColumn
            // 
            this.NameColumn.DisplayIndex = 2;
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 244;
            // 
            // IdColumn
            // 
            this.IdColumn.DisplayIndex = 0;
            this.IdColumn.Text = "ID";
            this.IdColumn.Width = 0;
            // 
            // TypeColumn
            // 
            this.TypeColumn.DisplayIndex = 1;
            this.TypeColumn.Text = "Type";
            this.TypeColumn.Width = 125;
            // 
            // ContentColumn
            // 
            this.ContentColumn.Text = "Content";
            this.ContentColumn.Width = 560;
            // 
            // SearchInWRXml
            // 
            this.SearchInWRXml.AutoSize = true;
            this.SearchInWRXml.Checked = true;
            this.SearchInWRXml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchInWRXml.Location = new System.Drawing.Point(308, 32);
            this.SearchInWRXml.Name = "SearchInWRXml";
            this.SearchInWRXml.Size = new System.Drawing.Size(48, 17);
            this.SearchInWRXml.TabIndex = 4;
            this.SearchInWRXml.Text = "XML";
            this.SearchInWRXml.UseVisualStyleBackColor = true;
            // 
            // SearchInWRJavaScript
            // 
            this.SearchInWRJavaScript.AutoSize = true;
            this.SearchInWRJavaScript.Checked = true;
            this.SearchInWRJavaScript.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchInWRJavaScript.Location = new System.Drawing.Point(226, 32);
            this.SearchInWRJavaScript.Name = "SearchInWRJavaScript";
            this.SearchInWRJavaScript.Size = new System.Drawing.Size(76, 17);
            this.SearchInWRJavaScript.TabIndex = 4;
            this.SearchInWRJavaScript.Text = "JavaScript";
            this.SearchInWRJavaScript.UseVisualStyleBackColor = true;
            // 
            // SearchInWRStyles
            // 
            this.SearchInWRStyles.AutoSize = true;
            this.SearchInWRStyles.Checked = true;
            this.SearchInWRStyles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchInWRStyles.Location = new System.Drawing.Point(166, 32);
            this.SearchInWRStyles.Name = "SearchInWRStyles";
            this.SearchInWRStyles.Size = new System.Drawing.Size(54, 17);
            this.SearchInWRStyles.TabIndex = 4;
            this.SearchInWRStyles.Text = "Styles";
            this.SearchInWRStyles.UseVisualStyleBackColor = true;
            // 
            // SearchInWRHtml
            // 
            this.SearchInWRHtml.AutoSize = true;
            this.SearchInWRHtml.Checked = true;
            this.SearchInWRHtml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchInWRHtml.Location = new System.Drawing.Point(104, 32);
            this.SearchInWRHtml.Name = "SearchInWRHtml";
            this.SearchInWRHtml.Size = new System.Drawing.Size(56, 17);
            this.SearchInWRHtml.TabIndex = 4;
            this.SearchInWRHtml.Text = "HTML";
            this.SearchInWRHtml.UseVisualStyleBackColor = true;
            // 
            // SearchInWRFindButton
            // 
            this.SearchInWRFindButton.Location = new System.Drawing.Point(396, 32);
            this.SearchInWRFindButton.Name = "SearchInWRFindButton";
            this.SearchInWRFindButton.Size = new System.Drawing.Size(75, 23);
            this.SearchInWRFindButton.TabIndex = 3;
            this.SearchInWRFindButton.Text = "Find";
            this.SearchInWRFindButton.UseVisualStyleBackColor = true;
            this.SearchInWRFindButton.Click += new System.EventHandler(this.SearchInWRFindButton_Click);
            // 
            // SearchInWRString
            // 
            this.SearchInWRString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchInWRString.Location = new System.Drawing.Point(104, 6);
            this.SearchInWRString.Name = "SearchInWRString";
            this.SearchInWRString.Size = new System.Drawing.Size(823, 20);
            this.SearchInWRString.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "String for Search";
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
            // EverywhereSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "EverywhereSearchControl";
            this.Size = new System.Drawing.Size(941, 565);
            this.Load += new System.EventHandler(this.EverywhereSearchControl_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.SearchTypeTabs.ResumeLayout(false);
            this.SearchById.ResumeLayout(false);
            this.SearchById.PerformLayout();
            this.SearchByIdResult.ResumeLayout(false);
            this.SearchByIdResult.PerformLayout();
            this.SearchInWR.ResumeLayout(false);
            this.SearchInWR.PerformLayout();
            this.MainCommandBar.ResumeLayout(false);
            this.MainCommandBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip MainCommandBar;
        private System.Windows.Forms.ToolStripButton CloseButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton AboutDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem AboutButton;
        private System.Windows.Forms.TabControl SearchTypeTabs;
        private System.Windows.Forms.TabPage SearchById;
        private System.Windows.Forms.TextBox SearchByIdString;
        private System.Windows.Forms.CheckBox SearchByIdFindCustom;
        private System.Windows.Forms.CheckBox SearchByIdFindSystem;
        private System.Windows.Forms.GroupBox SearchByIdResult;
        private System.Windows.Forms.TextBox SearchByIdName;
        private System.Windows.Forms.TextBox SearchByIdEntityDisplayName;
        private System.Windows.Forms.TextBox SearchByIdEntityLogicalName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchByIdFindButton;
        private System.Windows.Forms.Button SearchByIdOpenInCrmButton;
        private System.Windows.Forms.TabPage SearchInWR;
        private System.Windows.Forms.CheckBox SearchInWRXml;
        private System.Windows.Forms.CheckBox SearchInWRJavaScript;
        private System.Windows.Forms.CheckBox SearchInWRStyles;
        private System.Windows.Forms.CheckBox SearchInWRHtml;
        private System.Windows.Forms.Button SearchInWRFindButton;
        private System.Windows.Forms.TextBox SearchInWRString;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView SearchInWRResult;
        private System.Windows.Forms.ColumnHeader IdColumn;
        private System.Windows.Forms.ColumnHeader TypeColumn;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader ContentColumn;
    }
}
