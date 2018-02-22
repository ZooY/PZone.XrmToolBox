using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;


namespace PZone.XrmToolBox
{
    public partial class ComponentComparerControl : MultipleConnectionsPluginControlBase, IGitHubPlugin //, IPayPalPlugin
    {
        private ListViewItem[] _items = new ListViewItem[0];

        public ComponentComparerControl()
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
        public string DonationDescription => "Donation for MSCRM Tools - PZone Сomponent Сomparer";
        public string EmailAccount => "roman@kopaev.ru";


        protected override void ConnectionDetailsUpdated(NotifyCollectionChangedEventArgs ee)
        {
            ConnectButton.Visible = false;
            ConnectionLabel.Visible = true;
            ConnectionLabel.Text = $"Connected to {AdditionalConnectionDetails.First().ConnectionName}";
            CompareMenu.Enabled = true;
            ShowMode.Enabled = true;
        }


        private void ConnectButton_Click(object sender, EventArgs ee)
        {
            AddAdditionalOrganization();
        }


        private List<Entity> RetrieveAssemblies(IOrganizationService service)
        {
            var query = "<fetch>" +
                        "<entity name=\"pluginassembly\">" +
                        "<attribute name=\"name\" />" +
                        "<attribute name=\"version\" />" +
                        "<filter>" +
                        "<condition attribute=\"sourcetype\" operator=\"eq\" value=\"0\" />" +
                        "<condition attribute=\"introducedversion\" operator=\"eq\" value=\"1.0\" />" +
                        "</filter>" +
                        "</entity>" +
                        "</fetch>";
            var assemblies = service.RetrieveMultiple(new FetchExpression(query));
            return assemblies.Entities.ToList();
        }


        private List<Entity> RetrieveWebResources(IOrganizationService service, params int[] types)
        {
            var query = "<fetch>" +
                        "<entity name=\"webresource\">" +
                        "<attribute name=\"name\" />" +
                        "<attribute name=\"content\" />" +
                        "<filter>" +
                        "<condition attribute=\"webresourcetype\" operator=\"in\">" +
                        "<value>" + string.Join("</value><value>", types) + "</value>" +
                        "</condition>" +
                        "</filter>" +
                        "</entity>" +
                        "</fetch>";
            var assemblies = service.RetrieveMultiple(new FetchExpression(query));
            return assemblies.Entities.ToList();
        }


        private void СomponentСomparerControl_Load(object sender, EventArgs e)
        {
            ConnectionLabel.Visible = false;
            CompareMenu.Enabled = false;
            ShowMode.Enabled = false;
            ShowMode.SelectedIndex = 0;
            ResultList.Items.Clear();
        }


