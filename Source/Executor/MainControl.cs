using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
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
        public MainControl()
        {
            InitializeComponent();
        }


        // ReSharper disable UnusedMember.Global
        public string DonationDescription => "Donation for MSCRM Tools - PZone AutoPublisher";
        public string EmailAccount => "roman@kopaev.ru";
        // ReSharper restore UnusedMember.Global


        public string RepositoryName => "PZone.XrmToolBox";
        public string UserName => "ZooY";



        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            //SelectWebResourceDialog.Service = newService;
            base.UpdateConnection(newService, detail, actionName, parameter);
            LoadData();
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseTool();
        }


        private void AboutButton_Click(object sender, EventArgs e)
        {
            //new AboutForm().ShowDialog();
        }


        private void LoadData()
        {
            var fetchXml = @"
<fetch distinct='true' no-lock='true'>
  <entity name='pluginassembly'>
    <attribute name='pluginassemblyid' />
    <attribute name='name' />
    <filter>
      <condition attribute='sourcetype' operator='neq' value='2'/>
      <condition attribute='name' operator='not-begin-with' value='ActivityFeeds.'/>
    </filter>
    <link-entity name='plugintype' from='pluginassemblyid' to='pluginassemblyid' alias='type'>
      <attribute name='version' />
    </link-entity>
  </entity>
</fetch>";
            var assemblyEntities = Service.RetrieveMultiple(new FetchExpression(fetchXml)).Entities;
            var assemblies = new List<AssemblyEntity>();
            foreach (var assembly in assemblyEntities)
                assemblies.Add(new AssemblyEntity(assembly.Id, $"{assembly.GetAttributeValue<string>("name")} ({assembly.GetAttributeValue<AliasedValue>("type.version").Value})"));

            AssembliesSource.DataSource = assemblies.OrderBy(a=>a.Name);

            AssemblyBox.DataSource = AssembliesSource;
            AssemblyBox.DisplayMember = "Name";
            AssemblyBox.ValueMember = "Id";
        }
    }
}


class AssemblyEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }


    public AssemblyEntity(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}


/*


  

  var fetchXml = $@"
<fetch no-lock='true'>
    <entity name='plugintype'>
        <attribute name='plugintypeid' />
        <attribute name='friendlyname' />
        <attribute name='version' />
        <attribute name='name' />
        <filter>
            <condition attribute='pluginassemblyid' operator='eq' value='b83d0d41-20d8-41ef-8431-262df5a119d0'/>
        </filter>
    </entity>
</fetch>";

*/
