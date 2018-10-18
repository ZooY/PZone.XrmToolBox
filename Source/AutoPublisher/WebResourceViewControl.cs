using System;
using System.Drawing;
using System.Windows.Forms;

namespace PZone.XrmToolBox
{
    public partial class WebResourceViewControl : UserControl
    {
        private EventHandler<string> _onPublishHandler = null;
        private EventHandler<string> _onCloseHandler = null;


        public WebResourceViewControl()
        {
            InitializeComponent();

            ProgressImage.Controls.Add(ProgressImageLayer);
            ProgressImageLayer.Location = new Point(0, 0);
            ProgressImageLayer.BackColor = Color.Transparent;

            DirtyImage.Controls.Add(DirtyImageLayer);
            DirtyImageLayer.Location = new Point(0, 0);
            DirtyImageLayer.BackColor = Color.Transparent;

            CloseImage.Controls.Add(CloseImageLayer);
            CloseImageLayer.Location = new Point(0, 0);
            CloseImageLayer.BackColor = Color.Transparent;
        }


        public event EventHandler<string> Publish
        {
            add => _onPublishHandler += value;
            remove => _onPublishHandler -= value;
        }


        public event EventHandler<string> Close
        {
            add => _onCloseHandler += value;
            remove => _onCloseHandler -= value;
        }


        public bool IsAuto
        {
            get => IsAutoCheckbox.Checked;
            set => IsAutoCheckbox.Checked = value;
        }


        public string FileName
        {
            get => FileNameBox.Text;
            set => FileNameBox.Text = value;
        }


        public bool IsBusy
        {
            get => ProgressImage.Visible;
            set
            {
                ProgressImage.Visible = value;
                ProgressImageLayer.Visible = value;
                IsAutoCheckbox.Enabled = !value;
                PublishButton.Enabled = !value;
            }
        }


        public bool IsDirty
        {
            get => DirtyImage.Visible;
            set => DirtyImage.Visible = value;
        }


        public string WebResourceName
        {
            get => WebResourceNameBox.Text;
            set => WebResourceNameBox.Text = value;
        }

        
        private void PublishButton_Click(object sender, EventArgs e)
        {
            _onPublishHandler(this, FileName);
        }


        private void CloseResource(object sender, EventArgs e)
        {
            _onCloseHandler(this, FileName);
        }
    }
}