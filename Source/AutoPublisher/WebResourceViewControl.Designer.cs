namespace PZone.XrmToolBox
{
    partial class WebResourceViewControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebResourceViewControl));
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.IsAutoCheckbox = new System.Windows.Forms.CheckBox();
            this.PublishButton = new System.Windows.Forms.Button();
            this.WebResourceNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProgressImage = new System.Windows.Forms.PictureBox();
            this.ProgressImageLayer = new System.Windows.Forms.PictureBox();
            this.DirtyImageLayer = new System.Windows.Forms.PictureBox();
            this.DirtyImage = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CloseImage = new System.Windows.Forms.PictureBox();
            this.CloseImageLayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressImageLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirtyImageLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirtyImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseImageLayer)).BeginInit();
            this.SuspendLayout();
            // 
            // FileNameBox
            // 
            this.FileNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameBox.Location = new System.Drawing.Point(104, 1);
            this.FileNameBox.Margin = new System.Windows.Forms.Padding(0);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.ReadOnly = true;
            this.FileNameBox.Size = new System.Drawing.Size(340, 20);
            this.FileNameBox.TabIndex = 0;
            // 
            // IsAutoCheckbox
            // 
            this.IsAutoCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IsAutoCheckbox.Location = new System.Drawing.Point(454, 0);
            this.IsAutoCheckbox.Name = "IsAutoCheckbox";
            this.IsAutoCheckbox.Size = new System.Drawing.Size(50, 22);
            this.IsAutoCheckbox.TabIndex = 1;
            this.IsAutoCheckbox.Text = "Auto";
            this.IsAutoCheckbox.UseVisualStyleBackColor = true;
            // 
            // PublishButton
            // 
            this.PublishButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PublishButton.Location = new System.Drawing.Point(454, 24);
            this.PublishButton.Margin = new System.Windows.Forms.Padding(0);
            this.PublishButton.Name = "PublishButton";
            this.PublishButton.Size = new System.Drawing.Size(70, 22);
            this.PublishButton.TabIndex = 2;
            this.PublishButton.Text = "Publish";
            this.PublishButton.UseVisualStyleBackColor = true;
            this.PublishButton.Click += new System.EventHandler(this.PublishButton_Click);
            // 
            // WebResourceNameBox
            // 
            this.WebResourceNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebResourceNameBox.Location = new System.Drawing.Point(104, 25);
            this.WebResourceNameBox.Margin = new System.Windows.Forms.Padding(0);
            this.WebResourceNameBox.Name = "WebResourceNameBox";
            this.WebResourceNameBox.ReadOnly = true;
            this.WebResourceNameBox.Size = new System.Drawing.Size(340, 20);
            this.WebResourceNameBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Web Resource";
            // 
            // ProgressImage
            // 
            this.ProgressImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressImage.BackColor = System.Drawing.Color.Transparent;
            this.ProgressImage.Location = new System.Drawing.Point(508, 2);
            this.ProgressImage.Margin = new System.Windows.Forms.Padding(0);
            this.ProgressImage.Name = "ProgressImage";
            this.ProgressImage.Size = new System.Drawing.Size(16, 16);
            this.ProgressImage.TabIndex = 5;
            this.ProgressImage.TabStop = false;
            // 
            // ProgressImageLayer
            // 
            this.ProgressImageLayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressImageLayer.BackColor = System.Drawing.Color.White;
            this.ProgressImageLayer.Image = ((System.Drawing.Image)(resources.GetObject("ProgressImageLayer.Image")));
            this.ProgressImageLayer.Location = new System.Drawing.Point(422, 3);
            this.ProgressImageLayer.Margin = new System.Windows.Forms.Padding(0);
            this.ProgressImageLayer.Name = "ProgressImageLayer";
            this.ProgressImageLayer.Size = new System.Drawing.Size(16, 16);
            this.ProgressImageLayer.TabIndex = 6;
            this.ProgressImageLayer.TabStop = false;
            // 
            // DirtyImageLayer
            // 
            this.DirtyImageLayer.BackColor = System.Drawing.Color.Transparent;
            this.DirtyImageLayer.Image = ((System.Drawing.Image)(resources.GetObject("DirtyImageLayer.Image")));
            this.DirtyImageLayer.Location = new System.Drawing.Point(377, 3);
            this.DirtyImageLayer.Name = "DirtyImageLayer";
            this.DirtyImageLayer.Size = new System.Drawing.Size(16, 16);
            this.DirtyImageLayer.TabIndex = 7;
            this.DirtyImageLayer.TabStop = false;
            this.toolTip1.SetToolTip(this.DirtyImageLayer, "File updated");
            // 
            // DirtyImage
            // 
            this.DirtyImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DirtyImage.BackColor = System.Drawing.Color.Transparent;
            this.DirtyImage.Location = new System.Drawing.Point(508, 2);
            this.DirtyImage.Margin = new System.Windows.Forms.Padding(0);
            this.DirtyImage.Name = "DirtyImage";
            this.DirtyImage.Size = new System.Drawing.Size(16, 16);
            this.DirtyImage.TabIndex = 8;
            this.DirtyImage.TabStop = false;
            this.toolTip1.SetToolTip(this.DirtyImage, "File updated");
            // 
            // CloseImage
            // 
            this.CloseImage.BackColor = System.Drawing.Color.Transparent;
            this.CloseImage.Location = new System.Drawing.Point(0, 2);
            this.CloseImage.Margin = new System.Windows.Forms.Padding(0);
            this.CloseImage.Name = "CloseImage";
            this.CloseImage.Size = new System.Drawing.Size(16, 16);
            this.CloseImage.TabIndex = 9;
            this.CloseImage.TabStop = false;
            this.toolTip1.SetToolTip(this.CloseImage, "Close Resource");
            this.CloseImage.Click += new System.EventHandler(this.CloseResource);
            // 
            // CloseImageLayer
            // 
            this.CloseImageLayer.BackColor = System.Drawing.Color.Transparent;
            this.CloseImageLayer.Image = ((System.Drawing.Image)(resources.GetObject("CloseImageLayer.Image")));
            this.CloseImageLayer.Location = new System.Drawing.Point(115, 3);
            this.CloseImageLayer.Name = "CloseImageLayer";
            this.CloseImageLayer.Size = new System.Drawing.Size(16, 16);
            this.CloseImageLayer.TabIndex = 10;
            this.CloseImageLayer.TabStop = false;
            this.toolTip1.SetToolTip(this.CloseImageLayer, "Close Resource");
            this.CloseImageLayer.Click += new System.EventHandler(this.CloseResource);
            // 
            // WebResourceViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CloseImageLayer);
            this.Controls.Add(this.CloseImage);
            this.Controls.Add(this.DirtyImage);
            this.Controls.Add(this.DirtyImageLayer);
            this.Controls.Add(this.ProgressImageLayer);
            this.Controls.Add(this.ProgressImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WebResourceNameBox);
            this.Controls.Add(this.PublishButton);
            this.Controls.Add(this.IsAutoCheckbox);
            this.Controls.Add(this.FileNameBox);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "WebResourceViewControl";
            this.Size = new System.Drawing.Size(524, 46);
            ((System.ComponentModel.ISupportInitialize)(this.ProgressImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressImageLayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirtyImageLayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirtyImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseImageLayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.CheckBox IsAutoCheckbox;
        private System.Windows.Forms.Button PublishButton;
        private System.Windows.Forms.TextBox WebResourceNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ProgressImage;
        private System.Windows.Forms.PictureBox ProgressImageLayer;
        private System.Windows.Forms.PictureBox DirtyImageLayer;
        private System.Windows.Forms.PictureBox DirtyImage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox CloseImage;
        private System.Windows.Forms.PictureBox CloseImageLayer;
    }
}
