using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Crm.Sdk;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;


namespace PZone.XrmToolBox
{
    public partial class UserViewsManagerControl : PluginControlBase, IGitHubPlugin //, IPayPalPlugin
    {
        private string _userViewsFetchXml;

        public UserViewsManagerControl()
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
        public string DonationDescription => "Donation for MSCRM Tools - PZone User Views Manager";
        public string EmailAccount => "roman@kopaev.ru";


        private void UserViewsManagerControl_Load(object sender, EventArgs ee)
        {
            UsersList.Items.Clear();
            var fetchXml = @"
<fetch no-lock='true'>
  <entity name='systemuser'>
    <attribute name='domainname' />
    <attribute name='fullname' />
    <attribute name='isdisabled' />
    <filter>
      <condition attribute='fullname' operator='not-in'>
        <value>SYSTEM</value>
        <value>INTEGRATION</value>
      </condition>
    </filter>
    <order attribute='fullname' />
  </entity>
</fetch>";
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Retrieve Users...",
                Work = (w, e) =>
                {
                    e.Result = Service.RetrieveMultiple(new FetchExpression(fetchXml)).Entities.Select(u => new User
                    {
                        Id = u.Id,
                        Name = $"{u.GetAttributeValue<string>("fullname")} ({u.GetAttributeValue<string>("domainname")})" + (u.GetAttributeValue<bool>("isdisabled") ? " [disabled]" : "")
                    }).ToArray();
                },
                PostWorkCallBack = e =>
                {
                    UsersList.Items.AddRange((User[])e.Result);
                },
                MessageWidth = 340,
                MessageHeight = 150
            });
        }

        private void UsersList_SelectedIndexChanged(object sender, EventArgs ee)
        {
            var userId = ((User)UsersList.SelectedItem).Id;

            _userViewsFetchXml = $@"
<fetch no-lock='true'>
  <entity name='userquery'>
    <attribute name='name' />
    <attribute name='description' />
    <attribute name='querytype' />
    <attribute name='returnedtypecode' />
    <attribute name='fetchxml' />
    <attribute name='layoutxml' />
    <filter>
      <condition attribute='ownerid' operator='eq' value='{userId}'/>
    </filter>
  </entity>
</fetch>";

            var queryTypes = new Dictionary<int, string>
            {
                { 0, "Main Application View" }, // Specifies the main application view
                { 1, "Advanced Search" }, // An advanced search
                { 2, "Sub Grid" }, // A sub-grid
                { 4, "Quick Find Search" }, // A quick find query, which defines the columns searched using the Search field in a list view
                { 8, "Reporting" }, // A reporting query
                { 16, "Offline Filter" }, // An offline Microsoft Dynamics 365 for Outlook filter query
                { 64, "Lookup View" }, // A lookup view
                { 128, "Service Management Appointment Book View" }, // Specifies the service management appointment book view
                { 256, "Outlook Filter" }, // A Microsoft Dynamics 365 for Outlook filter query
                { 512, "Address Book Filter" }, //An address book filter
                { 1024, "Main Application View without Subject" }, // Specifies the main application view without a subject
                { 2048, "Other Saved Query Type" }, // A saved query used for workflow templates and email templates
                { 4096, "Interactive Workflow View" }, // A view for a dialog (workflow process)
                { 8192, "Offline Template" }, // An offline template for Dynamics 365 for Outlook
                { 16384, "Custom Defined View" }, // A custom view 
                { 131072, "Outlook Template" } // A template for Dynamics 365 for Outlook
            };


            WorkAsync(new WorkAsyncInfo
            {
                Message = "Retrieve Personal Views...",
                Work = (w, e) =>
                {
                    e.Result = Service.RetrieveMultiple(new FetchExpression(_userViewsFetchXml)).Entities.Select(a => new ListViewItem(new[]
                    {
                        a.GetAttributeValue<string>("name"),
                        a.Id.ToString(),
                        queryTypes[a.GetAttributeValue<int>("querytype")],
                        a.GetAttributeValue<string>("returnedtypecode"),
                        a.GetAttributeValue<string>("description")
                    })).ToArray();
                },
                PostWorkCallBack = e =>
                {
                    ViewsList.Items.AddRange((ListViewItem[])e.Result);
                    //ViewsList.Items[0].Selected = true;
                },
                MessageWidth = 340,
                MessageHeight = 150
            });
        }

        private void ShowViewsListFetchXml_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_userViewsFetchXml);
        }
    }


    public class View
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string EntityLogicalName { get; set; }
        public string Description { get; set; }
    }
}