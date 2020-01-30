using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Xrm.Sdk.Query;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;


namespace PZone.XrmToolBox
{
    public partial class ErrorAnalizerControl : PluginControlBase, IGitHubPlugin//, IPayPalPlugin
    {
        public ErrorAnalizerControl()
        {
            InitializeComponent();
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }


        public string RepositoryName => "PZone.XrmToolBox";
        public string UserName => "ZooY";
        public string DonationDescription => "Donation for MSCRM Tools - PZone Error Analizer";
        public string EmailAccount => "roman@kopaev.ru";



        private void AnalizeButton_Click(object sender, EventArgs e)
        {

        }
    }
}