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
    public partial class PluginDownloaderControl : PluginControlBase, IGitHubPlugin//, IPayPalPlugin
    {
        public PluginDownloaderControl()
        {
            InitializeComponent();
        }


        private void DownloadButton_Click(object sender, System.EventArgs e)
        {
            var assemblyId = PluginsList.SelectedItems[0].SubItems[0].Text;
            var assembly = Service.Retrieve("pluginassembly", new Guid(assemblyId), new ColumnSet("name", "content"));
            var name = assembly.GetAttributeValue<string>("name");
            var content = assembly.GetAttributeValue<string>("content");

            SaveAssemblyDialog.FileName = name;
            var dialog = SaveAssemblyDialog.ShowDialog();
            if (dialog == DialogResult.OK)
                File.WriteAllBytes(SaveAssemblyDialog.FileName, Convert.FromBase64String(content));
        }


        private void PluginDownloaderControl_Load(object sender, System.EventArgs ee)
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Retrieve Plug-ins...",
                Work = (w, e) =>
                {
                    var query = "<fetch>" +
                                "<entity name=\"pluginassembly\">" +
                                "<attribute name=\"name\" />" +
                                "<attribute name=\"version\" />" +
                                "<filter>" +
                                "<condition attribute=\"sourcetype\" operator=\"eq\" value=\"0\" />" +
                                "<condition attribute=\"introducedversion\" operator=\"eq\" value=\"1.0\" />" +
                                "</filter>" +
                                "<order attribute=\"name\" />" +
                                "</entity>" +
                                "</fetch>";
                    var assemblies = Service.RetrieveMultiple(new FetchExpression(query));
                    e.Result = assemblies.Entities.Select(a => new ListViewItem(new[] { a.Id.ToString(), a.GetAttributeValue<string>("name"), a.GetAttributeValue<string>("version") })).ToArray();
                },
                PostWorkCallBack = e =>
                {
                    PluginsList.Items.AddRange((ListViewItem[])e.Result);
                    PluginsList.Items[0].Selected = true;
                },
                MessageWidth = 340,
                MessageHeight = 150
            });
        }


        private void PluginsList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DownloadButton.Enabled = PluginsList.SelectedItems.Count > 0;
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
        public string DonationDescription => "Donation for MSCRM Tools - PZone Plug-in Downloader";
        public string EmailAccount => "roman@kopaev.ru";

        private void ExportButton_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog 
                {
                    Title = "Choose file to save to",
                    FileName = "Plug-ins.csv",
                    Filter = "CSV (*.csv)|*.csv",
                    FilterIndex = 0,
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            var headers = PluginsList.Columns.OfType<ColumnHeader>().Select(header => header.Text.Trim()).ToArray();
            var items = PluginsList.Items
                .OfType<ListViewItem>()
                .Select(lvi => lvi.SubItems
                    .OfType<ListViewItem.ListViewSubItem>()
                    .Select(si => si.Text).ToArray()).ToArray();

            var table = string.Join(";", headers) + Environment.NewLine;
            table = items.Aggregate(table, (current, a) => current + (string.Join(";", a) + Environment.NewLine));
            table = table.TrimEnd('\r', '\n');
            File.WriteAllText(sfd.FileName, table, Encoding.UTF8);
        }
    }
}