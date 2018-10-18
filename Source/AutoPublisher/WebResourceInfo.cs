using System;

namespace PZone.XrmToolBox
{
    public class WebResourceInfo
    {
        public WebResourceViewControl Control { get; set; }

        public Guid WebResourceId { get; set; }


        public DateTime LastPublish { get; set; } = DateTime.Now;
    }
}