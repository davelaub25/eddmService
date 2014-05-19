using System.Diagnostics;
using System.IO;
using System.ServiceProcess;

namespace eddmService
{
    public partial class eddmService : ServiceBase
    {
        public eddmService()
        {
            InitializeComponent();
            if (!EventLog.SourceExists("MySource"))
            {
                EventLog.CreateEventSource(
                    "MySource", "MyNewLog");
            }
            eventLog1.Source = "MySource";
            eventLog1.Log = "MyNewLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("In OnStart");
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("In onStop.");
        }

        protected override void OnContinue()
        {
            eventLog1.WriteEntry("In OnContinue.");
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry("PDF Found");
        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry("PDF Created");
        }
    }
}