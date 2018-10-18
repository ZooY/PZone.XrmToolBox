using System;
using System.Drawing;
using System.Windows.Forms;

namespace PZone.XrmToolBox
{
    public partial class PluginViewControl : UserControl
    {
        private EventHandler<string> _onPublishHandler = null;
        private string _assemblyVersion;
        private string _crmVersion;


        public PluginViewControl()
        {
            InitializeComponent();

            ProgressImage.Controls.Add(ProgressImageLayer);
            ProgressImageLayer.Location = new Point(0, 0);
            ProgressImageLayer.BackColor = Color.Transparent;

            DirtyImage.Controls.Add(DirtyImageLayer);
            DirtyImageLayer.Location = new Point(0, 0);
            DirtyImageLayer.BackColor = Color.Transparent;
        }


        public event EventHandler<string> Publish
        {
            add => _onPublishHandler += value;
            remove => _onPublishHandler -= value;
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


        public string AssemblyVersion { get { return _assemblyVersion; } set { _assemblyVersion = value; BuildVersionInfo(); } }
        public string CrmVersion { get { return _crmVersion; } set { _crmVersion = value; BuildVersionInfo(); } }


        private void PublishButton_Click(object sender, EventArgs e)
        {
            _onPublishHandler(this, FileName);
        }


        private void BuildVersionInfo()
        {
            VersionInfo.Text = _assemblyVersion == null ? "?.?.?.?" : _assemblyVersion;
            VersionInfo.Text += _assemblyVersion == _crmVersion ? " = " : " -> ";
            VersionInfo.Text += _crmVersion == null ? "?.?.?.?" : _crmVersion;
        }
    }
}
