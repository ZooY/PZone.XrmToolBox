using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;


namespace PZone.XrmToolBox
{
    public partial class EverywhereSearchControl : PluginControlBase, IGitHubPlugin //, IPayPalPlugin
    {
        private EntityMetadata[] _systemEntities;
        private EntityMetadata[] _customEntities;
        private readonly string[] _excludedEntities =
        {
            "subscriptionsyncentryoffline", "workflowwaitsubscription", "appmoduleroles", "customerrelationship", "subscriptionclients", "usermapping", "sdkmessagerequestfield", "postrole",
            "reportcategory", "socialinsightsconfiguration", "sdkmessagefilter", "license", "fieldpermission", "recommendationcache", "actioncarduserstate", "invaliddependency","integrationstatus",
            "queueitemcount", "workflowlog", "postlike", "connectionroleobjecttypecode", "importlog", "importentitymapping", "mailboxtrackingfolder", "interprocesslock", "picklistmapping",
            "rollupproperties", "leadaddress", "rollupfield", "fixedmonthlyfiscalcalendar", "subscription", "unresolvedaddress", "topichistory", "listmember", "untrackedemail", "childincidentcount",
            "lookupmapping", "systemusermanagermap", "ribboncommand", "businessprocessflowinstance", "attributemap", "dataperformance", "localconfigstore", "dynamicpropertyinstance", "dependencynode",
            "syncattributemapping", "businessunitmap", "duplicaterulecondition", "subscriptionstatisticsoutlook", "competitorproduct", "traceregarding", "partnerapplication", "duplicaterecord",
            "savedorginsightsconfiguration", "subscriptionsyncinfo", "organizationui", "officedocument", "ribbonrule", "calendarrule", "hierarchysecurityconfiguration", "usersearchfacet",
            "campaignactivityitem", "ribbondiff", "campaignitem", "topic", "clientupdate", "userentityuisettings", "mailboxstatistics", "customeropportunityrole", "systemapplicationmetadata",
            "sdkmessagepair", "recurrencerule", "sdkmessageresponsefield", "teamprofiles", "orginsightsmetric", "reportlink", "principalsyncattributemap", "isvconfig", "displaystringmap",
            "filtertemplate", "sdkmessagerequest", "dependencyfeature", "audit", "recommendationmodelversionhistory", "processtrigger", "commitment", "rollupjob", "userapplicationmetadata",
            "statusmap", "bulkoperationlog", "reportentity", "replicationbacklog", "quarterlyfiscalcalendar", "textanalyticsentitymapping", "ribbontabtocommandmap", "applicationfile", "imagedescriptor",
            "appmodulecomponent", "displaystring", "privilegeobjecttypecodes", "usersettings", "annualfiscalcalendar", "relationshiprolemap", "bulkdeletefailure", "ownermapping", "importjob", "sitemap",
            "principalobjectattributeaccess", "subscriptionsyncentryoutlook", "slaitem", "ribboncontextgroup", "businessdatalocalizedlabel", "postregarding", "notification", "topicmodelexecutionhistory",
            "sdkmessageprocessingstepsecureconfig", "reportvisibility", "resourcegroupexpansion", "exchangesyncidmapping", "organizationstatistic", "emailsearch", "transformationmapping",
            "workflowdependency", "sdkmessageresponse", "monthlyfiscalcalendar", "metadatadifference", "sharepointdata", "emailhash", "semiannualfiscalcalendar", "userfiscalcalendar", "multientitysearch",
            "delveactionhub", "userentityinstancedata", "systemuserprincipals", "syncattributemappingprofile", "queuemembercount", "timestampdatemapping", "productsubstitute", "dynamicpropertyassociation",
            "plugintypestatistic", "solutioncomponent", "subscriptiontrackingdeletedobject", "subscriptionmanuallytrackedobject", "actioncardusersettings", "stringmap", "discount",
            "customcontroldefaultconfig", "officegraphdocument", "systemuserbusinessunitentitymap", "internaladdress", "traceassociation", "teamsyncattributemappingprofiles", "salesprocessinstance",
            "authorizationserver", "bookableresourcebookingexchangesyncidmapping", "dependency", "complexcontrol", "entitymap", "ribboncustomization", "knowledgearticlescategories",
            "subscriptionstatisticsoffline"
        };