        private void ComparePluginsButton_Click(object sender, EventArgs ee)
        {
            SourceIdColumn.DisplayIndex = 0;
            OtherIdColumn.DisplayIndex = 1;
            SourceSizeColumn.DisplayIndex = 2;
            OtherSizeColumn.DisplayIndex = 3;
            NameColumn.DisplayIndex = 4;
            SourceVersionColumn.DisplayIndex = 5;
            ResultColumn.DisplayIndex = 6;
            OtherVersionColumn.DisplayIndex = 7;

            SourceIdColumn.Width = 0;
            OtherIdColumn.Width = 0;
            SourceSizeColumn.Width = 0;
            OtherSizeColumn.Width = 3;
            NameColumn.Width = 300;
            SourceVersionColumn.Width = 60;
            ResultColumn.Width = 40;
            OtherVersionColumn.Width = 60;

            ResultList.Items.Clear();

            var otherConnection = AdditionalConnectionDetails.First();
            var otherService = otherConnection.GetCrmServiceClient();

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Compare Plug-ins...",
                Work = (w, e) =>
                {
                    var retrieveSourceAssembliesTask = Task.Run(() => RetrieveAssemblies(Service));
                    var retrieveOtherAssembliesTask = Task.Run(() => RetrieveAssemblies(otherService));
                    Task.WaitAll(retrieveSourceAssembliesTask, retrieveOtherAssembliesTask);
                    var sourceAssemblies = retrieveSourceAssembliesTask.Result;
                    var otherAssemblies = retrieveOtherAssembliesTask.Result;
                    var items = new List<ListViewItem>();
                    foreach (var sourceAssembly in sourceAssemblies)
                    {
                        var name = sourceAssembly.GetAttributeValue<string>("name");
                        var version = sourceAssembly.GetAttributeValue<string>("version");
                        var versionParts = version.Split('.');
                        var versionPattern = $"{versionParts[0]}.{versionParts[1]}.";
                        var otherAssembly = otherAssemblies.FirstOrDefault(a => a.GetAttributeValue<string>("name") == name && a.GetAttributeValue<string>("version").StartsWith(versionPattern));
                        if (otherAssembly == null)
                        {
                            items.Add(new AssemblyComparerItem(name, sourceAssembly.Id, version, null, null) { Group = ResultList.Groups["PluginsGroup"] });
                        }
                        else
                        {
                            items.Add(new AssemblyComparerItem(name, sourceAssembly.Id, version, otherAssembly.Id, otherAssembly.GetAttributeValue<string>("version")) { Group = ResultList.Groups["PluginsGroup"] });
                            otherAssemblies.Remove(otherAssembly);
                        }
                    }
                    foreach (var otherAssembly in otherAssemblies)
                        items.Add(new AssemblyComparerItem(otherAssembly.GetAttributeValue<string>("name"), null, null, otherAssembly.Id, otherAssembly.GetAttributeValue<string>("version")) { Group = ResultList.Groups["PluginsGroup"] });
                    e.Result = items.OrderBy(lvi => lvi.Name).ToArray();
                },
                PostWorkCallBack = e =>
                {
                    _items = (ListViewItem[])e.Result;
                    ShowMode_SelectedIndexChanged(null, null);
                },
                MessageWidth = 340,
                MessageHeight = 150
            });
        }


        private void CompareJsButton_Click(object sender, EventArgs e)
        {
            CompareWebResources("JavaScript", new[] { 3 });
        }


        private void CompareHtmlButton_Click(object sender, EventArgs e)
        {
            CompareWebResources("HTML", new[] { 1 });
        }


        private void CompareWebResources(string resourveName, int[] resourceTypes)
        {
            SourceIdColumn.DisplayIndex = 0;
            OtherIdColumn.DisplayIndex = 1;
            SourceVersionColumn.DisplayIndex = 2;
            OtherVersionColumn.DisplayIndex = 3;
            NameColumn.DisplayIndex = 4;
            SourceSizeColumn.DisplayIndex = 5;
            ResultColumn.DisplayIndex = 6;
            OtherSizeColumn.DisplayIndex = 7;

            SourceIdColumn.Width = 0;
            OtherIdColumn.Width = 0;
            SourceVersionColumn.Width = 0;
            OtherVersionColumn.Width = 0;
            NameColumn.Width = 300;
            SourceSizeColumn.Width = 60;
            ResultColumn.Width = 40;
            OtherSizeColumn.Width = 60;

            ResultList.Items.Clear();

            var otherConnection = AdditionalConnectionDetails.First();
            var otherService = otherConnection.GetCrmServiceClient();

            WorkAsync(new WorkAsyncInfo
            {
                Message = $"Compare {resourveName} Web Resources...",
                Work = (w, e) =>
                {
                    var retrieveSourceResourcesTask = Task.Run(() => RetrieveWebResources(Service, resourceTypes));
                    var retrieveOtherResourcesTask = Task.Run(() => RetrieveWebResources(otherService, resourceTypes));
                    Task.WaitAll(retrieveSourceResourcesTask, retrieveOtherResourcesTask);
                    var sourceResources = retrieveSourceResourcesTask.Result;
                    var otherResources = retrieveOtherResourcesTask.Result;

                    var items = new List<ListViewItem>();
                    foreach (var sourceResource in sourceResources)
                    {
                        var name = sourceResource.GetAttributeValue<string>("name");
                        var content = sourceResource.GetAttributeValue<string>("content");
                        var otherResource = otherResources.FirstOrDefault(a => a.GetAttributeValue<string>("name") == name);
                        if (otherResource == null)
                        {
                            items.Add(new WebResourceComparerItem(name, sourceResource.Id, content, null, null));
                        }
                        else
                        {
                            items.Add(new WebResourceComparerItem(name, sourceResource.Id, content, otherResource.Id, otherResource.GetAttributeValue<string>("content")));
                            otherResources.Remove(otherResource);
                        }
                    }
                    foreach (var otherResource in otherResources)
                        items.Add(new WebResourceComparerItem(otherResource.GetAttributeValue<string>("name"), null, null, otherResource.Id, otherResource.GetAttributeValue<string>("content")));
                    e.Result = items.OrderBy(lvi => lvi.Name).ToArray();
                },
                PostWorkCallBack = e =>
                {
                    _items = (ListViewItem[])e.Result;
                    ShowMode_SelectedIndexChanged(null, null);
                },
                MessageWidth = 400,
                MessageHeight = 150
            });
        }


        private void CompareStylesButton_Click(object sender, EventArgs e)
        {
            CompareWebResources("Style (CSS, XSL)", new[] { 2, 9 });
        }


        private void CompareCssButton_Click(object sender, EventArgs e)
        {
            CompareWebResources("CSS", new[] { 2 });
        }


        private void CompareXslButton_Click(object sender, EventArgs e)
        {
            CompareWebResources("XSL", new[] { 9 });
        }


        private void CompareXmlButton_Click(object sender, EventArgs e)
        {
            CompareWebResources("XML", new[] { 4 });
        }


        private void CompareXapButton_Click(object sender, EventArgs e)
        {
            CompareWebResources("Silverlight", new[] { 8 });
        }


        private void CompareImagesButton_Click(object sender, EventArgs e)
        {
            CompareWebResources("Image (PNG, JPG, GIF, ICO)", new[] { 5, 6, 7, 10 });
        }


        private void ComparePngButton_Click(object sender, EventArgs e)
        {
            CompareWebResources("PNG", new[] { 5 });
        }


        private void CompareJpgButton_Click(object sender, EventArgs e)
        {
            CompareWebResources("JPG", new[] { 6 });
        }


        private void CompareGifButton_Click(object sender, EventArgs e)
        {
            CompareWebResources("GIF", new[] { 7 });
        }


        private void CompareIconsButton_Click(object sender, EventArgs e)
        {
            CompareWebResources("Icon", new[] { 10 });
        }

        private void ShowMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ShowMode.Enabled)
                return;
            ResultList.Items.Clear();
            ResultList.Items.AddRange((ShowMode.SelectedIndex == 0
                ? _items
                : _items.Where(lvi => !string.IsNullOrWhiteSpace(lvi.SubItems[4]?.Text))).OrderBy(lvi => lvi.Text).ToArray());
        }
    }
}