namespace PZone.XrmToolBox
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.GitHubLink = new System.Windows.Forms.LinkLabel();
            this.PZoneLink = new System.Windows.Forms.LinkLabel();
            this.BugReportLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(99, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "PZone Plug-in Downloader";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(103, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "for Microsoft Dynamics CRM 2016 / Dynamics 365";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label3.Location = new System.Drawing.Point(103, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "version";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.VersionLabel.Location = new System.Drawing.Point(156, 72);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(54, 21);
            this.VersionLabel.TabIndex = 2;
            this.VersionLabel.Text = "0.0.0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(104, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Author:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLabel.Location = new System.Drawing.Point(147, 106);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(113, 15);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "Firstname Lastname";
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CopyrightLabel.Location = new System.Drawing.Point(104, 121);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(84, 15);
            this.CopyrightLabel.TabIndex = 2;
            this.CopyrightLabel.Text = "Copyright info";
            // 
            // GitHubLink
            // 
            this.GitHubLink.AutoSize = true;
            this.GitHubLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GitHubLink.Location = new System.Drawing.Point(103, 165);
            this.GitHubLink.Name = "GitHubLink";
            this.GitHubLink.Size = new System.Drawing.Size(171, 15);
            this.GitHubLink.TabIndex = 3;
            this.GitHubLink.TabStop = true;
            this.GitHubLink.Text = "Plug-in source code on GitHub";
            this.GitHubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLink_LinkClicked_1);
            // 
            // PZoneLink
            // 
            this.PZoneLink.AutoSize = true;
            this.PZoneLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PZoneLink.Location = new System.Drawing.Point(104, 136);
            this.PZoneLink.Name = "PZoneLink";
            this.PZoneLink.Size = new System.Drawing.Size(83, 15);
            this.PZoneLink.TabIndex = 3;
            this.PZoneLink.TabStop = true;
            this.PZoneLink.Text = "www.pzone.ru";
            this.PZoneLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLink_LinkClicked);
            // 
            // BugReportLink
            // 
            this.BugReportLink.AutoSize = true;
            this.BugReportLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BugReportLink.Location = new System.Drawing.Point(103, 180);
            this.BugReportLink.Name = "BugReportLink";
            this.BugReportLink.Size = new System.Drawing.Size(69, 15);
            this.BugReportLink.TabIndex = 3;
            this.BugReportLink.TabStop = true;
            this.BugReportLink.Text = "Bug Repont";
            this.BugReportLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BugReportLink_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 219);
            this.Controls.Add(this.PZoneLink);
            this.Controls.Add(this.BugReportLink);
            this.Controls.Add(this.GitHubLink);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Text = "About Plug-in Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.LinkLabel GitHubLink;
        private System.Windows.Forms.LinkLabel PZoneLink;
        private System.Windows.Forms.LinkLabel BugReportLink;
    }
}