        public EverywhereSearchControl()
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
        public string DonationDescription => "Donation for MSCRM Tools - PZone Everywhere Search";
        public string EmailAccount => "roman@kopaev.ru";


        private void EverywhereSearchControl_Load(object sender, EventArgs e)
        {
            SearchByIdString.Text = "";
            SearchByIdResult.Visible = false;
        }


        private void SearchByIdFindButton_Click(object sender, EventArgs ee)
        {
            SearchByIdEntityLogicalName.Text = "";
            SearchByIdEntityDisplayName.Text = "";
            SearchByIdName.Text = "";
            SearchByIdOpenInCrmButton.Enabled = false;

            var guid = SearchByIdString.Text.Replace("{", "").Replace("}", "").Trim();

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Retrieve entitity list...",
                Work = (w, e) =>
                {
                    if (_systemEntities == null)
                    {
                        var request = new RetrieveAllEntitiesRequest { EntityFilters = EntityFilters.Entity };
                        var response = (RetrieveAllEntitiesResponse)Service.Execute(request);
                        var entities = response.EntityMetadata.Where(em => !string.IsNullOrWhiteSpace(em.DisplayName?.UserLocalizedLabel?.Label) && !_excludedEntities.Contains(em.LogicalName)).ToArray();
                        _systemEntities = entities.Where(em => !em.IsCustomEntity.HasValue || em.IsCustomEntity != true).ToArray();
                        _customEntities = entities.Where(em => em.IsCustomEntity.HasValue && em.IsCustomEntity == true).ToArray();
                    }

                    var count = (decimal)((SearchByIdFindSystem.Checked ? _systemEntities.Length : 0) + (SearchByIdFindCustom.Checked ? _customEntities.Length : 0));
                    var processUnit = count == 0 ? 0 : 100 / count;
                    decimal processPercent = 0;

                    if (SearchByIdFindSystem.Checked)
                    {
                        foreach (var entityMetadata in _systemEntities)
                        {
                            processPercent += processUnit;
                            w.ReportProgress((int)processPercent, entityMetadata.DisplayName.UserLocalizedLabel.Label);
                            string[] data;
                            if (!FingById(entityMetadata, guid, out data))
                                continue;
                            e.Result = data;
                            return;
                        }
                    }
                    if (SearchByIdFindCustom.Checked)
                    {
                        foreach (var entityMetadata in _customEntities)
                        {
                            processPercent += processUnit;
                            w.ReportProgress((int)processPercent, entityMetadata.DisplayName.UserLocalizedLabel.Label);
                            string[] data;
                            if (!FingById(entityMetadata, guid, out data))
                                continue;
                            e.Result = data;
                            return;
                        }
                    }
                    e.Result = null;
                },
                ProgressChanged = e =>
                {
                    SetWorkingMessage($"{e.ProgressPercentage}%{Environment.NewLine}{e.UserState}");
                },
                PostWorkCallBack = e =>
                {
                    var data = e.Result as string[];
                    if (data == null)
                    {
                        MessageBox.Show("Nothing found", "Search by ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    SearchByIdResult.Visible = true;
                    SearchByIdOpenInCrmButton.Enabled = true;
                    SearchByIdOpenInCrmButton.Tag = guid;
                    SearchByIdEntityLogicalName.Text = data[0];
                    SearchByIdEntityDisplayName.Text = data[1];
                    SearchByIdName.Text = data[2];
                },
                MessageWidth = 340,
                MessageHeight = 150
            });
        }


        private bool FingById(EntityMetadata entityMetadata, string guid, out string[] data)
        {
            var query = new QueryExpression(entityMetadata.LogicalName) { NoLock = true, TopCount = 1, ColumnSet = new ColumnSet(entityMetadata.PrimaryNameAttribute) };
            query.Criteria.AddCondition(entityMetadata.PrimaryIdAttribute, ConditionOperator.Equal, guid);
            var entity = Service.RetrieveMultiple(query).Entities.FirstOrDefault();
            if (entity == null)
            {
                data = null;
                return false;
            }
            var name = entity.GetAttributeValue<string>(entityMetadata.PrimaryNameAttribute);
            if (string.IsNullOrWhiteSpace(name))
                name = "<empty>";
            data = new[] { entityMetadata.LogicalName, entityMetadata.DisplayName.UserLocalizedLabel.Label, name };
            return true;
        }

