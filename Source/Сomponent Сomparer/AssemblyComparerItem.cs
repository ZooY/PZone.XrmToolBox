using System;
using System.Windows.Forms;


namespace PZone.XrmToolBox
{
    public class AssemblyComparerItem : ListViewItem
    {
        public AssemblyComparerItem(string name, Guid? sourceId, string sourceVersion, Guid? otherId, string otherVersion)
        {
            var result = "";
            if (!string.IsNullOrWhiteSpace(sourceVersion) && !string.IsNullOrWhiteSpace(otherVersion))
            {
                var sv = new Version(sourceVersion);
                var ov = new Version(otherVersion);
                result = sv > ov ? ">" : sv < ov ? "<" : "";
            }
            else
            {
                result = string.IsNullOrWhiteSpace(sourceVersion) ? "<<" : ">>";
            }
            Text = name;
            SubItems.AddRange(new []
            {
                sourceId?.ToString()??"",
                sourceVersion ??"",
                "",
                result, otherId?.ToString()??"",
                otherVersion ??"",
                ""
            });
        }
    }
}