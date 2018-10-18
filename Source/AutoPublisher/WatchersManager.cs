using System.Collections.Generic;
using System.IO;

namespace PZone.XrmToolBox
{
    public class WatchersManager
    {
        private readonly Dictionary<string, FileSystemWatcher> _watchers; // <Directory Name, FileSystemWatcher>
        private FileSystemEventHandler _onChangedHandler = null;
        public event FileSystemEventHandler Changed
        {
            add => _onChangedHandler += value;
            remove => _onChangedHandler -= value;
        }


        public WatchersManager()
        {
            _watchers = new Dictionary<string, FileSystemWatcher>();
        }


        public void Add(string directoryName)
        {
            if (_watchers.ContainsKey(directoryName))
                return;
            var watcher = new FileSystemWatcher(directoryName);
            watcher.Changed += Watcher_Changed;
            watcher.Renamed += Watcher_Changed;
            watcher.EnableRaisingEvents = true;
            _watchers.Add(directoryName, watcher);
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            _onChangedHandler(sender, e);
        }
    }
}