        private void SearchByIdOpenInCrmButton_Click(object sender, EventArgs e)
        {
            var path = ConnectionDetail.WebApplicationUrl + $"/main.aspx?etn={SearchByIdEntityLogicalName.Text}&pagetype=entityrecord&id={SearchByIdOpenInCrmButton.Tag}";
            System.Diagnostics.Process.Start(path);
        }

        private void SearchInWRFindButton_Click(object sender, EventArgs ee)
        {
            var value = SearchInWRString.Text?.Trim();
            if (string.IsNullOrWhiteSpace(value))
            {
                SearchInWRString.Focus();
                return;
            }
            SearchInWRResult.Items.Clear();
            var types = new List<int>();
            if (SearchInWRHtml.Checked)
                types.Add(1);
            if (SearchInWRStyles.Checked)
                types.AddRange(new[] { 2, 9 });
            if(SearchInWRJavaScript.Checked)
                types.Add(3);
            if (SearchInWRXml.Checked)
                types.Add(4);
            if (types.Count < 1)
            {
                MessageBox.Show("Nothing found", "Search in Web Resources", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Retrieve Web Resources...",
                Work = (w, e) =>
                {
                    var query = "<fetch>" +
                        "<entity name=\"webresource\">" +
                        "<attribute name=\"name\" />" +
                        "<attribute name=\"content\" />" +
                        "<attribute name=\"webresourcetype\" />" +
                        "<filter>" +
                        "<condition attribute=\"webresourcetype\" operator=\"in\">" +
                        "<value>" + string.Join("</value><value>", types) + "</value>" +
                        "</condition>" +
                        "</filter>" +
                        "</entity>" +
                        "</fetch>";
            var resources = Service.RetrieveMultiple(new FetchExpression(query)).Entities;
                    w.ReportProgress(-1, "Search in Web Resources...");
                    var result = new List<ListViewItem>();
                    foreach (var resource in resources)
                    {
                        var content = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(resource.GetAttributeValue<string>("content")));
                        if (!content.Contains(value))
                            continue;
                        var wrapCount = 50;
                        var prefix = "...";
                        var postfix = "...";
                        var index = content.IndexOf(value);
                        index -= wrapCount;
                        if (index < 0)
                        {
                            index = 0;
                            prefix = "";
                        }
                        var length = value.Length + wrapCount*2;
                        string contentPart;
                        if (index + length >= content.Length)
                        {
                            contentPart = content.Substring(index);
                            postfix = "";
                        }
                        else
                            contentPart = content.Substring(index, length);
                        result.Add(new ListViewItem(new[] { resource.GetAttributeValue<string>("name"), resource.Id.ToString(), resource.FormattedValues["webresourcetype"], prefix + contentPart + postfix }));
                    }
                    e.Result = result.ToArray();
                },
                ProgressChanged = e =>
                {
                    SetWorkingMessage(e.UserState.ToString());
                },
                PostWorkCallBack = e =>
                {
                    var result = e.Result as ListViewItem[];
                    if (result == null)
                    {
                        MessageBox.Show("Nothing found", "Search in Web Resources", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    SearchInWRResult.Items.AddRange(result);
                },
                MessageWidth = 340,
                MessageHeight = 150
            });
        }

        private void SearchInWRResult_DoubleClick(object sender, EventArgs e)
        {
            if (SearchInWRResult.SelectedItems.Count < 1)
                return;
            var path = ConnectionDetail.WebApplicationUrl + $"/main.aspx?etn=webresource&pagetype=webresourceedit&id={SearchInWRResult.SelectedItems[0].SubItems[1].Text}";
            System.Diagnostics.Process.Start(path);
        }
    }
}