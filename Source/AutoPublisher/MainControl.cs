using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace PZone.XrmToolBox
{
    public partial class MainControl : PluginControlBase, IGitHubPlugin //, IPayPalPlugin
    {
        // ReSharper disable once InconsistentNaming
        private static readonly Dictionary<string, int> _extensionTypeCodeMap = new Dictionary<string, int> { { ".htm", 1 }, { ".html", 1 }, { ".css", 2 }, { ".js", 3 }, { ".xml", 4 }, { ".png", 5 }, { ".jpg", 6 }, { ".jpeg", 6 }, { ".gif", 7 }, { ".xap", 8 }, { ".xsl", 9 } };


        private readonly WatchersManager _watchers = new WatchersManager();
        private readonly Dictionary<string, WebResourceInfo> _webResources = new Dictionary<string, WebResourceInfo>();
        private readonly Dictionary<string, PluginInfo> _plugins = new Dictionary<string, PluginInfo>();


        public MainControl()
        {
            InitializeComponent();

            WebResourcesList.Controls.Clear();
            WebResourcesList.RowStyles[0].SizeType = SizeType.Absolute;
            WebResourcesList.RowStyles[0].Height = 0;

            PluginsList.Controls.Clear();
            PluginsList.RowStyles[0].SizeType = SizeType.Absolute;
            PluginsList.RowStyles[0].Height = 0;

            _watchers.Changed += OnFileChanged;
        }


        // ReSharper disable UnusedMember.Global
        public string DonationDescription => "Donation for MSCRM Tools - PZone AutoPublisher";
        public string EmailAccount => "roman@kopaev.ru";
        // ReSharper restore UnusedMember.Global


        public string RepositoryName => "PZone.XrmToolBox";
        public string UserName => "ZooY";


        private void OnFileChanged(object sender, FileSystemEventArgs e)
        {
            if (_webResources.ContainsKey(e.FullPath))
            {
                var webResourceInfo = _webResources[e.FullPath];
                var lastWriteTime = File.GetLastWriteTime(e.FullPath);
                if (lastWriteTime == webResourceInfo.LastPublish)
                    return;
                webResourceInfo.Control.IsDirty = true;
                if (webResourceInfo.Control.IsAuto == false)
                    return;
                webResourceInfo.LastPublish = lastWriteTime;
                PublishWebResource(webResourceInfo);
                return;
            }

            if (_plugins.ContainsKey(e.FullPath))
            {
                var pluginInfo = _plugins[e.FullPath];
                pluginInfo.Control.IsDirty = true;
                //Task.Run(() =>
                //{
                //    for (var i = 0; i < 100; i++)
                //    {
                //        try
                //        {
                //            pluginInfo.Control.AssemblyVersion = AssemblyName.GetAssemblyName(e.FullPath).Version.ToString();
                //            if (pluginInfo.Control.IsAuto == false)
                //                return;
                //            PublishPlugin(Service, pluginInfo);
                //        }
                //        catch (FileLoadException)
                //        {
                //            Thread.Sleep(100);
                //        }
                //    }
                //    throw new Exception("Could not access the assembly. The assembly is used by another application.");
                //});
            }
        }


        private void PublishWebResource(WebResourceInfo webResourceInfo)
        {
            Task.Run(() =>
            {
                webResourceInfo.Control.IsBusy = true;
                var oldDirtyState = webResourceInfo.Control.IsDirty;
                webResourceInfo.Control.IsDirty = false;
                try
                {
                    var bytes = File.ReadAllBytes(webResourceInfo.Control.FileName);
                    var file = Convert.ToBase64String(bytes);
                    Service.Update(new Entity("webresource", webResourceInfo.WebResourceId) { ["content"] = file });
                    PublishWebResource(Service, webResourceInfo.WebResourceId);
                    webResourceInfo.Control.IsDirty = false;
                }
                catch
                {
                    webResourceInfo.Control.IsDirty = oldDirtyState;
                }
                finally
                {
                    webResourceInfo.Control.IsBusy = false;
                }
            });
        }


        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            SelectWebResourceDialog.Service = newService;
            base.UpdateConnection(newService, detail, actionName, parameter);
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseTool();
        }


        private void AboutButton_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            var fullFileName = FileNameBox.Text;

            var webResourceInfo = new WebResourceInfo
            {
                WebResourceId = (Guid)WebResourseNameBox.Tag,
                Control = new WebResourceViewControl
                {
                    Dock = DockStyle.Top,
                    Height = 46,
                    FileName = fullFileName,
                    WebResourceName = WebResourseNameBox.Text,
                    IsAuto = IsAutoCheckbox.Checked
                }
            };
            WebResourcesList.Controls.Add(webResourceInfo.Control, 1, WebResourcesList.RowCount);
            WebResourcesList.RowStyles.Add(new RowStyle(SizeType.Absolute, webResourceInfo.Control.Height + 10));
            WebResourcesList.RowCount++;
            webResourceInfo.Control.IsBusy = false;
            webResourceInfo.Control.IsDirty = false;
            webResourceInfo.Control.Publish += (ss, ee) => PublishWebResource(_webResources[ee]);
            webResourceInfo.Control.Close +=(ss,ee)=> CloseWebResource(ee);

            FileNameBox.Text = WebResourseNameBox.Text = string.Empty;
            IsAutoCheckbox.Checked = false;

            var directoryName = Path.GetDirectoryName(fullFileName);
            _watchers.Add(directoryName);
            if (!_webResources.ContainsKey(fullFileName))
                _webResources.Add(fullFileName, webResourceInfo);
        }


        private void CloseWebResource(string fileName)
        {
            var webResource = _webResources[fileName];

            var index = WebResourcesList.GetRow(webResource.Control);
            foreach (RowStyle rowStyle in WebResourcesList.RowStyles)
            {
                if (index == 0)
                {
                    rowStyle.Height = 1;
                    break;
                }
                index--;
            }

            WebResourcesList.Controls.Remove(webResource.Control);
            _webResources.Remove(fileName);
        }


        private void FileNameBox_TextChanged(object sender, EventArgs e)
        {
            AddButton.Enabled = !string.IsNullOrEmpty(FileNameBox.Text);
        }


        private void BrowseButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog { Filter = "All Web Resources files (*.htm, *.html, *.js, *.css, *.xml)|*.htm;*.html;*.js;*.css;*.xml|HTML files (*.htm, *.html)|*.htm;*.html|JavaScript files (*.js)|*.js|Style files (*.css)|*.css|XML files (*.xml)|*.xml" };
            if (dialog.ShowDialog() == DialogResult.OK)
                FileNameBox.Text = dialog.FileName;
        }


        private void BrowseWebResourceButton_Click(object sender, EventArgs e)
        {
            var extension = Path.GetExtension(FileNameBox.Text);
            var dialog = new SelectWebResourceDialog(string.IsNullOrEmpty(extension) || !_extensionTypeCodeMap.ContainsKey(extension) ? 0 : _extensionTypeCodeMap[extension]);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                WebResourseNameBox.Tag = dialog.WebResourceId;
                WebResourseNameBox.Text = dialog.WebResourceName;
            }
        }


        /// <summary>
        /// Публикация одного веб-ресурса.
        /// </summary>
        /// <param name="service">Ссылка на экземпляр CRM-сервиса.</param>
        /// <param name="resourceId">Идентификатор записи веб-ресурса.</param>
        public void PublishWebResource(IOrganizationService service, Guid resourceId)
        {
            service.Execute(new OrganizationRequest
            {
                RequestName = "PublishXml",
                Parameters = new ParameterCollection
                {
                    new KeyValuePair<string, object>("ParameterXml", $"<importexportxml><webresources><webresource>{resourceId}</webresource></webresources></importexportxml>")
                }
            });
        }


        private void BrowsePluginFileButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog { Filter = "Plug-in files (*.dll)|*.dll|All files|*.*" };
            if (dialog.ShowDialog() == DialogResult.OK)
                PluginFileNameBox.Text = dialog.FileName;
        }


        private void AddPluginButton_Click(object sender, EventArgs e)
        {
            var fullFileName = PluginFileNameBox.Text;

            var pluginInfo = new PluginInfo
            {
                //WebResourceId = (Guid)WebResourseNameBox.Tag,
                Control = new PluginViewControl
                {
                    Dock = DockStyle.Top,
                    Height = 22,
                    FileName = fullFileName,
                    //WebResourceName = WebResourseNameBox.Text,
                    IsAuto = IsAutoCheckbox.Checked
                }
            };
            PluginsList.Controls.Add(pluginInfo.Control, 1, WebResourcesList.RowCount);
            PluginsList.RowStyles.Add(new RowStyle(SizeType.Absolute, pluginInfo.Control.Height + 10));
            PluginsList.RowCount++;
            pluginInfo.Control.IsBusy = false;
            pluginInfo.Control.IsDirty = false;
            pluginInfo.Control.Publish += (ss, ee) => PublishPlugin(Service, _plugins[ee]);

            PluginFileNameBox.Text = string.Empty;
            PluginAutoCheckbox.Checked = false;

            var directoryName = Path.GetDirectoryName(fullFileName);
            _watchers.Add(directoryName);
            if (!_plugins.ContainsKey(fullFileName))
                _plugins.Add(fullFileName, pluginInfo);
        }


        private static void PublishPlugin(IOrganizationService service, PluginInfo pluginInfo)
        {
            Task.Run(() =>
            {
                pluginInfo.Control.IsBusy = true;
                var oldDirtyState = pluginInfo.Control.IsDirty;
                pluginInfo.Control.IsDirty = false;
                try
                {
                    if (pluginInfo.PluginAssemblyId == null)
                    {
                        var assemblyNameInfo = AssemblyName.GetAssemblyName(pluginInfo.Control.FileName);
                        var assemblyName = assemblyNameInfo.Name;
                        var assemblyVersion = $"{assemblyNameInfo.Version.Major}.{assemblyNameInfo.Version.Minor}";
                        var assemblyPublicKeyToken = GetPublicKeyToken(assemblyNameInfo);


                        var query = new QueryExpression("pluginassembly")
                        {
                            ColumnSet = new ColumnSet("pluginassemblyid"),
                            Criteria = new FilterExpression(LogicalOperator.And)
                            {
                                Conditions =
                                {
                                    new ConditionExpression("name", ConditionOperator.Equal, assemblyName),
                                    new ConditionExpression("publickeytoken", ConditionOperator.Equal, assemblyPublicKeyToken),
                                    new ConditionExpression("version", ConditionOperator.BeginsWith, assemblyVersion),
                                }
                            }
                        };
                        pluginInfo.PluginAssemblyId = service.RetrieveMultiple(query).Entities.First().Id;
                    }

                    var bytes = File.ReadAllBytes(pluginInfo.Control.FileName);
                    service.Update(new Entity("pluginassembly", pluginInfo.PluginAssemblyId.Value)
                    {
                        ["content"] = Convert.ToBase64String(bytes)
                    });

                    pluginInfo.Control.IsDirty = false;
                }
                catch
                {
                    pluginInfo.Control.IsDirty = oldDirtyState;
                }
                finally
                {
                    pluginInfo.Control.IsBusy = false;
                }
            });
        }


        private static string GetPublicKeyToken(AssemblyName assemblyNameInfo)
        {
            var publicKeyTokenString = "";
            var token = assemblyNameInfo.GetPublicKeyToken();
            for (var i = 0; i < token.GetLength(0); i++)
                publicKeyTokenString += token[i].ToString("x2");
            return publicKeyTokenString;
        }
    }
}