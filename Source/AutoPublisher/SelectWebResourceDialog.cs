using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace PZone.XrmToolBox
{
    public partial class SelectWebResourceDialog : Form
    {
        private readonly IEnumerable<Entity> _resources;

        public static IOrganizationService Service { get; set; }
        

        public Guid WebResourceId { get; set; }


        public string WebResourceName { get; set; }

        
        public SelectWebResourceDialog(int typeCode)
        {
            InitializeComponent();

            var map = new Dictionary<int, CheckBox> { { 1, HtmlFilterBox }, { 2, StylesFilterBox }, { 9, StylesFilterBox }, { 3, ScriptsFilterBox }, { 4, XmlFilterBox }, { 5, ImagesFilterBox }, { 6, ImagesFilterBox }, { 7, ImagesFilterBox }, { 10, ImagesFilterBox }, { 8, OtherFilterBox } };
            if (typeCode != 0)
            {
                HtmlFilterBox.Checked = ScriptsFilterBox.Checked = StylesFilterBox.Checked = ImagesFilterBox.Checked = XmlFilterBox.Checked = OtherFilterBox.Checked = false;
                map[typeCode].Checked = true;
            }

            var fetchXml = @"
<fetch no-lock='true'>
  <entity name='webresource'>
    <attribute name='name' />
    <attribute name='webresourcetype' />
    <attribute name='displayname' />
    <attribute name='ismanaged' />
    <filter>
      <condition attribute='name' operator='not-begin-with' value='msdyn_'/>
      <condition attribute='ismanaged' operator='eq' value='0'/>
    </filter>
  </entity>
</fetch>";
            _resources = Service.RetrieveMultiple(new FetchExpression(fetchXml)).Entities.OrderBy(r=>r.GetAttributeValue<string>("name"));
            FilterBox_CheckedChanged(null, null);
        }


        private void BuildTree(IEnumerable<Entity> resources)
        {
            WebResourceTree.Nodes.Clear();

            foreach (var resource in resources)
            {
                var name = resource.GetAttributeValue<string>("name");
                var type = resource.GetAttributeValue<OptionSetValue>("webresourcetype").Value;
                var pathParts = name.Split('/');
                var path = string.Empty;
                TreeNode lastNode = null;
                var lastPathPart = pathParts.Last();
                foreach (var pathPart in pathParts)
                {
                    path += pathPart + "\\";
                    var nodes = WebResourceTree.Nodes.Find(path, true);
                    if (nodes.Length == 0)
                    {
                        var isLast = pathPart == lastPathPart;
                        var collection = lastNode == null ? WebResourceTree.Nodes : lastNode.Nodes;
                        TreeNode node;
                        if (isLast)
                        {
                            switch (type)
                            {
                                case 1:
                                    node = new HtmlTreeNode(name, resource.Id, pathPart);
                                    break;
                                case 2:
                                case 9:
                                    node = new StyleTreeNode(name, resource.Id, pathPart);
                                    break;
                                case 3:
                                    node = new ScriptTreeNode(name, resource.Id, pathPart);
                                    break;
                                case 4:
                                    node = new XmlTreeNode(name, resource.Id, pathPart);
                                    break;
                                case 5:
                                case 6:
                                case 7:
                                case 10:
                                    node = new ImageTreeNode(name, resource.Id, pathPart);
                                    break;
                                default:
                                    node = new OtherTreeNode(name, resource.Id, pathPart);
                                    break;
                            }
                        }
                        else
                            node = new TreeNode(pathPart) { Name = path };

                        collection.Add(node);
                        lastNode = node;
                    }
                    else
                        lastNode = nodes[0];
                }
            }
        }


        private void SelectWebResource(object sender, object e)
        {
            if (!(WebResourceTree.SelectedNode is WebResourceTreeNode wrNode))
                return;
            WebResourceId = wrNode.Id;
            WebResourceName = wrNode.Name;
        }

        private void WebResourceTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SelectButton.Enabled = e.Node is WebResourceTreeNode;
        }


        private void WebResourceTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SelectButton.PerformClick();
        }

        private void FilterBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_resources == null)
                return;

            var types = new List<int>();
            if(HtmlFilterBox.Checked)
                types.Add(1);
            if (StylesFilterBox.Checked)
                types.AddRange(new[] { 2, 9 });
            if (ScriptsFilterBox.Checked)
                types.Add(3);
            if (XmlFilterBox.Checked)
                types.Add(4);
            if (ImagesFilterBox.Checked)
                types.AddRange(new[] { 5, 6, 7, 10 });
            if (ImagesFilterBox.Checked)
                types.Add(8);

            var resources = _resources.Where(r => types.Contains(r.GetAttributeValue<OptionSetValue>("webresourcetype").Value));
            BuildTree(resources);
        }
    }

    public class RootTreeNode : TreeNode
    {
        public RootTreeNode(string key, string text) : base(text)
        {
            Name = key;
            ImageIndex = SelectedImageIndex = 0;
        }
    }


    public abstract class WebResourceTreeNode : TreeNode
    {
        public Guid Id { get; set; }


        protected WebResourceTreeNode(string key, Guid id, string text) : base(text)
        {
            Id = id;
            Name = key;
        }

    }


    public class HtmlTreeNode : WebResourceTreeNode
    {
        public HtmlTreeNode(string key, Guid id, string text) : base(key, id, text)
        {
            ImageIndex = SelectedImageIndex = 2;
        }
    }
    public class ImageTreeNode : WebResourceTreeNode
    {
        public ImageTreeNode(string key, Guid id, string text) : base(key, id, text)
        {
            ImageIndex = SelectedImageIndex = 3;
        }
    }
    public class StyleTreeNode : WebResourceTreeNode
    {
        public StyleTreeNode(string key, Guid id, string text) : base(key, id, text)
        {
            ImageIndex = SelectedImageIndex = 5;
        }
    }
    public class ScriptTreeNode : WebResourceTreeNode
    {
        public ScriptTreeNode(string key, Guid id, string text) : base(key, id, text)
        {
            ImageIndex = SelectedImageIndex = 6;
        }
    }
    public class XmlTreeNode : WebResourceTreeNode
    {
        public XmlTreeNode(string key, Guid id, string text) : base(key, id, text)
        {
            ImageIndex = SelectedImageIndex = 4;
        }
    }

    public class OtherTreeNode : WebResourceTreeNode
    {
        public OtherTreeNode(string key, Guid id, string text) : base(key, id, text)
        {
            ImageIndex = SelectedImageIndex = 7;
        }
    }
}
