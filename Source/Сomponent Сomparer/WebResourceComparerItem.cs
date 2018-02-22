using System;
using System.Windows.Forms;


namespace PZone.XrmToolBox
{
    public class WebResourceComparerItem : ListViewItem
    {
        public WebResourceComparerItem(string name, Guid? sourceId, string sourceContent, Guid? otherId, string otherContent)
        {
            string result;
            if (sourceId != null && otherId != null)
            {
                var sourceContentLength = sourceContent?.Length ?? 0;
                var otherContentLength = otherContent?.Length ?? 0;
                result = sourceContentLength > otherContentLength ? ">" : sourceContentLength < otherContentLength ? "<" : "";
            }
            else
                result = sourceId == null ? "<<" : ">>";
            Text = name;
            SubItems.AddRange(new[]
            {
                sourceId?.ToString() ?? "",
                "",
                sourceId != null ? sourceContent?.Length.ToString()??"0" : "",
                result,
                otherId?.ToString() ?? "",
                "",
                otherId != null ? otherContent?.Length.ToString()??"0" : ""
            });
        }
    }
}