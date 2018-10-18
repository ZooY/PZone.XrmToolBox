using System;

namespace PZone.XrmToolBox
{
    public class PluginInfo
    {
        public PluginViewControl Control { get; set; }

        public DateTime LastPublish { get; set; } = DateTime.Now;


        public Guid? PluginAssemblyId { get; set; }

    }
}