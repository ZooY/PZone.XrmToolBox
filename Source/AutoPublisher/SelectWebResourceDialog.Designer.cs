namespace PZone.XrmToolBox
{
    partial class SelectWebResourceDialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectWebResourceDialog));
            this.CancelButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.WebResourceTree = new System.Windows.Forms.TreeView();
            this.IconsList = new System.Windows.Forms.ImageList(this.components);
            this.HtmlFilterBox = new System.Windows.Forms.CheckBox();
            this.ScriptsFilterBox = new System.Windows.Forms.CheckBox();
            this.StylesFilterBox = new System.Windows.Forms.CheckBox();
            this.ImagesFilterBox = new System.Windows.Forms.CheckBox();
            this.XmlFilterBox = new System.Windows.Forms.CheckBox();
            this.OtherFilterBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(379, 423);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(88, 26);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SelectButton
            // 
            this.SelectButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SelectButton.Enabled = false;
            this.SelectButton.Location = new System.Drawing.Point(277, 423);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(0, 9, 14, 0);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(88, 26);
            this.SelectButton.TabIndex = 1;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectWebResource);
            // 
            // WebResourceTree
            // 
            this.WebResourceTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebResourceTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WebResourceTree.ImageIndex = 1;
            this.WebResourceTree.ImageList = this.IconsList;
            this.WebResourceTree.Location = new System.Drawing.Point(0, 31);
            this.WebResourceTree.Margin = new System.Windows.Forms.Padding(0);
            this.WebResourceTree.Name = "WebResourceTree";
            this.WebResourceTree.SelectedImageIndex = 1;
            this.WebResourceTree.Size = new System.Drawing.Size(484, 384);
            this.WebResourceTree.TabIndex = 2;
            this.WebResourceTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.WebResourceTree_AfterSelect);
            this.WebResourceTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.WebResourceTree_NodeMouseDoubleClick);
            // 
            // IconsList
            // 
            this.IconsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconsList.ImageStream")));
            this.IconsList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconsList.Images.SetKeyName(0, "ico.root.16.png");
            this.IconsList.Images.SetKeyName(1, "ico.folder.16.png");
            this.IconsList.Images.SetKeyName(2, "ico.html.16.png");
            this.IconsList.Images.SetKeyName(3, "ico.image.16.png");
            this.IconsList.Images.SetKeyName(4, "ico.xml.16.png");
            this.IconsList.Images.SetKeyName(5, "ico.style.16.png");
            this.IconsList.Images.SetKeyName(6, "ico.script.16.png");
            this.IconsList.Images.SetKeyName(7, "ico.other.16.png");
            // 
            // HtmlFilterBox
            // 
            this.HtmlFilterBox.AutoSize = true;
            this.HtmlFilterBox.Checked = true;
            this.HtmlFilterBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HtmlFilterBox.Location = new System.Drawing.Point(18, 8);
            this.HtmlFilterBox.Name = "HtmlFilterBox";
            this.HtmlFilterBox.Size = new System.Drawing.Size(56, 17);
            this.HtmlFilterBox.TabIndex = 3;
            this.HtmlFilterBox.Text = "HTML";
            this.HtmlFilterBox.UseVisualStyleBackColor = true;
            this.HtmlFilterBox.CheckedChanged += new System.EventHandler(this.FilterBox_CheckedChanged);
            // 
            // ScriptsFilterBox
            // 
            this.ScriptsFilterBox.AutoSize = true;
            this.ScriptsFilterBox.Checked = true;
            this.ScriptsFilterBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ScriptsFilterBox.Location = new System.Drawing.Point(80, 8);
            this.ScriptsFilterBox.Name = "ScriptsFilterBox";
            this.ScriptsFilterBox.Size = new System.Drawing.Size(58, 17);
            this.ScriptsFilterBox.TabIndex = 3;
            this.ScriptsFilterBox.Text = "Scripts";
            this.ScriptsFilterBox.UseVisualStyleBackColor = true;
            this.ScriptsFilterBox.CheckedChanged += new System.EventHandler(this.FilterBox_CheckedChanged);
            // 
            // StylesFilterBox
            // 
            this.StylesFilterBox.AutoSize = true;
            this.StylesFilterBox.Checked = true;
            this.StylesFilterBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StylesFilterBox.Location = new System.Drawing.Point(144, 8);
            this.StylesFilterBox.Name = "StylesFilterBox";
            this.StylesFilterBox.Size = new System.Drawing.Size(54, 17);
            this.StylesFilterBox.TabIndex = 3;
            this.StylesFilterBox.Text = "Styles";
            this.StylesFilterBox.UseVisualStyleBackColor = true;
            this.StylesFilterBox.CheckedChanged += new System.EventHandler(this.FilterBox_CheckedChanged);
            // 
            // ImagesFilterBox
            // 
            this.ImagesFilterBox.AutoSize = true;
            this.ImagesFilterBox.Checked = true;
            this.ImagesFilterBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ImagesFilterBox.Location = new System.Drawing.Point(204, 8);
            this.ImagesFilterBox.Name = "ImagesFilterBox";
            this.ImagesFilterBox.Size = new System.Drawing.Size(60, 17);
            this.ImagesFilterBox.TabIndex = 3;
            this.ImagesFilterBox.Text = "Images";
            this.ImagesFilterBox.UseVisualStyleBackColor = true;
            this.ImagesFilterBox.CheckedChanged += new System.EventHandler(this.FilterBox_CheckedChanged);
            // 
            // XmlFilterBox
            // 
            this.XmlFilterBox.AutoSize = true;
            this.XmlFilterBox.Checked = true;
            this.XmlFilterBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.XmlFilterBox.Location = new System.Drawing.Point(270, 8);
            this.XmlFilterBox.Name = "XmlFilterBox";
            this.XmlFilterBox.Size = new System.Drawing.Size(48, 17);
            this.XmlFilterBox.TabIndex = 3;
            this.XmlFilterBox.Text = "XML";
            this.XmlFilterBox.UseVisualStyleBackColor = true;
            this.XmlFilterBox.CheckedChanged += new System.EventHandler(this.FilterBox_CheckedChanged);
            // 
            // OtherFilterBox
            // 
            this.OtherFilterBox.AutoSize = true;
            this.OtherFilterBox.Checked = true;
            this.OtherFilterBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OtherFilterBox.Location = new System.Drawing.Point(324, 8);
            this.OtherFilterBox.Name = "OtherFilterBox";
            this.OtherFilterBox.Size = new System.Drawing.Size(52, 17);
            this.OtherFilterBox.TabIndex = 3;
            this.OtherFilterBox.Text = "Other";
            this.OtherFilterBox.UseVisualStyleBackColor = true;
            this.OtherFilterBox.CheckedChanged += new System.EventHandler(this.FilterBox_CheckedChanged);
            // 
            // SelectWebResourceDialog
            // 
            this.AcceptButton = this.SelectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.OtherFilterBox);
            this.Controls.Add(this.XmlFilterBox);
            this.Controls.Add(this.ImagesFilterBox);
            this.Controls.Add(this.StylesFilterBox);
            this.Controls.Add(this.ScriptsFilterBox);
            this.Controls.Add(this.HtmlFilterBox);
            this.Controls.Add(this.WebResourceTree);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.CancelButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectWebResourceDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Web Resource";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.TreeView WebResourceTree;
        private System.Windows.Forms.ImageList IconsList;
        private System.Windows.Forms.CheckBox HtmlFilterBox;
        private System.Windows.Forms.CheckBox ScriptsFilterBox;
        private System.Windows.Forms.CheckBox StylesFilterBox;
        private System.Windows.Forms.CheckBox ImagesFilterBox;
        private System.Windows.Forms.CheckBox XmlFilterBox;
        private System.Windows.Forms.CheckBox OtherFilterBox;
    }
}